using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Krypton.Toolkit;

namespace Cinema_management
{
    public partial class UCShowtimes : UserControl
    {
        public UCShowtimes()
        {
            InitializeComponent();
        }

        private void UCShowtimes_Load(object sender, EventArgs e)
        {
            dgvShows.Rows.Add("Bo gia", "2d", "120", "21:00");
        }

        private void lvShowtimes_Click(object sender, EventArgs e)
        {

        }

        private void lblShowtimes_Click(object sender, EventArgs e)
        {

        }
    }
}
