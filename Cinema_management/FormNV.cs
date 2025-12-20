using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Cinema_management.Personal_Info;
using Cinema_management.Ticket_Booking;
using Krypton.Toolkit;

namespace Cinema_management
{
    public partial class FormNV : KryptonForm
    {
        public FormNV()
        {
            InitializeComponent();
            btnBanVe_Click(this, EventArgs.Empty);
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

        private void btnBanVe_Click(object sender, EventArgs e)
        {
            pnforUC.Controls.Clear();
            UCPhimDangChieu uc = new UCPhimDangChieu();
            uc.Dock = DockStyle.Fill;
            pnforUC.Controls.Add(uc);
        }
    }
}
