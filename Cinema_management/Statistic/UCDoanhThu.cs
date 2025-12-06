using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using Cinema_management.DAL;
using System.Globalization;
using Krypton.Toolkit; // Thêm namespace này để dùng KryptonLabel

namespace Cinema_management
{
    public partial class UCDoanhThu : UserControl
    {
        private Database db = new Database();
        // Màu đỏ rượu cố định cho chữ
        private Color textRedColor = Color.FromArgb(194, 45, 64); 

        public UCDoanhThu()
        {
            InitializeComponent();
            
            // Cấu hình Label tiền để không bị mất chữ
            kryptonLabel14.AutoSize = true;
            kryptonLabel14.StateCommon.ShortText.Color1 = textRedColor;
            kryptonLabel14.StateCommon.ShortText.Font = new Font("Nunito", 14F, FontStyle.Bold);
            
            // Cấu hình Label tiêu đề
            kryptonLabel2.StateCommon.ShortText.Color1 = textRedColor;

            this.kryptonComboBox2.SelectedIndexChanged += new System.EventHandler(this.kryptonComboBox2_SelectedIndexChanged);
            kryptonComboBox1.SelectedIndex = 0; 
        }

        // --- HÀM MỚI: Đếm tổng số hóa đơn chính xác từ SQL ---
        private int GetTotalInvoices(int month, int year, bool isYearly)
        {
            try
            {
                string query;
                SqlParameter[] parameters;

                if (isYearly)
                {
                    // Đếm tất cả hóa đơn trong năm
                    query = "SELECT COUNT(*) FROM HOADON WHERE YEAR(NGAYLAP) = @Year AND DATHANHTOAN = 1";
                    parameters = new SqlParameter[] { new SqlParameter("@Year", year) };
                }
                else
                {
                    // Đếm hóa đơn trong tháng
                    query = "SELECT COUNT(*) FROM HOADON WHERE MONTH(NGAYLAP) = @Month AND YEAR(NGAYLAP) = @Year AND DATHANHTOAN = 1";
                    parameters = new SqlParameter[] { 
                        new SqlParameter("@Month", month),
                        new SqlParameter("@Year", year) 
                    };
                }

                DataTable dt = db.ReadData(query, parameters);
                if (dt != null && dt.Rows.Count > 0)
                {
                    return Convert.ToInt32(dt.Rows[0][0]);
                }
            }
            catch {}
            return 0;
        }

        private void UpdateSummaryPanel(decimal totalRevenue, int totalInvoices)
        {
            // Hiển thị tổng tiền (Màu đỏ đã set ở constructor)
            kryptonLabel14.Text = totalRevenue.ToString("N0", CultureInfo.GetCultureInfo("vi-VN")) + " VNĐ";
            
            // Hiển thị tổng số hóa đơn chính xác
            kryptonLabel8.Text = totalInvoices.ToString();
        }

        private void UpdateChartData(DataTable dt, string titleStr, Color barColor, string xAxisTitle)
        {
            // Cập nhật tiêu đề biểu đồ
            if (chartRevenue.Titles.Count > 0)
            {
                chartRevenue.Titles[0].Text = titleStr;
                chartRevenue.Titles[0].ForeColor = barColor; // Tiêu đề biểu đồ đổi màu theo cột
                chartRevenue.Titles[0].Font = new Font("Microsoft Sans Serif", 14, FontStyle.Bold);
            }
            else
            {
                 Title title = new Title(titleStr);
                 title.Font = new Font("Arial", 14, FontStyle.Bold);
                 title.ForeColor = barColor;
                 chartRevenue.Titles.Add(title);
            }

            // Xóa dữ liệu cũ
            chartRevenue.Series["Doanh Thu"].Points.Clear();
            chartRevenue.Series["Doanh Thu"].Color = barColor;

            // Cập nhật tên trục
            chartRevenue.ChartAreas[0].AxisX.Title = xAxisTitle;
            chartRevenue.ChartAreas[0].AxisY.Title = "Doanh thu (VNĐ)";
            chartRevenue.ChartAreas[0].AxisY.LabelStyle.Format = "#,##0"; // Format số trên trục Y

            if (dt == null || dt.Rows.Count == 0)
            {
                chartRevenue.Titles[0].Text = titleStr + " (Chưa có dữ liệu)";
                return;
            }

            foreach (DataRow row in dt.Rows)
            {
                string label = row[0].ToString(); 
                decimal value = Convert.ToDecimal(row[1]); 
                
                // Thêm điểm vào biểu đồ
                int pIndex = chartRevenue.Series["Doanh Thu"].Points.AddXY(label, value);
                // Format số trên đầu cột
                chartRevenue.Series["Doanh Thu"].Points[pIndex].Label = value.ToString("N0", CultureInfo.GetCultureInfo("vi-VN"));
            }
        }

