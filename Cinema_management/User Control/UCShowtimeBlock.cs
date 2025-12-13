using Krypton.Toolkit;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace Cinema_management
{
    public partial class UCShowtimeBlock : UserControl
    {
        public int MaSuatChieu { get; private set; }
        public DateTime ThoiGianChieu { get; private set; }

        public event EventHandler OnBlockClicked;

        public UCShowtimeBlock()
        {
            InitializeComponent();

            this.BorderStyle = BorderStyle.FixedSingle;
            this.Cursor = Cursors.Hand;

            // Lan truyền sự kiện click
            this.Click += (s, e) => OnBlockClicked?.Invoke(this, e);
            lblTime.Click += (s, e) => OnBlockClicked?.Invoke(this, e);
            lblMovieName.Click += (s, e) => OnBlockClicked?.Invoke(this, e);
        }

        public void SetData(int maSuatChieu, string tenPhim, DateTime thoiGian, string tenPhong)
        {
            this.MaSuatChieu = maSuatChieu;
            this.ThoiGianChieu = thoiGian;

            lblTime.Text = thoiGian.ToString("HH:mm");
            lblMovieName.Text = tenPhim;

            ToolTip tt = new ToolTip();
            string info = $"{tenPhim}\n{tenPhong}\n{thoiGian:HH:mm dd/MM/yyyy}";
            tt.SetToolTip(this, info);
            tt.SetToolTip(lblMovieName, info);
            tt.SetToolTip(lblTime, info);

            // Sinh màu nền tối
            this.BackColor = GetColorFromText(tenPhim);

            // --- CHỈNH SỬA: Đổi màu chữ sang TRẮNG để nổi trên nền tối ---
            lblTime.ForeColor = Color.White;
            lblMovieName.ForeColor = Color.WhiteSmoke;
        }

        private Color GetColorFromText(string text)
        {
            if (string.IsNullOrEmpty(text)) return Color.Teal;

            int hash = text.GetHashCode();
            Random rnd = new Random(hash);

            // --- CHỈNH SỬA: Sinh màu TỐI (Dark) ---
            // R, G, B thấp (từ 30 đến 160) sẽ tạo ra màu đậm/tối
            int r = rnd.Next(30, 160);
            int g = rnd.Next(30, 160);
            int b = rnd.Next(30, 160);

            return Color.FromArgb(r, g, b);
        }
    }
}