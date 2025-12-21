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
    public partial class UCHoaDonFood : UserControl
    {
        public UCHoaDonFood()
        {
            InitializeComponent();
        }

        public void SetData (string name, int quantity, decimal price)
        {
            lblTenMon.Text = name;
            lblSoLuong.Text = "SL: " + quantity;
            lblGia.Text = (price).ToString("N0") + " VNĐ";
        }

        private void lblGia_Click(object sender, EventArgs e)
        {

        }
    }
}
