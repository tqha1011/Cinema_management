using Krypton.Toolkit;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;

namespace Cinema_management
{
    public partial class UCTickets : UserControl
    {
        string connectionString = ConfigurationManager.ConnectionStrings["Azure"].ConnectionString;

        private struct SuatChieuInfo
        {
            public string TenPhim;
            public string TenPhong;
            public DateTime ThoiGianChieu;
            public int ThoiLuongPhim; // Đơn vị: phút
            public decimal GiaVe;
        }

        List < KryptonButton> DSGheDangChon = new List<KryptonButton>();
        decimal GiaVe;
        int CountGheDaBan = 0;
        int CountTongGhe = 0;

        Color colorGheTrong = Color.White;
        Color colorGheDangChon = Color.FromArgb(4, 128, 3);
        Color colorGheDaDat = Color.FromArgb(164, 42, 43);
        Color chuGheTrong = Color.Black;
        Color chuGheDangChon = Color.White;
        Color chuGheDaDat = Color.White;

        public UCTickets()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Lấy danh sách tên các ghế đã được bán từ CSDL cho một suất chiếu cụ thể.
        /// </summary>
        /// <param name="maSuatChieu">Mã của suất chiếu</param>
        private List<string> LayDanhSachGheDaDat(int maSuatChieu)
        {
            List<string> dsGheDaBan = new List<string>();

            // Câu query dựa trên ERD của bạn
            // Lấy TENGHE từ bảng GHE, qua bảng VE, lọc theo MASUATCHIEU
            string query = @"SELECT T.TENGHE 
                     FROM GHE AS T
                     INNER JOIN VE ON T.MAGHE = VE.MAGHE
                     WHERE VE.MASUATCHIEU = @MaSuatChieu";

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    // Sử dụng parameter để tránh SQL Injection
                    cmd.Parameters.Add("@MaSuatChieu", SqlDbType.Int).Value = maSuatChieu;

                    try
                    {
                        conn.Open();
                        SqlDataReader reader = cmd.ExecuteReader();
                        while (reader.Read())
                        {
                            // Thêm tên ghế vào danh sách
                            dsGheDaBan.Add(reader["TENGHE"].ToString());
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Lỗi khi tải danh sách ghế đã đặt: " + ex.Message, "Lỗi CSDL", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            return dsGheDaBan;
        }

        /// <summary>
        /// Lấy tất cả thông tin chi tiết của một suất chiếu từ CSDL.
        /// </summary>
        /// <param name="maSuatChieu">Mã của suất chiếu</param>
        /// <returns>Một struct SuatChieuInfo chứa tất cả dữ liệu</returns>
        private SuatChieuInfo LayThongTinSuatChieu(int maSuatChieu)
        {
            SuatChieuInfo info = new SuatChieuInfo();

            // Query này JOIN 4 bảng để lấy tất cả thông tin cần thiết
            string query = @"SELECT 
                        P.TENPHIM, 
                        PC.TENPHONG, 
                        SC.THOIGIANCHIEU, 
                        P.THOILUONGPHIM, 
                        LP.GIAVECOBAN
                     FROM SUATCHIEU AS SC
                     INNER JOIN PHIM AS P ON SC.MAPHIM = P.MAPHIM
                     INNER JOIN PHONGCHIEU AS PC ON SC.MAPHONG = PC.MAPHONG
                     INNER JOIN LOAIPHONG AS LP ON PC.MALOAIPHONG = LP.MALOAIPHONG
                     WHERE SC.MASUATCHIEU = @MaSuatChieu";

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.Add("@MaSuatChieu", SqlDbType.Int).Value = maSuatChieu;

                    try
                    {
                        conn.Open();
                        SqlDataReader reader = cmd.ExecuteReader();
                        if (reader.Read()) // Chỉ mong đợi 1 dòng kết quả
                        {
                            info.TenPhim = reader["TENPHIM"].ToString();
                            info.TenPhong = reader["TENPHONG"].ToString();
                            info.ThoiGianChieu = Convert.ToDateTime(reader["THOIGIANCHIEU"]);
                            info.ThoiLuongPhim = Convert.ToInt32(reader["THOILUONGPHIM"]);
                            info.GiaVe = Convert.ToDecimal(reader["GIAVECOBAN"]);
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Lỗi khi lấy thông tin suất chiếu: " + ex.Message, "Lỗi CSDL", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            return info;
        }

        /// <summary>
        /// Tạo và hiển thị sơ đồ ghế cho một suất chiếu.
        /// </summary>
        /// <param name="maSuatChieu">Mã suất chiếu cần hiển thị</param>
        public void LoadSeats(int maSuatChieu)
        {
            //Xóa các ghế cũ và danh sách đang chọn
            pnlSeats.Controls.Clear();
            DSGheDangChon.Clear();

            //Lấy giá vé từ CSDL
            SuatChieuInfo info = LayThongTinSuatChieu(maSuatChieu);
            this.GiaVe = info.GiaVe;

            // Cập nhật thông tin UI
            DateTime thoiGianBatDau = info.ThoiGianChieu;
            DateTime thoiGianKetThuc = thoiGianBatDau.AddMinutes(info.ThoiLuongPhim);

            lblTGianChieu.Text = $"{thoiGianBatDau:dd/MM/yyyy HH:mm} - {thoiGianKetThuc:dd/MM/yyyy HH:mm}";
            lblMvName.Text = info.TenPhim;
            lblRoom.Text = lblRoomName.Text = info.TenPhong;
            lblShowTime.Text = $"{thoiGianBatDau:HH:mm} - {thoiGianKetThuc:HH:mm}";


            //Lấy danh sách ghế đã bán từ CSDL
            List<string> dsGheDaBan = LayDanhSachGheDaDat(maSuatChieu);

            //Layout sơ đồ ghế
            int Row = 8;
            int Col = 14;
            int btnWidth = 90;
            int btnHeight = 90;
            int spacing = 20;
            int startX = 60;
            int startY = 40;

            // Cập nhật số ghế
            CountTongGhe = Row * Col; // 8 * 14 = 112
            CountGheDaBan = dsGheDaBan.Count;
            CapNhatSoGhe();

            //Tạo các nút ghế
            for (int i=0; i<Row; i++)
            {
                for (int j = 0; j < Col; j++)
                {
                    KryptonButton btnGhe = new KryptonButton();

                    string tenGhe = $"{(char)('A' + i)}{j + 1}";

                    btnGhe.Text = tenGhe;
                    btnGhe.Tag = tenGhe;
                    btnGhe.Size = new Size(btnWidth, btnHeight);
                    btnGhe.Location = new Point(startX + (j * (btnWidth + spacing)),
                                                startY + (i * (btnHeight + spacing)));

                    // Thiết lập_Style chung cho KryptonButton
                    btnGhe.PaletteMode = PaletteMode.ProfessionalSystem;
                    btnGhe.StateCommon.Border.DrawBorders = (PaletteDrawBorders.All);
                    btnGhe.StateCommon.Border.Width = 1;
                    btnGhe.StateCommon.Border.Rounding = 5; // Bo góc nhẹ

                    // Kiểm tra trạng thái ghế
                    if (dsGheDaBan.Contains(tenGhe))
                    {
                        btnGhe.Enabled = false;
                        btnGhe.StateCommon.Back.Color1 = colorGheDaDat;
                        btnGhe.StateCommon.Back.Color2 = colorGheDaDat;
                        btnGhe.StateCommon.Content.ShortText.Color1 = chuGheDaDat;
                        btnGhe.OverrideDefault.Border.Color1 = colorGheDaDat;
                        btnGhe.OverrideDefault.Border.Color2 = colorGheDaDat;
                    }
                    else
                    {
                        btnGhe.Enabled = true;
                        btnGhe.StateCommon.Back.Color1 = colorGheTrong;
                        btnGhe.StateCommon.Back.Color2 = colorGheTrong;
                        btnGhe.StateCommon.Content.ShortText.Color1 = chuGheTrong;
                        btnGhe.StateCommon.Border.Color1 = Color.FromArgb(4, 128, 3);
                        btnGhe.StateCommon.Border.Width = 4;
                        btnGhe.Cursor = Cursors.Hand;

                        // Gán sự kiện click cho ghế trống
                        btnGhe.Click += BtnGhe_Click;
                    }
                    // Thêm ghế vào panel
                    pnlSeats.Controls.Add(btnGhe);
                }
            }
            // Cập nhật UI
            CapNhatThongTinVe();
        }

        /// <summary>
        /// Được gọi khi người dùng click vào một ghế CÒN TRỐNG.
        /// </summary>
        private void BtnGhe_Click(object sender, EventArgs e)
        {
            KryptonButton btnGheDaChon = sender as KryptonButton;
            if (btnGheDaChon == null)
                return;

            // Ghế đang trống --> đang chọn
            if(btnGheDaChon.StateCommon.Back.Color1 == colorGheTrong)
            {
                // Đổi màu
                btnGheDaChon.StateCommon.Back.Color1 = colorGheDangChon;
                btnGheDaChon.StateCommon.Back.Color2 = colorGheDangChon;
                btnGheDaChon.StateCommon.Content.ShortText.Color1 = chuGheDangChon;
                btnGheDaChon.OverrideDefault.Back.Color1 = colorGheDangChon;
                btnGheDaChon.OverrideDefault.Back.Color2 = colorGheDangChon;
                // Thêm vào danh sách ghế đang chọn
                DSGheDangChon.Add(btnGheDaChon);
            }
            // Ghế đang chọn --> trở về trống
            else if(btnGheDaChon.StateCommon.Back.Color1 == colorGheDangChon)
            {
                // Đổi màu
                btnGheDaChon.StateCommon.Back.Color1 = colorGheTrong;
                btnGheDaChon.StateCommon.Back.Color2 = colorGheTrong;
                btnGheDaChon.StateCommon.Content.ShortText.Color1 = chuGheTrong;
                btnGheDaChon.OverrideDefault.Back.Color1 = colorGheTrong;
                btnGheDaChon.OverrideDefault.Back.Color2 = colorGheTrong;
                // Xóa khỏi danh sách ghế đang chọn
                DSGheDangChon.Remove(btnGheDaChon);
            }
          

                CapNhatThongTinVe();
        }

        /// <summary>
        /// Cập nhật các Label hiển thị ghế đã chọn và tổng tiền.
        /// </summary>
        private void CapNhatThongTinVe()
        {
            //decimal giaVe = 45000;

            var tenCacGhe = DSGheDangChon.Select(btn => btn.Tag.ToString())
                                            .OrderBy(ten => ten.Length)
                                            .ThenBy(ten => ten);

            lblGheChon.Text = string.Join(",", tenCacGhe);

            if (DSGheDangChon.Count > 0)
            {
                lblGiaVe.Text = GiaVe.ToString("N0") + " VND";
            }
            else
            {
                // Nếu không có ghế nào được chọn, hiển thị là 0
                lblGiaVe.Text = "0 VND";
            }

            decimal Sum = DSGheDangChon.Count * GiaVe;
            lblTongTien.Text = Sum.ToString("N0") + " VND";
        }

        private void CapNhatSoGhe()
        {
            int countGheTrong = this.CountTongGhe - this.CountGheDaBan;
            lblSeatsCount.Text = $"Số ghế ({countGheTrong}/{CountTongGhe})";
        }

        private void kryptonLabel6_Click(object sender, EventArgs e)
        {

        }
    }
}