        private void LoadRevenueData()
        {
            try
            {
                string type = kryptonComboBox1.Text;
                string time = kryptonComboBox2.Text;

                if (string.IsNullOrEmpty(time)) return;

                string query = "";
                SqlParameter[] parameters = null;
                Color chartColor;
                string xAxisTitle = "";
                int totalInvoices = 0; 
                decimal totalRevenue = 0;

                if (type == "Theo tháng")
                {
                    chartColor = Color.FromArgb(194, 45, 64); // Đỏ (Tháng)
                    xAxisTitle = "Ngày";

                    int month = int.Parse(time.Replace("Tháng ", ""));
                    int year = DateTime.Now.Year;

                    // 1. Lấy dữ liệu biểu đồ (Ngày, Doanh thu)
                    query = @"SELECT DAY(NGAYLAP) as Ngay, SUM(TONGTIEN) as DoanhThu 
                              FROM HOADON 
                              WHERE MONTH(NGAYLAP) = @Month AND YEAR(NGAYLAP) = @Year AND DATHANHTOAN = 1
                              GROUP BY DAY(NGAYLAP) 
                              ORDER BY DAY(NGAYLAP)";
                    
                    parameters = new SqlParameter[] {
                        new SqlParameter("@Month", month),
                        new SqlParameter("@Year", year)
                    };
                    
                    // 2. Lấy tổng số hóa đơn
                    totalInvoices = GetTotalInvoices(month, year, false);

                    DataTable dt = db.ReadData(query, parameters);
                    
                    // Tính tổng doanh thu từ bảng dữ liệu biểu đồ
                    if (dt != null)
                    {
                        foreach (DataRow row in dt.Rows)
                            if (row[1] != DBNull.Value) totalRevenue += Convert.ToDecimal(row[1]);
                    }

                    UpdateChartData(dt, $"DOANH THU THÁNG {month}/{year}", chartColor, xAxisTitle);
                    UpdateSummaryPanel(totalRevenue, totalInvoices); 
                }
                else if (type == "Theo năm")
                {
                    chartColor = Color.FromArgb(6, 174, 244); // Xanh (Năm)
                    xAxisTitle = "Tháng";

                    int year = int.Parse(time);

                    // 1. Lấy dữ liệu biểu đồ (Tháng, Doanh thu)
                    query = @"SELECT MONTH(NGAYLAP) as Thang, SUM(TONGTIEN) as DoanhThu 
                              FROM HOADON 
                              WHERE YEAR(NGAYLAP) = @Year AND DATHANHTOAN = 1
                              GROUP BY MONTH(NGAYLAP) 
                              ORDER BY MONTH(NGAYLAP)";

                    parameters = new SqlParameter[] { new SqlParameter("@Year", year) };

                    // 2. Lấy tổng số hóa đơn CẢ NĂM (True)
                    totalInvoices = GetTotalInvoices(0, year, true);

                    DataTable dt = db.ReadData(query, parameters);

                    // Tính tổng doanh thu
                    if (dt != null)
                    {
                        foreach (DataRow row in dt.Rows)
                            if (row[1] != DBNull.Value) totalRevenue += Convert.ToDecimal(row[1]);
                    }

                    UpdateChartData(dt, $"DOANH THU NĂM {year}", chartColor, xAxisTitle);
                    UpdateSummaryPanel(totalRevenue, totalInvoices);
                }
                
                // Cập nhật nhãn thời gian bên phải
                kryptonLabel4.Text = kryptonComboBox1.Text; 
                kryptonLabel6.Text = time; 
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
        }

        private void kryptonComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            kryptonComboBox2.Items.Clear();
            if (kryptonComboBox1.Text == "Theo tháng")
            {
                for (int i = 1; i <= 12; i++) kryptonComboBox2.Items.Add("Tháng " + i);
                kryptonComboBox2.SelectedIndex = DateTime.Now.Month - 1; 
            }
            else if (kryptonComboBox1.Text == "Theo năm")
            {
                int currentYear = DateTime.Now.Year;
                for (int i = currentYear; i >= currentYear - 4; i--) kryptonComboBox2.Items.Add(i.ToString());
                kryptonComboBox2.SelectedIndex = 0; 
            }
        }

        private void kryptonComboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadRevenueData();
        }

        private void cbbChuKi_SelectedIndexChanged(object sender, EventArgs e) { }
        private void kryptonPanel1_Paint(object sender, PaintEventArgs e) { }
    }
}
