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
    public partial class UCDoanhThu : UserControl
    {
        public UCDoanhThu()
        {
            InitializeComponent();
        }

        private void cbbChuKi_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void kryptonPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void kryptonComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (kryptonComboBox1.Text == "Theo tháng")
            {
                kryptonComboBox2.Items.Clear();

                kryptonComboBox2.Items.AddRange(new object[] {
                "Tháng 1", "Tháng 2", "Tháng 3", "Tháng 4",
                "Tháng 5", "Tháng 6", "Tháng 7", "Tháng 8",
                "Tháng 9", "Tháng 10", "Tháng 11", "Tháng 12"
                });
                kryptonComboBox2.SelectedIndex = 0;
            }
            if (kryptonComboBox1.Text == "Theo năm")
            {
                kryptonComboBox2.Items.Clear();

                kryptonComboBox2.Items.AddRange(new object[] {
                "2025", "2024", "2023", "2022"
                });
                kryptonComboBox2.SelectedIndex = 0;
            }
        }

    }
}
