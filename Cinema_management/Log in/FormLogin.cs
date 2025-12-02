using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Krypton.Toolkit;

namespace Cinema_management
{
    public partial class FormLogin : KryptonForm
    {
        private List<string> listPoster = new List<string>();
        private int currentPoster = 0;
        private Timer slidePoster = new Timer();
        private Timer transitionTimer; // them hieu ung truot cho form Login
        private UserControl currUC; // luu tru UserControl hien tai
        private UserControl nextUC; // luu tru UserControl tiep theo
        private int step = 40; // toc do truot khung hinh
        private PictureBox pbSnapshotCurr; // anh chup UserControl hien tai
        private PictureBox pbSnapshotNext; // anh chup UserControl tiep theo
        private Bitmap bmpCurr; // luu anh chup UserControl hien tai
        private Bitmap bmpNext; // luu anh chup UserControl tiep theo
        public FormLogin()
        {
            InitializeComponent();
            SetDoubleBuffered(grContain.Panel); // giam nhieu hinh khi load UC
            this.CenterToScreen();
            transitionTimer = new Timer();
            transitionTimer.Interval = 15; // thoi gian giua cac buoc
            transitionTimer.Tick += TransitionTimer_Tick;
            ShowUserControl(new UCLogin());
            SetSlidePoster();
        }

        // ham xu ly double buffer de giam nhieu hinh khi load UC
        public static void SetDoubleBuffered(System.Windows.Forms.Control c)
        {
            if (System.Windows.Forms.SystemInformation.TerminalServerSession)
                return;
            System.Reflection.PropertyInfo aProp = typeof(System.Windows.Forms.Control).GetProperty("DoubleBuffered",
                System.Reflection.BindingFlags.NonPublic |
                System.Reflection.BindingFlags.Instance);
            aProp.SetValue(c, true, null);
        }

        public void ShowUserControl(UserControl uc, bool animation = true)
        {
            if (!animation || grContain.Panel.Controls.Count == 0)
            {
                grContain.Panel.Controls.Clear();
                uc.Dock = DockStyle.Fill;
                grContain.Panel.Controls.Add(uc);
                currUC = uc;
                uc.BringToFront();
                uc.Focus();
                return;
            }

            // Nếu đang chạy hiệu ứng cũ thì không nhận lệnh mới để tránh lỗi chồng chéo
            if (transitionTimer.Enabled) return;

            // 1. Xác định UC hiện tại
            if (grContain.Panel.Controls.Count > 0)
            {
                currUC = grContain.Panel.Controls[0] as UserControl;
            }

            // 2. chuan bi cho UC ke tiep
            nextUC = uc;
            nextUC.Dock = DockStyle.Fill; // tự co giãn theo Panel
            nextUC.Visible = false;       // Ẩn đi để người dùng chưa thấy cái thật

            grContain.Panel.Controls.Add(nextUC);

            // Ép buộc tính toán giao diện (để các label, textbox vào đúng vị trí)
            // Nếu không có bước này, ảnh chụp sẽ bị lệch font hoặc vị trí control
            nextUC.BringToFront();
            nextUC.PerformLayout(); 

            // chụp ảnh 
            bmpCurr = TakeSnapshot(currUC);
            bmpNext = TakeSnapshot(nextUC);

            // Ảnh hiện tại
            pbSnapshotCurr = new PictureBox();
            pbSnapshotCurr.Image = bmpCurr;
            pbSnapshotCurr.Size = grContain.Panel.ClientSize;
            pbSnapshotCurr.Location = new Point(0, 0);
            pbSnapshotCurr.BorderStyle = BorderStyle.None;

            // anh tiếp theo 
            pbSnapshotNext = new PictureBox();
            pbSnapshotNext.Image = bmpNext;
            pbSnapshotNext.Size = grContain.Panel.ClientSize;
            pbSnapshotNext.Location = new Point(grContain.Panel.Width, 0);
            pbSnapshotNext.BorderStyle = BorderStyle.None;

            // Thêm PictureBox vào Panel và Ẩn UC thật đi
            grContain.Panel.Controls.Add(pbSnapshotNext);
            grContain.Panel.Controls.Add(pbSnapshotCurr);

            pbSnapshotNext.BringToFront();
            pbSnapshotCurr.BringToFront();

            // Ẩn UC cũ thật đi để nhẹ máy
            currUC.Visible = false;

            // 6. Bắt đầu Timer trượt
            transitionTimer.Start();
        }

