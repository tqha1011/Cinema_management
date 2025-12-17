using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Drawing2D;

namespace Cinema_management.Personal_Info
{
    public partial class UCThongTinCaNhan : UserControl
    {
        public UCThongTinCaNhan()
        {
            InitializeComponent();
        }

        public void MakePictureBoxRound(PictureBox pb)
        {
            // Tạo một đường dẫn đồ họa hình Elipse (hình tròn nếu pb vuông)
            GraphicsPath gp = new GraphicsPath();
            gp.AddEllipse(0, 0, pb.Width, pb.Height);

            // Gán vùng hiển thị của PictureBox theo đường dẫn đó
            pb.Region = new Region(gp);
        }

        private void UCThongTinCaNhan_Load(object sender, EventArgs e)
        {
            MakePictureBoxRound(kryptonPictureBox1);
        }

        private void kryptonPictureBox1_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
            using (Pen pen = new Pen(Color.LightGray, 2))
            {
                e.Graphics.DrawEllipse(pen, 0, 0, kryptonPictureBox1.Width - 1, kryptonPictureBox1.Height - 1);
            }
        }

        private void kryptonTableLayoutPanel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
