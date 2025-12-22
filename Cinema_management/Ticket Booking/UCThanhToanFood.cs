using Cinema_management.MessageboxCustom.Utils;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cinema_management.Ticket_Booking
{
    public partial class UCThanhToanFood : UserControl
    {
        //public event EventHandler OnQuantityChanged;

        public event EventHandler OnUpdate; // để tính lại tổng tiền
        public event EventHandler OnDelete; // đẻ xóa control khỏi panel khi sl=0

        public int MaDoan { get; set; }
        public decimal GiaTien { get; set; }
        public string TenDoan { get; set; }
        public int SoLuong { get; set; } = 1;
        public int SoLuongTon { get; set; }

        public UCThanhToanFood()
        {
            InitializeComponent();
        }

        public void SetData (int id, string name, decimal price, int maxStock, int soLuong = 1)
        {
            MaDoan = id;
            SoLuong = soLuong;
            TenDoan = name;
            GiaTien = price;
            SoLuongTon = maxStock;// lưu sl tồn kho

            UpdateUI();

        }

        public void TangSoLuong() // dc gọi khi click vào card bên trái
        {
            if(SoLuong >= SoLuongTon) //ktra sl 
            {
                Alert.Show("Đã chọn số lượng tối đa trong kho!", MessagboxCustom.AlertMessagebox.AlertType.Info);
                return;
            }

            SoLuong++;
            UpdateUI();
            OnUpdate?.Invoke(this, EventArgs.Empty); 
        }

        private void btnPlus_Click(object sender, EventArgs e)
        {
            TangSoLuong();
        }

        private void btnMinus_Click(object sender, EventArgs e)
        {
            SoLuong--;
            if (SoLuong <= 0)
            {
                OnDelete?.Invoke(this, EventArgs.Empty);
            }
            else
            {
                UpdateUI();
                OnUpdate?.Invoke(this, EventArgs.Empty);
            }
        }

        private void UpdateUI()
        {
            lblTenMon.Text = TenDoan;
            lblGia.Text = GiaTien.ToString("N0") + " đ";
            txtSoLuong.Text = SoLuong.ToString();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            OnDelete?.Invoke(this, EventArgs.Empty); //báo ra ngoài để xóa ctrl này đi
        }

        public decimal ThanhTien => SoLuong * GiaTien;
    }
}
