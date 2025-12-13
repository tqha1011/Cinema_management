using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using Cinema_management.DAL;
using System.Data.SqlClient;
using System.Globalization;
using Krypton.Toolkit;
using System.Windows.Forms.DataVisualization.Charting;
using Cinema_management.DAL;

namespace Cinema_management
{
    public partial class UCTongQuan : UserControl
    {
        private Database db = new Database();

        public UCTongQuan()
        {
            InitializeComponent();
            this.Load += UCTongQuan_Load;
        }

        private void UCTongQuan_Load(object sender, EventArgs e)
        {
            LoadRevenueComparison();
            LoadBestStaff();
            LoadTop5MoviesChart();
        }
        private void LoadTop5MoviesChart()
        {
            // 1. Câu lệnh SQL lấy Top 5 phim bán được nhiều vé nhất
            // Logic: Đếm số lượng vé trong bảng VE, Group theo Tên Phim, Sắp xếp giảm dần
            string query = @"
                SELECT TOP 5 p.TENPHIM, COUNT(v.MAVE) as SoVe
                FROM VE v
                JOIN SUATCHIEU s ON v.MASUATCHIEU = s.MASUATCHIEU
                JOIN PHIM p ON s.MAPHIM = p.MAPHIM
                GROUP BY p.TENPHIM
                ORDER BY COUNT(v.MAVE) DESC";

            try
            {
                DataTable dt = db.ReadData(query);

                // 2. Xóa dữ liệu mẫu mặc định của Chart (nếu có)
                chartTopMovies.Series[0].Points.Clear();

                // 3. Đổ dữ liệu từ DataTable vào Chart
                if (dt != null && dt.Rows.Count > 0)
                {
                    // Đặt tên cho Series (nếu chưa đặt trong Properties)
                    chartTopMovies.Series[0].Name = "Phim";
                    chartTopMovies.Series[0]["PieLabelStyle"] = "Disabled";
                    // Duyệt từng dòng dữ liệu
                    foreach (DataRow row in dt.Rows)
                    {
                        string tenPhim = row["TENPHIM"].ToString();
                        int soVe = Convert.ToInt32(row["SoVe"]);

                        // Thêm điểm vào biểu đồ
                        DataPoint point = new DataPoint();
                        point.SetValueXY(tenPhim, soVe);
                        point.Label = "";

                        chartTopMovies.Series[0].Points.Add(point);
                    }
                }
            }
            catch (Exception ex)
            {
                // MessageBox.Show("Lỗi tải biểu đồ: " + ex.Message);
            }
        }
        //So sánh doanh thu tháng này với tháng trước
        private void LoadRevenueComparison()
        {
            try
            {
                string qCurr = "SELECT SUM(TONGTIEN) FROM HOADON WHERE MONTH(NGAYLAP) = MONTH(GETDATE()) AND YEAR(NGAYLAP) = YEAR(GETDATE()) AND DATHANHTOAN=1";
                DataTable dtCurr = db.ReadData(qCurr);
                decimal curr = (dtCurr != null && dtCurr.Rows.Count > 0 && dtCurr.Rows[0][0] != DBNull.Value) ? Convert.ToDecimal(dtCurr.Rows[0][0]) : 0;

                string qPrev = "SELECT SUM(TONGTIEN) FROM HOADON WHERE MONTH(NGAYLAP) = MONTH(DATEADD(m, -1, GETDATE())) AND YEAR(NGAYLAP) = YEAR(DATEADD(m, -1, GETDATE())) AND DATHANHTOAN=1";
                DataTable dtPrev = db.ReadData(qPrev);
                decimal prev = (dtPrev != null && dtPrev.Rows.Count > 0 && dtPrev.Rows[0][0] != DBNull.Value) ? Convert.ToDecimal(dtPrev.Rows[0][0]) : 0;

                decimal diff = curr - prev;
                string sign = diff >= 0 ? "+" : "";
                kryptonLabel1.Text = $"{sign}{diff.ToString("N0", CultureInfo.GetCultureInfo("vi-VN"))} VNĐ";
                kryptonLabel1.StateCommon.ShortText.Color1 = diff >= 0 ? Color.White : Color.Yellow;
            }
            catch { }
        }

        //Nhân viên bán được nhiều vé
        private void LoadBestStaff()
        {
            try
            {
                string query = @"SELECT TOP 1 NV.HOTEN 
                                 FROM HOADON HD 
                                 JOIN NHANVIEN NV ON HD.MANV = NV.MANV 
                                 WHERE MONTH(HD.NGAYLAP) = MONTH(GETDATE()) AND HD.DATHANHTOAN = 1
                                 GROUP BY NV.HOTEN 
                                 ORDER BY SUM(HD.TONGTIEN) DESC";
                DataTable dt = db.ReadData(query);
                if (dt != null && dt.Rows.Count > 0)
                    kryptonLabel2.Text = dt.Rows[0]["HOTEN"].ToString();
                else
                    kryptonLabel2.Text = "Chưa có";
            }
            catch { }
        }





        private void kryptonPanel3_Paint(object sender, PaintEventArgs e) { }
    }
}