        private void TransitionTimer_Tick(object sender, EventArgs e)
        {
            // Di chuyển 2 bức ảnh sang trái
            if (pbSnapshotCurr != null) pbSnapshotCurr.Left -= step;
            if (pbSnapshotNext != null) pbSnapshotNext.Left -= step;

            // Kiểm tra nếu ảnh mới đã trượt đến đích (hoặc vượt quá)
            if (pbSnapshotNext != null && pbSnapshotNext.Left <= 0)
            {
                transitionTimer.Stop();

                // Trước khi xóa ảnh, ta ép vị trí ảnh về đúng tọa độ 0 tuyệt đối
                // Điều này giúp hình ảnh khớp 100% với UserControl thật sắp hiện ra
                pbSnapshotNext.Left = 0;

                // Vẽ lại ngay lập tức để mắt người dùng thấy hình ảnh ở vị trí chuẩn
                pbSnapshotNext.Refresh();

                // --- DỌN DẸP ---

                // 1. Hiện UC mới thật lên (đang nằm sẵn ở dưới)
                if (nextUC != null)
                {
                    nextUC.Visible = true;
                    nextUC.Focus();
                }

                // 2. Xóa các PictureBox ảo (Xóa sau khi hiện UC thật để không bị nháy trắng)
                if (grContain.Panel.Controls.Contains(pbSnapshotCurr))
                    grContain.Panel.Controls.Remove(pbSnapshotCurr);

                if (grContain.Panel.Controls.Contains(pbSnapshotNext))
                    grContain.Panel.Controls.Remove(pbSnapshotNext);

                // Giải phóng bộ nhớ
                if (pbSnapshotCurr != null) { pbSnapshotCurr.Dispose(); pbSnapshotCurr = null; }
                if (pbSnapshotNext != null) { pbSnapshotNext.Dispose(); pbSnapshotNext = null; }
                if (bmpCurr != null) { bmpCurr.Dispose(); bmpCurr = null; }
                if (bmpNext != null) { bmpNext.Dispose(); bmpNext = null; }

                // 3. Xóa UC cũ thật
                if (currUC != null)
                {
                    grContain.Panel.Controls.Remove(currUC);
                    currUC.Dispose();
                }

                // 4. Cập nhật biến tham chiếu
                currUC = nextUC;
                nextUC = null;
            }
        }
        private void SetSlidePoster()
        {
            try
            {
                string folderPath = Path.Combine(Application.StartupPath, "Posters");
                if(Directory.Exists(folderPath))
                {
                    listPoster.AddRange(Directory.GetFiles(folderPath, "*.png").ToList());
                    listPoster.AddRange(Directory.GetFiles(folderPath, "*.jpg").ToList());
                    listPoster.AddRange(Directory.GetFiles(folderPath, "*.jpeg").ToList());
                    if (listPoster.Count > 0)
                    {
                        LoadPoster(0);
                        slidePoster.Interval = 5000; // 5 seconds
                        slidePoster.Tick += slidePoster_Tick;
                        slidePoster.Start();
                    }
                }
            }
            catch
            {
                Console.WriteLine("Fail to load image");
            }
        }

        private void slidePoster_Tick(object sender, EventArgs e)
        {
            if(listPoster.Count == 0)
            {
                return;
            }
            currentPoster++;
            if(currentPoster >= listPoster.Count)
            {
                currentPoster = 0;
            }
            LoadPoster(currentPoster);
        }

        // ham dung de chup anh giao dien cua control
        private Bitmap TakeSnapshot(Control c)
        {
            // Tạo ảnh bitmap với kích thước bằng control
            Bitmap bmp = new Bitmap(c.Width, c.Height);
            // Vẽ giao diện control lên bitmap
            c.DrawToBitmap(bmp, new Rectangle(0, 0, c.Width, c.Height));
            return bmp;
        }

        private void LoadPoster(int index)
        {
           pbPoster.ImageLocation = listPoster[index];
        }

        private void pbPoster_Click(object sender, EventArgs e)
        {

        }

        private void kryptonButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
