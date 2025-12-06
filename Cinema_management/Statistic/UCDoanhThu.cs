using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using Cinema_management.DAL;
using System.Globalization;

namespace Cinema_management
{
    public partial class UCDoanhThu : UserControl
    {
        private Database db = new Database();
        private CultureInfo culture = CultureInfo.GetCultureInfo("vi-VN"); // Định dạng tiền Việt (dấu chấm)

        public UCDoanhThu()
        {
            InitializeComponent();
            this.kryptonComboBox2.SelectedIndexChanged += new System.EventHandler(this.kryptonComboBox2_SelectedIndexChanged);
            kryptonComboBox1.SelectedIndex = 0; 
        }

        private void UpdateSummaryPanel(DataTable dt, string time)
        {
            decimal totalRevenue = 0;
            if (dt != null && dt.Rows.Count > 0)
            {
                foreach (DataRow row in dt.Rows)
                {
                    if (row[1] != DBNull.Value)
                        totalRevenue += Convert.ToDecimal(row[1]);
                }
            }
            
            // Format tiền cho bảng tổng kết
            kryptonLabel14.Text = totalRevenue.ToString("N0", culture) + " VNĐ";
            kryptonLabel8.Text = (dt != null ? dt.Rows.Count : 0).ToString();
            
            kryptonLabel4.Text = kryptonComboBox1.Text; 
            kryptonLabel6.Text = time; 
        }

        private void UpdateChartData(DataTable dt, string titleStr, Color barColor, string xAxisTitle)
        {
            if (chartRevenue.Titles.Count > 0)
            {
                chartRevenue.Titles[0].Text = titleStr;
                chartRevenue.Titles[0].ForeColor = barColor;
            }
            kryptonLabel2.StateCommon.ShortText.Color1 = barColor;

            // Xóa dữ liệu cũ
            chartRevenue.Series["Doanh Thu"].Points.Clear();
            chartRevenue.Series["Doanh Thu"].Color = barColor;

            // Cấu hình trục
            chartRevenue.ChartAreas[0].AxisX.Title = xAxisTitle;
            chartRevenue.ChartAreas[0].AxisY.Title = "Doanh thu (VNĐ)";
            // Format trục Y theo dạng số (ví dụ 1,000,000)
            chartRevenue.ChartAreas[0].AxisY.LabelStyle.Format = "#,##0"; 

            if (dt == null || dt.Rows.Count == 0)
            {
                chartRevenue.Titles[0].Text = titleStr + " (Chưa có dữ liệu)";
                return;
            }

            foreach (DataRow row in dt.Rows)
            {
                string label = row[0].ToString(); 
                decimal value = Convert.ToDecimal(row[1]); 
                
                // Thêm điểm và Format số tiền hiển thị trên đầu cột
                int pIndex = chartRevenue.Series["Doanh Thu"].Points.AddXY(label, value);
                chartRevenue.Series["Doanh Thu"].Points[pIndex].Label = value.ToString("N0", culture);
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

                if (type == "Theo tháng")
                {
                    chartColor = Color.FromArgb(194, 45, 64); // Đỏ
                    kryptonLabel14.StateCommon.ShortText.Color1 = chartColor;
                    xAxisTitle = "Ngày";

                    int month = int.Parse(time.Replace("Tháng ", ""));
                    int year = DateTime.Now.Year;

                    query = @"SELECT DAY(NGAYLAP) as Ngay, SUM(TONGTIEN) as DoanhThu 
                              FROM HOADON 
                              WHERE MONTH(NGAYLAP) = @Month AND YEAR(NGAYLAP) = @Year AND DATHANHTOAN = 1
                              GROUP BY DAY(NGAYLAP) 
                              ORDER BY DAY(NGAYLAP)";
                    
                    parameters = new SqlParameter[] {
                        new SqlParameter("@Month", month),
                        new SqlParameter("@Year", year)
                    };

                    DataTable dt = db.ReadData(query, parameters);
                    UpdateChartData(dt, $"DOANH THU THÁNG {month}/{year}", chartColor, xAxisTitle);
                    UpdateSummaryPanel(dt, time); 
                }
                else if (type == "Theo năm")
                {
                    chartColor = Color.FromArgb(6, 174, 244); // Xanh
                    kryptonLabel14.StateCommon.ShortText.Color1 = chartColor;
                    xAxisTitle = "Tháng";

                    int year = int.Parse(time);

                    query = @"SELECT MONTH(NGAYLAP) as Thang, SUM(TONGTIEN) as DoanhThu 
                              FROM HOADON 
                              WHERE YEAR(NGAYLAP) = @Year AND DATHANHTOAN = 1
                              GROUP BY MONTH(NGAYLAP) 
                              ORDER BY MONTH(NGAYLAP)";

                    parameters = new SqlParameter[] { new SqlParameter("@Year", year) };

                    DataTable dt = db.ReadData(query, parameters);
                    UpdateChartData(dt, $"DOANH THU NĂM {year}", chartColor, xAxisTitle);
                    UpdateSummaryPanel(dt, time);
                }
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
