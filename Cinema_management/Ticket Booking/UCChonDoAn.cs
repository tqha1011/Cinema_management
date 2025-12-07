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
    public partial class UCChonDoAn : UserControl
    {
        public UCChonDoAn()
        {
            InitializeComponent();
            btnTatCa.PerformClick();
        }

        private void btnTatCa_Click(object sender, EventArgs e)
        {
            Background.Image = Properties.Resources.combo;
        }

        private void btnMonAn_Click(object sender, EventArgs e)
        {
            Background.Image = Properties.Resources.backgr_popcorn;
        }

        private void btnMonUong_Click(object sender, EventArgs e)
        {
            Background.Image = Properties.Resources.backgr_drink;
        }
    }
}
