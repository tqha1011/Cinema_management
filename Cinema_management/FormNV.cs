using Cinema_management.MessageboxCustom.Utils;
using Cinema_management.Personal_Info;
using Cinema_management.Ticket_Booking;
using Krypton.Toolkit;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cinema_management
{
    public partial class FormNV : KryptonForm
    {
        public FormNV()
        {
            InitializeComponent();
            btnBanVe_Click(this, EventArgs.Empty);
            kryptonDropButton1.Text = Session.currHoTen;
        }

        private void FormNV_Load(object sender, EventArgs e)
        {
        }

        private void btnTTCN_Click(object sender, EventArgs e)
        {
            pnforUC.Controls.Clear();
            UCThongTinCaNhan uc = new UCThongTinCaNhan();
            uc.Dock = DockStyle.Fill;
            pnforUC.Controls.Add(uc);
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            DialogResult result = Alert.ShowWarning("Bạn có muốn đăng xuất?");
            if (result == DialogResult.OK)
            {
                this.DialogResult = DialogResult.OK;
                this.Close();

            }
        }

        private void btnBanVe_Click(object sender, EventArgs e)
        {
            pnforUC.Controls.Clear();
            UCPhimDangChieu uc = new UCPhimDangChieu();
            uc.Dock = DockStyle.Fill;
            pnforUC.Controls.Add(uc);

            uc.OnSuatChieuSelected += ChuyenSangScreenChonGhe;
        }

        private void ChuyenSangScreenChonGhe(int maSuatChieu)
        {
            pnforUC.Controls.Clear();

            // Khởi tạo UC Chọn Ghế
            UCTickets ucGhe = new UCTickets();
            ucGhe.Dock = DockStyle.Fill;

            // Gọi hàm LoadSeats,truyền mã suất chiếu vào
            ucGhe.LoadSeats(maSuatChieu);

            // Đăng ký sự kiện Back
            // Khi nút Back được nhấn, ta gọi lại hàm load danh sách phim
            // Hàm này chính là hàm sự kiện click của nút "Phim đang chiếu"
            ucGhe.OnBack += (s, ev) => btnBanVe_Click(null, null);

            // Khi UCTickets báo ra sự kiện OnContinueToFood -> gọi ChuyenSangManHnhFod
            ucGhe.OnContinueToFood += ChuyenSangManHinhFood;

            pnforUC.Controls.Add(ucGhe);
        }

        private void ChuyenSangManHinhFood(BookingInfo curBooking)
        {
            pnforUC.Controls.Clear();

            //Khởi tạo UC chọn đồ ăn
            UCChonDoAn ucFood = new UCChonDoAn();
            ucFood.Dock = DockStyle.Fill;

            //truyền dữ liệu giỏ hàng vào
            ucFood.SetBookingData(curBooking);

            //nút back
            ucFood.OnBack += (s, e) => ChuyenSangScreenChonGhe(curBooking.MaSuatChieu);

            ucFood.OnContinueToCheckout += ChuyenSangManHinhCheckOut;

            pnforUC.Controls.Add(ucFood);
        }

        private void ChuyenSangManHinhCheckOut(BookingInfo curBooking)
        {
            pnforUC.Controls.Clear();

            //khởi tạo UC Thanh Toán
            UCThanhToanHoaDon ucCheckout = new UCThanhToanHoaDon();
            ucCheckout.Dock = DockStyle.Fill;

            ucCheckout.SetBookingData(curBooking);

            // nút back
            ucCheckout.OnBack += (s, e) => ChuyenSangManHinhFood(curBooking);

            //Khi thanh toán thành công -> quay về màn hình danh sách phim ban đầu
            ucCheckout.OnPayMentSuccess += (s, e) => btnBanVe_Click(null, null);

            pnforUC.Controls.Add(ucCheckout);
        }
    }
}
