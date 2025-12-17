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
    public partial class UCThongKeMain : UserControl
    {
        public UCThongKeMain()
        {
            InitializeComponent();
            btnTongQuan_Click(this, EventArgs.Empty);
        }
        private void btnDoanhThu_Click(object sender, EventArgs e)
        {
            grUC.Panel.Controls.Clear();

            UCDoanhThu uc = new UCDoanhThu();
            uc.Dock = DockStyle.Fill;

            grUC.Panel.Controls.Add(uc);
        }

        private void btnTongQuan_Click(object sender, EventArgs e)
        {
            grUC.Panel.Controls.Clear();

            UCTongQuan uc = new UCTongQuan();
            uc.Dock = DockStyle.Fill;

            grUC.Panel.Controls.Add(uc);
        }

        private void kryptonGroup1_Panel_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
