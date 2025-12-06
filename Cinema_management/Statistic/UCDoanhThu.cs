using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using Cinema_management.DAL;
<<<<<<< HEAD
using System.Globalization;
=======
using System.Globalization; // Thêm thư viện để định dạng tiền tệ
>>>>>>> ef86b2b184851bc7cd7cab80148935f70ce50cff

namespace Cinema_management
{
    public partial class UCDoanhThu : UserControl
    {
        private Database db = new Database();

        public UCDoanhThu()
        {
            InitializeComponent();
<<<<<<< HEAD
=======

>>>>>>> ef86b2b184851bc7cd7cab80148935f70ce50cff
            this.kryptonComboBox2.SelectedIndexChanged += new System.EventHandler(this.kryptonComboBox2_SelectedIndexChanged);
            kryptonComboBox1.SelectedIndex = 0;
        }

<<<<<<< HEAD
        // --- HÀM MỚI: Đếm tổng số hóa đơn chính xác ---
        private int GetTotalInvoices(int month, int year, bool isYearly)
        {
            try
            {
                string query;
                SqlParameter[] parameters;

                if (isYearly)
                {
                    query = "SELECT COUNT(*) FROM HOADON WHERE YEAR(NGAYLAP) = @Year AND DATHANHTOAN = 1";
                    parameters = new SqlParameter[] { new SqlParameter("@Year", year) };
                }
                else
                {
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
            catch { }
            return 0;
        }

        private void UpdateSummaryPanel(DataTable dt, string time, int totalInvoices)
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

            kryptonLabel14.Text = totalRevenue.ToString("N0", CultureInfo.GetCultureInfo("vi-VN")) + " VNĐ";

            // --- SỬA: Sử dụng biến totalInvoices chính xác ---
            kryptonLabel8.Text = totalInvoices.ToString();

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

            // --- SỬA: Không đổi màu label tiêu đề và số tiền nữa (Giữ nguyên màu đỏ trong Designer) ---

            chartRevenue.Series["Doanh Thu"].Points.Clear();
            chartRevenue.Series["Doanh Thu"].Color = barColor;

            chartRevenue.ChartAreas[0].AxisX.Title = xAxisTitle;
            chartRevenue.ChartAreas[0].AxisY.Title = "Doanh thu (VNĐ)";
            chartRevenue.ChartAreas[0].AxisY.LabelStyle.Format = "#,##0";

=======
        // --- HÀM 1: CẬP NHẬT SỐ LIỆU BÊN PHẢI ---
        private void UpdateSummaryPanel(DataTable dt)
        {
            decimal totalRevenue = 0;
            int totalInvoices = 0;

            if (dt != null && dt.Rows.Count > 0)
            {
                // Duyệt qua từng dòng để cộng dồn
                foreach (DataRow row in dt.Rows)
                {
                    // Cột 1 là Doanh thu (TONGTIEN)
                    if (row[1] != DBNull.Value)
                    {
                        totalRevenue += Convert.ToDecimal(row[1]);
                    }

                    // Cột 2 là Số hóa đơn (đếm COUNT(MAHOADON) trong SQL nếu có, 
                    // nhưng ở đây ta đếm số ngày có doanh thu, hoặc ta cần sửa query một chút để lấy tổng số hóa đơn)
                }

                // Ở đây tôi dùng tạm số dòng để hiển thị số ngày có doanh thu.
                // Nếu muốn chính xác số hóa đơn, ta cần query riêng. 
                // Nhưng để đơn giản, ta sẽ hiển thị Tổng tiền trước.
            }

            // Hiển thị lên Label (Đảm bảo tên Label khớp với Designer của bạn)
            // kryptonLabel14 là label hiển thị tổng tiền
            kryptonLabel14.Text = totalRevenue.ToString("N0", CultureInfo.GetCultureInfo("vi-VN")) + " VNĐ";

            // kryptonLabel8 là label hiển thị số liệu phụ (ví dụ: Số ngày hoạt động)
            kryptonLabel8.Text = (dt != null ? dt.Rows.Count : 0).ToString() + " ngày/tháng";
        }

        // --- HÀM 2: VẼ BIỂU ĐỒ ---
        private void UpdateChartData(DataTable dt, string titleStr, Color barColor)
        {
            if (chartRevenue.Titles.Count > 0)
            {
                chartRevenue.Titles[0].Text = titleStr;
                chartRevenue.Titles[0].ForeColor = barColor;
            }

            chartRevenue.Series["Doanh Thu"].Points.Clear();
            chartRevenue.Series["Doanh Thu"].Color = barColor;

>>>>>>> ef86b2b184851bc7cd7cab80148935f70ce50cff
            if (dt == null || dt.Rows.Count == 0)
            {
                chartRevenue.Titles[0].Text = titleStr + " (Chưa có dữ liệu)";
                return;
            }

            foreach (DataRow row in dt.Rows)
            {
                string label = row[0].ToString();
                decimal value = Convert.ToDecimal(row[1]);
                chartRevenue.Series["Doanh Thu"].Points.AddXY(label, value);
            }
<<<<<<< HEAD
            chartRevenue.Titles[0].Font = new Font("Microsoft Sans Serif", 14, FontStyle.Bold);
        }

=======
        }

        // --- HÀM 3: TẢI DỮ LIỆU ---
>>>>>>> ef86b2b184851bc7cd7cab80148935f70ce50cff
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
<<<<<<< HEAD
                string xAxisTitle = "";
                int totalInvoices = 0; // Biến lưu tổng số hóa đơn
=======
>>>>>>> ef86b2b184851bc7cd7cab80148935f70ce50cff

                if (type == "Theo tháng")
                {
                    chartColor = Color.FromArgb(194, 45, 64); // Đỏ
<<<<<<< HEAD
                    xAxisTitle = "Ngày";
=======
>>>>>>> ef86b2b184851bc7cd7cab80148935f70ce50cff

                    int month = int.Parse(time.Replace("Tháng ", ""));
                    int year = DateTime.Now.Year;

<<<<<<< HEAD
                    // 1. Lấy dữ liệu biểu đồ
=======
                    // Query lấy Ngày và Tổng tiền
>>>>>>> ef86b2b184851bc7cd7cab80148935f70ce50cff
                    query = @"SELECT DAY(NGAYLAP) as Ngay, SUM(TONGTIEN) as DoanhThu 
                              FROM HOADON 
                              WHERE MONTH(NGAYLAP) = @Month AND YEAR(NGAYLAP) = @Year AND DATHANHTOAN = 1
                              GROUP BY DAY(NGAYLAP) 
                              ORDER BY DAY(NGAYLAP)";

                    parameters = new SqlParameter[] {
                        new SqlParameter("@Month", month),
                        new SqlParameter("@Year", year)
                    };

<<<<<<< HEAD
                    // 2. Lấy tổng số hóa đơn (gọi hàm mới)
                    totalInvoices = GetTotalInvoices(month, year, false);

                    DataTable dt = db.ReadData(query, parameters);
                    UpdateChartData(dt, $"DOANH THU THÁNG {month}/{year}", chartColor, xAxisTitle);
                    UpdateSummaryPanel(dt, time, totalInvoices);
=======
                    DataTable dt = db.ReadData(query, parameters);

                    // Cập nhật cả Biểu đồ VÀ Bảng bên phải
                    UpdateChartData(dt, $"DOANH THU THÁNG {month}/{year}", chartColor);
                    UpdateSummaryPanel(dt);
>>>>>>> ef86b2b184851bc7cd7cab80148935f70ce50cff
                }
                else if (type == "Theo năm")
                {
                    chartColor = Color.FromArgb(6, 174, 244); // Xanh
<<<<<<< HEAD
                    xAxisTitle = "Tháng";

                    int year = int.Parse(time);

                    // 1. Lấy dữ liệu biểu đồ
=======

                    int year = int.Parse(time);

>>>>>>> ef86b2b184851bc7cd7cab80148935f70ce50cff
                    query = @"SELECT MONTH(NGAYLAP) as Thang, SUM(TONGTIEN) as DoanhThu 
                              FROM HOADON 
                              WHERE YEAR(NGAYLAP) = @Year AND DATHANHTOAN = 1
                              GROUP BY MONTH(NGAYLAP) 
                              ORDER BY MONTH(NGAYLAP)";

                    parameters = new SqlParameter[] { new SqlParameter("@Year", year) };

<<<<<<< HEAD
                    // 2. Lấy tổng số hóa đơn (gọi hàm mới - tham số isYearly = true)
                    totalInvoices = GetTotalInvoices(0, year, true);

                    DataTable dt = db.ReadData(query, parameters);
                    UpdateChartData(dt, $"DOANH THU NĂM {year}", chartColor, xAxisTitle);
                    UpdateSummaryPanel(dt, time, totalInvoices);
=======
                    DataTable dt = db.ReadData(query, parameters);

                    // Cập nhật cả Biểu đồ VÀ Bảng bên phải
                    UpdateChartData(dt, $"DOANH THU NĂM {year}", chartColor);
                    UpdateSummaryPanel(dt);
>>>>>>> ef86b2b184851bc7cd7cab80148935f70ce50cff
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
