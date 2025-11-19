//using System;
//using System.Collections.Generic;
//using System.ComponentModel;
//using System.Data;
//using System.Drawing;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
//using System.Windows.Forms;
using System.Drawing;
using System.Windows.Forms;
using Krypton.Toolkit;

namespace Cinema_management
{
    public partial class FormMain : KryptonForm
    {
        public FormMain()
        {
            InitializeComponent();
        }

        private void kryptonCustomPaletteBase1_PalettePaint(object sender, Krypton.Toolkit.PaletteLayoutEventArgs e)
        {

        }

        private void btnDashboard_Click(object sender, System.EventArgs e)
        {
            // Xóa mọi thứ trong pn
            pnContentforUC.Controls.Clear();
            // tạo đt UCDashboard mới
            UCDashboard uc = new UCDashboard();
            uc.Dock = DockStyle.Fill; // cho nó lấp đầy panel
            // thêm dashboard vào panel
            pnContentforUC.Controls.Add(uc);
        }

        private void kryptonButton1_Click(object sender, System.EventArgs e)
        {
            pnContentforUC.Controls.Clear();

            UCMovies uc = new UCMovies();
            uc.Dock = DockStyle.Fill;

            pnContentforUC.Controls.Add(uc);
        }

        private void kryptonButton2_Click(object sender, System.EventArgs e)
        {
            pnContentforUC.Controls.Clear();

            UCStaffs uc = new UCStaffs();
            uc.Dock = DockStyle.Fill;

            pnContentforUC.Controls.Add(uc);
        }

        private void kryptonButton3_Click(object sender, System.EventArgs e)
        {
            pnContentforUC.Controls.Clear();

            UCShowtimes uc = new UCShowtimes();
            uc.Dock = DockStyle.Fill;

            pnContentforUC.Controls.Add(uc);
        }

        private void kryptonButton4_Click(object sender, System.EventArgs e)
        {
            pnContentforUC.Controls.Clear();

            UCTickets uc = new UCTickets();
            uc.Dock = DockStyle.Fill;

            pnContentforUC.Controls.Add(uc);
            int MaSuatChieu = 13;
            uc.LoadSeats(MaSuatChieu);
        }

        private void FormMain_Load(object sender, System.EventArgs e)
        {
            btnDashboard_Click(sender, e);
        }

        private void ucMovies1_Load(object sender, System.EventArgs e)
        {

        }
    }
}
