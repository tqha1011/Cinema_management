using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using Cinema_management.DAL;
using System.Data.SqlClient;
using System.Globalization;
using Krypton.Toolkit;
using System.Windows.Forms.DataVisualization.Charting;

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
