using Cinema_management.Ticket_Booking;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cinema_management
{
    public partial class UCChonDoAn : UserControl
    {
        public event Action<BookingInfo> OnContinueToCheckout; //sự kiện chuyển tiếp
        public event EventHandler OnBack; //sự kiện quay lại

        private BookingInfo bookingInfo;
        string connectionString = ConfigurationManager.ConnectionStrings["Azure"].ConnectionString;

        // list lưu tất cả đồ ăn để lọc ko cần query lại DB
        private List<UCOrderFoodCard> _allFoodCards = new List<UCOrderFoodCard>();


        public UCChonDoAn()
        {
            InitializeComponent();
            flowPanelCart.Controls.Clear();
        }

        public void SetBookingData(BookingInfo info)
        {
            this.bookingInfo = info;

            LoadListFood();
            lblMovieInfo.Text = $"{bookingInfo.TenPhim} - {bookingInfo.ThoiGianChieu:dd/MM/yyyy HH:mm} - {bookingInfo.TenPhong}";
        }

        private void LoadListFood()
        {
            flowPanelMenu.Controls.Clear();
            _allFoodCards.Clear();

            string query = "SELECT * FROM DOAN";

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand(query, conn);
                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    UCOrderFoodCard card = new UCOrderFoodCard();

                    /////////////////////////////// xử lý ảnh ////////////////
                    Image img = null;
                    string imagePath = reader["ANHDOAN"] != DBNull.Value ? reader["ANHDOAN"].ToString() : "";
                    if (!string.IsNullOrEmpty(imagePath) && File.Exists(Path.Combine(Application.StartupPath, @"..\..\image", imagePath)))
                        img = Image.FromFile(Path.Combine(Application.StartupPath, @"..\..\image", imagePath));

                    card.SetData(
                            Convert.ToInt32(reader["MADOAN"]),
                            reader["TENDOAN"].ToString(),
                            Convert.ToDecimal(reader["GIADOAN"]),
                            img,
                            Convert.ToInt32(reader["MALOAIDOAN"]) );

                    // dky sự kiện khi click -> thêm vào giỏ
                    card.OnSelect += Card_OnSelect;

                    _allFoodCards.Add(card); //lưu vào list tạm
                    flowPanelMenu.Controls.Add(card); 
                }
           }
            UpdateTotalMoney();
        }

        private void btnTatCa_Click(object sender, EventArgs e)
        {
            Background.Image = Properties.Resources.combo;
            FilterFood(0);
        }

        private void btnCombo_Click(object sender, EventArgs e)
        {
            FilterFood(1);
        }

        private void btnMonAn_Click(object sender, EventArgs e)
        {
            Background.Image = Properties.Resources.backgr_popcorn;
            FilterFood(2);
        }

        private void btnMonUong_Click(object sender, EventArgs e)
        {
            Background.Image = Properties.Resources.backgr_drink;
            FilterFood(3);
        }

        private void FilterFood(int type)
        {
            flowPanelMenu.Controls.Clear();
            foreach (var card in _allFoodCards)
            {
                // type 0 thi hien tat ca
                if (type == 0 || card.LoaiDoan == type)
                    flowPanelMenu.Controls.Add(card);
            }
        }

        ////// XỬ LÝ THÊM VÀO GIỎ HÀNG BÊN PHẢI
        private void Card_OnSelect(object sender, EventArgs e)
        {
            UCOrderFoodCard selectedItem = sender as UCOrderFoodCard;

            //ktra xem đã có trong giỏ hàng chưa
            var existingItem = flowPanelCart.Controls.OfType<UCThanhToanFood>()
                                .FirstOrDefault(x => x.MaDoan == selectedItem.MaDoan);    

            if (existingItem != null)
            {
                existingItem.TangSoLuong();
                UpdateTotalMoney();
                return;
            }

                ///// nếu chưa có --> tạo mới thẻ UCThanhToanFood
            UCThanhToanFood cartItem = new UCThanhToanFood();
            cartItem.SetData(selectedItem.MaDoan, selectedItem.TenDoan, selectedItem.GiaTien);

            cartItem.OnUpdate += (s, ev) => UpdateTotalMoney();
            cartItem.OnDelete += (s, ev) =>
            {
                flowPanelCart.Controls.Remove(cartItem);
                UpdateTotalMoney();
            };

            flowPanelCart.Controls.Add(cartItem);
            UpdateTotalMoney();
        }

        private void UpdateTotalMoney()
        {
            decimal tongTienDoan = 0;
            foreach (UCThanhToanFood item in flowPanelCart.Controls)
            {
                tongTienDoan += item.ThanhTien;
            }

            lblTongTien.Text = tongTienDoan.ToString("N0") + " đ";
        }

        private void btnThanhToan_Click(object sender, EventArgs e)
        {
            bookingInfo.DanhSachDoAn.Clear();
            bookingInfo.TenDoan.Clear();
            bookingInfo.GiaDoAn.Clear();

            decimal finalFoodTotal = 0;

            ///// lưu dữ liệu vào bookingInfo
            foreach (UCThanhToanFood item in flowPanelCart.Controls)
            {
                bookingInfo.DanhSachDoAn.Add(item.MaDoan, item.SoLuong);
                bookingInfo.TenDoan.Add(item.MaDoan, item.TenDoan);
                bookingInfo.GiaDoAn.Add(item.MaDoan, item.GiaTien);

                finalFoodTotal += item.ThanhTien;
            }
            bookingInfo.TongTienDoAn = finalFoodTotal;

            //// CHUYỂN SANG MÀN HÌNH THANH TOÁN CUỐI CÙNG
            OnContinueToCheckout?.Invoke(bookingInfo);
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            OnBack?.Invoke(this, EventArgs.Empty);
        }
    }
}
