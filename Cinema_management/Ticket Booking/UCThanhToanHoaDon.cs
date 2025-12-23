using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Cinema_management.MessageboxCustom.Utils;
using Cinema_management.Services;

namespace Cinema_management.Ticket_Booking
{
    public partial class UCThanhToanHoaDon : UserControl
    {
        private BookingInfo bookingInfo;
        public event EventHandler OnPayMentSuccess; //báo về form main
        public event EventHandler OnBack;

        public UCThanhToanHoaDon()
        {
            InitializeComponent();
        }

        public void SetBookingData(BookingInfo info)
        {
            bookingInfo = info;
            LoadData();
        }
        // Tăng hiệu ứng mượt khi load dữ liệu
        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams cp = base.CreateParams;
                cp.ExStyle |= 0x02000000;  // WS_EX_COMPOSITED
                return cp;
            }
        }

        private void LoadData()
        {
            //thông tin phim
            lblTenPhim.Text = bookingInfo.TenPhim;
            lblNgay.Text = bookingInfo.ThoiGianChieu.ToString("dd/MM/yyyy");
            lblGio.Text = bookingInfo.ThoiGianChieu.ToString("HH:mm");
            lblPhong.Text = bookingInfo.TenPhong;
            lblGhe.Text = string.Join(", ", bookingInfo.DanhSachGhe);
            lblGiaVe.Text = bookingInfo.GiaVe.ToString("N0") + " đ";
            lblTongTienVe.Text = bookingInfo.TongTienVe.ToString("N0") + " đ";

            //thông tin đồ ăn
            flowPanelFoodList.Controls.Clear();
            foreach (var item in bookingInfo.DanhSachDoAn)
            {
                int maDoan = item.Key;
                int sl = item.Value;
                string ten = bookingInfo.TenDoan.ContainsKey(maDoan) ? bookingInfo.TenDoan[maDoan] : "Unknown";
                decimal gia = bookingInfo.GiaDoAn.ContainsKey(maDoan) ? bookingInfo.GiaDoAn[maDoan] : 0;

                UCHoaDonFood card = new UCHoaDonFood();
                card.SetData(ten, sl, gia);
                flowPanelFoodList.Controls.Add(card);
            }

            lblTongTienDoan.Text = bookingInfo.TongTienDoAn.ToString("N0") + " đ";
            lblTong.Text = bookingInfo.TongTien.ToString("N0") + " đ";

        }

        private void btnThanhToan_Click(object sender, EventArgs e)
        {
            // gọi Service Transaction
            TicketService service = new TicketService();
            if (service.LuuGiaoDich(bookingInfo))
            {
                Alert.Show("Thanh toán thành công!", MessagboxCustom.AlertMessagebox.AlertType.Success);
                OnPayMentSuccess?.Invoke(this, EventArgs.Empty);
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            OnBack?.Invoke(this, EventArgs.Empty);
        }
    }
}
