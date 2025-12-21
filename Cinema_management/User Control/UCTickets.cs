using Cinema_management.MessageboxCustom.Utils;
using Cinema_management.Ticket_Booking;
using Krypton.Toolkit;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cinema_management
{
    public partial class UCTickets : UserControl
    {
        public event EventHandler OnBack;
        public event Action<BookingInfo> OnContinueToFood;

        public int maSuatChieu;
        private DateTime _thoiGianChieu;
        private string _posterFolderPath = Path.GetFullPath(Path.Combine(Application.StartupPath, @"..\..\Posters"));

        string connectionString = ConfigurationManager.ConnectionStrings["Azure"].ConnectionString;

        private struct SuatChieuInfo
        {
            public string TenPhim;
            public string AnhPhim;
            public string TenPhong;
            public DateTime ThoiGianChieu;
            public int ThoiLuongPhim; //phút
            public decimal GiaVe;
        }

        List < KryptonButton> DSGheDangChon = new List<KryptonButton>();
        // List backup để add vào panel 
        private List<Control> _tempSeatControls = new List<Control>();

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
            SetDoubleBuffered(flowPanelSeats);
        }

        public static void SetDoubleBuffered(Control control)
        {
            typeof(Control).InvokeMember("DoubleBuffered",
                BindingFlags.SetProperty | BindingFlags.Instance | BindingFlags.NonPublic,
                null, control, new object[] { true });
        }

        public void LoadSeats(int maSuatChieu)
        {
            this.maSuatChieu = maSuatChieu;
            LoadSeatsAsync();
        }

        public async void LoadSeatsAsync()
        {
            try
            {
                // Chay query dưới background thread
                var data = await Task.Run(() =>
                {
                    var tempInfo = LayThongTinSuatChieu(this.maSuatChieu);
                    var bookedSeats = LayDanhSachGheDaDat(this.maSuatChieu);
                    return new { Info = tempInfo, BookedSeats = bookedSeats };
                });

                // Cập nhật du liệu
                SuatChieuInfo info = data.Info;
                List<string> dsGheDaBan = data.BookedSeats;

                this.GiaVe = info.GiaVe;
                this._thoiGianChieu = info.ThoiGianChieu;

                UpdateLabels(info);
                RenderSeatMap(dsGheDaBan);
            }
            catch (Exception ex)
            {
                Alert.Show("Lỗi tải sơ đồ ghế: " + ex.Message, MessagboxCustom.AlertMessagebox.AlertType.Error);
            }
        }

        private void UpdateLabels(SuatChieuInfo info)
        {
            DateTime thoiGianBatDau = info.ThoiGianChieu;
            DateTime thoiGianKetThuc = thoiGianBatDau.AddMinutes(info.ThoiLuongPhim);

            lblTGianChieu.Text = $"{thoiGianBatDau: dd/MM/yyyy HH:mm} - {thoiGianKetThuc: dd/MM/yyyy HH:mm}";
            lblMvName.Text = info.TenPhim;
            lblRoom.Text = lblRoomName.Text = info.TenPhong;
            lblShowTime.Text = $"{thoiGianBatDau: HH:mm} - {thoiGianKetThuc: HH:mm}";
            // Load poster
            if (!string.IsNullOrEmpty(info.AnhPhim))
            {
                string fullPath = Path.Combine(_posterFolderPath, info.AnhPhim);

                if (File.Exists(fullPath))
                {
                    // Dispose ảnh cũ nếu có để tránh leak memory
                    if (picMovie.Image != null) picMovie.Image.Dispose();

                    picMovie.Image = Image.FromFile(fullPath);
                    picMovie.SizeMode = PictureBoxSizeMode.Zoom; 
                }
                else
                {
                    picMovie.Image = null; 
                }
            }
            else
            {
                picMovie.Image = null;
            }
        }

        public void RenderSeatMap(List<string> dsGheDaBan)
        {
            flowPanelSeats.Visible = false;
            flowPanelSeats.SuspendLayout();

            foreach (Control c in flowPanelSeats.Controls)
                c.Dispose();
            flowPanelSeats.Controls.Clear();
            _tempSeatControls.Clear();

            int Row = 8;
            int Col = 14;
            //int btnSize = 100;
            int spacing = 20;

            ///// layout
            int panelWidth = flowPanelSeats.ClientSize.Width - 100 - 100; // chiều rộng thực tế của panel
            int totalSpacingW = (Col + 1) * spacing; // Tổng khoảng trắng
            int dynamicSize = (panelWidth - totalSpacingW) / Col;
            // Giới hạn max size 
            if (dynamicSize > 200) dynamicSize = 200;
            // Giới hạn min size 
            if (dynamicSize < 40) dynamicSize = 40;
            int btnSize = dynamicSize;

            CountTongGhe = Row * Col;
            CountGheDaBan = dsGheDaBan.Count;
            CapNhatSoGhe();

            for (int i = 0; i < Row; i++)
            {
                for (int j = 0; j < Col; j++)
                {
                    KryptonButton btnGhe = new KryptonButton();
                    string tenGhe = $"{(char)('A' + i)}{j + 1}";

                    btnGhe.Text = tenGhe;
                    btnGhe.Tag = tenGhe;

                    btnGhe.Size = new Size(btnSize, btnSize);
                    btnGhe.Margin = new Padding(spacing/2);

                    //Style
                    btnGhe.PaletteMode = PaletteMode.ProfessionalSystem;
                    btnGhe.StateCommon.Border.DrawBorders = (PaletteDrawBorders.All);
                    btnGhe.StateCommon.Border.Rounding = 12;
                    btnGhe.StateCommon.Border.Width = 5;
                    btnGhe.StateCommon.Content.ShortText.Font = new Font("Nunito", 10, FontStyle.Bold);

                    //logic mau
                    if (dsGheDaBan.Contains(tenGhe))
                    {
                        btnGhe.Enabled = false;
                        SetButtonStyle(btnGhe, colorGheDaDat, chuGheDaDat);
                        btnGhe.StateCommon.Border.Color1 = colorGheDaDat;
                        btnGhe.StateCommon.Border.Color2 = colorGheDaDat;
                    }
                    else
                    {
                        btnGhe.Enabled = true;
                        SetButtonStyle(btnGhe, colorGheTrong, chuGheTrong);
                        btnGhe.StateCommon.Border.Color1 = Color.FromArgb(4, 128, 3);
                        btnGhe.StateCommon.Border.Width = 4;
                        btnGhe.Cursor = Cursors.Hand;
                        // Gán sự kiện click cho ghế trống
                        btnGhe.Click += BtnGhe_Click;
                    }
                    _tempSeatControls.Add(btnGhe);
                }

                if (_tempSeatControls.Count > 0)
                {
                    flowPanelSeats.SetFlowBreak(_tempSeatControls.Last(), true);
                }
            }

            flowPanelSeats.Controls.AddRange(_tempSeatControls.ToArray());

            flowPanelSeats.ResumeLayout();
            flowPanelSeats.Visible = true;

            // cập nhật UI
            CapNhatThongTinVe();
        }

        // hàm set màu ghế
        public void SetButtonStyle(KryptonButton btn, Color backColor, Color textColor)
        {
            btn.StateCommon.Back.Color1 = backColor;
            btn.StateCommon.Back.Color2 = backColor;
            btn.StateCommon.Content.ShortText.Color1 = textColor;
            btn.OverrideDefault.Back.Color1 = backColor;
            btn.OverrideDefault.Back.Color2 = backColor;
        }

                //Lấy danh sách tên các ghế đã được bán từ CSDL cho một suất chiếu cụ thể.
        /// <param name="maSuatChieu">Mã của suất chiếu</param>
        private List<string> LayDanhSachGheDaDat(int maSuatChieu)
        {
            List<string> dsGheDaBan = new List<string>();

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

        /// Lấy tất cả thông tin chi tiết của một suất chiếu từ CSDL.
        /// <returns>Một struct SuatChieuInfo chứa tất cả dữ liệu</returns>
        private SuatChieuInfo LayThongTinSuatChieu(int maSuatChieu)
        {
            SuatChieuInfo info = new SuatChieuInfo();

            // Query JOIN 4 bảng để lấy tất cả thông tin cần thiết
            string query = @"SELECT 
                        P.TENPHIM, 
                        P.ANHPHIM,
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
                            info.AnhPhim = reader["ANHPHIM"] != DBNull.Value ? reader["ANHPHIM"].ToString() : "";
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

        //// Được gọi khi người dùng click vào một ghế CÒN TRỐNG.
        private void BtnGhe_Click(object sender, EventArgs e)
        {
            KryptonButton btnGheDaChon = sender as KryptonButton;
            if (btnGheDaChon == null)
                return;

            // Ghế đang trống --> đang chọn
            if(btnGheDaChon.StateCommon.Back.Color1 == colorGheTrong)
            {
                // Đổi màu
                SetButtonStyle(btnGheDaChon, colorGheDangChon, chuGheDangChon);
                // Thêm vào danh sách ghế đang chọn
                DSGheDangChon.Add(btnGheDaChon);
            }
            // Ghế đang chọn --> trở về trống
            else if(btnGheDaChon.StateCommon.Back.Color1 == colorGheDangChon)
            {
                // Đổi màu
               SetButtonStyle(btnGheDaChon, colorGheTrong, chuGheTrong);
                // Xóa khỏi danh sách ghế đang chọn
                DSGheDangChon.Remove(btnGheDaChon);
            }
          
                CapNhatThongTinVe();
        }

        //// Cập nhật các Label hiển thị ghế đã chọn và tổng tiền.
        private void CapNhatThongTinVe()
        {
            var tenCacGhe = DSGheDangChon.Select(btn => btn.Tag.ToString())
                                            .OrderBy(ten => ten.Length)
                                            .ThenBy(ten => ten);

            lblGheChon.Text = string.Join(",", tenCacGhe);

            if (DSGheDangChon.Count > 0)
            {
                lblGiaVe.Text = GiaVe.ToString("N0") + " đ";
            }
            else
            {
                // Nếu không có ghế nào được chọn, hiển thị là 0
                lblGiaVe.Text = "0 VND";
            }

            decimal Sum = DSGheDangChon.Count * GiaVe;
            lblTongTien.Text = Sum.ToString("N0") + " đ";
        }

        private void CapNhatSoGhe()
        {
            int countGheTrong = this.CountTongGhe - this.CountGheDaBan;
            lblSeatsCount.Text = $"Số ghế ({countGheTrong}/{CountTongGhe})";
        }

        private void btnContinue_Click(object sender, EventArgs e)
        {
            // Kiểm tra xem có_ghế nào được chọn không
            if (DSGheDangChon.Count == 0)
            {
                Alert.Show("Vui lòng chọn ít nhất một ghế để tiếp tục.", MessagboxCustom.AlertMessagebox.AlertType.Error);
                return;
            }

            // Cập nhật lại_số_ghế đã bán 
            this.CountGheDaBan += DSGheDangChon.Count;
            CapNhatSoGhe(); // Cập nhật label đếm số ghế

            //// TẠO GIỎ HÀNG
            BookingInfo curBooking = new BookingInfo();
            curBooking.TenPhim = lblMvName.Text;
            curBooking.TenPhong = lblRoomName.Text;
            curBooking.ThoiGianChieu = this._thoiGianChieu;
            curBooking.MaSuatChieu = this.maSuatChieu;
            curBooking.GiaVe = this.GiaVe;
            curBooking.MaNhanVien = 1; //////////////////// ID NV đang đăng nhập

            foreach(var btn in DSGheDangChon)
            {
                curBooking.DanhSachGhe.Add(btn.Tag.ToString());
            }

            ////// Hiện form đồ ăn /////
            OnContinueToFood?.Invoke(curBooking);
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            OnBack?.Invoke(this, EventArgs.Empty);
        }

        private void flowPanelSeats_Paint(object sender, PaintEventArgs e)
        {
                        
        }
    }
}
