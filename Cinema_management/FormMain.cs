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
using Cinema_management.MessageboxCustom.Utils;
using Cinema_management.Ticket_Booking;
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
            uc.Dock = DockStyle.Fill;
            // thêm dashboard vào panel
            pnContentforUC.Controls.Add(uc);
            CenterUC();
        }

        private void kryptonButton1_Click(object sender, System.EventArgs e)
        {
            pnContentforUC.Controls.Clear();

            UCMovies1 uc = new UCMovies1();
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

            UCPhimDangChieu uc = new UCPhimDangChieu();
            uc.Dock = DockStyle.Fill;

            pnContentforUC.Controls.Add(uc);
            //int MaSuatChieu = 13;
            //uc.LoadSeats(MaSuatChieu);
        }

        private void FormMain_Load(object sender, System.EventArgs e)
        {
            btnDashboard_Click(sender, e);
        }

        private void ucMovies1_Load(object sender, System.EventArgs e)
        {

        }

        private void kryptonButton5_Click(object sender, System.EventArgs e)
        {
            DialogResult result = Alert.ShowWarning("Bạn có muốn đăng xuất?");
            if(result == DialogResult.OK)
            {
                this.Close();
            }
        }

        private void pnContentforUC_Resize(object sender, System.EventArgs e)
        {
            CenterUC();
        }

        private void CenterUC()
        {
            if (pnContentforUC.Controls.Count == 0 || !pnContentforUC.Visible)
                return;

            // lay uc hien tai
            Control currentUC = pnContentforUC.Controls[0];

            int newX = (pnContentforUC.Width - currentUC.Width) / 2;
            int newY = (pnContentforUC.Height - currentUC.Height) / 2;

            if(newX < 0) newX = 0;
            if(newY < 0) newY = 0;

            currentUC.Location = new Point(newX, newY);
        }
    }
}
