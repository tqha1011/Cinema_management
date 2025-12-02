using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cinema_management.Ticket_Booking
{
    public partial class UCMovieCard : UserControl
    {
        //Sự kiện để báo ra bên ngoài "card đã được click"
        public event EventHandler OnSelect;

        public int MaPhim {  get; set; } //lưu ID phim ẩn

        // Đường dẫn thư mục chứa ảnh (Ngang hàng với file .csproj và Form1.cs)
        // Lưu ý: Dùng Path.GetFullPath để chuẩn hóa đường dẫn
        private string _posterFolderPath = Path.GetFullPath(Path.Combine(Application.StartupPath, @"..\..\Posters"));

        public UCMovieCard()
        {
            InitializeComponent();
            //gán sự kiện click cho cả poster và tên phim
            this.Click += UCMovieCard_Click;
            picPoster.Click += UCMovieCard_Click;
            lbTitle.Click += UCMovieCard_Click;

            // Tạo thư mục nếu chưa có (để tránh lỗi)
            if (!Directory.Exists(_posterFolderPath))
            {
                Directory.CreateDirectory(_posterFolderPath);
            }
        }

        public void SetData(int maPhim, string tenPhim, string pathAnh)
        {
            this.MaPhim = maPhim;
            lbTitle.Text = tenPhim;

            //xử lý đường dẫn ảnh
            //try
            //{
            //    if (!string.IsNullOrEmpty(pathAnh))
            //    {
            //        // Nếu đường dẫn là tương đối, ghép nó với thư mục chạy của phần mềm
            //        // Ví dụ CSDL lưu "images/abc.jpg" -> ghép thành "C:/.../bin/Debug/images/abc.jpg"
            //        string projectPath = Application.StartupPath;
            //        string fullPath = System.IO.Path.Combine(projectPath, pathAnh);

            //        if (System.IO.File.Exists(fullPath))
            //        {
            //            picPoster.Image = Image.FromFile(fullPath);
            //            picPoster.SizeMode = PictureBoxSizeMode.StretchImage; // Co giãn ảnh cho vừa khung
            //        }
            //        else
            //        {
            //            // Nếu không tìm thấy file, có thể load ảnh mặc định hoặc để trống
            //            // picPoster.Image = Properties.Resources.NoImage; 
            //            picPoster.Image = null;
            //        }
            //    }
            //    else
            //    {
            //        picPoster.Image = null;
            //    }
            //}
            //catch
            //{
            //    // Nếu file ảnh bị lỗi định dạng, bỏ qua, không crash app
            //    picPoster.Image = null;
            //}

            // --- LOAD ẢNH ---
            string fileName = pathAnh;
            if (!string.IsNullOrEmpty(fileName))
            {
                string fullPath = Path.Combine(_posterFolderPath, fileName);
                if (File.Exists(fullPath))
                {
                    picPoster.Image = Image.FromFile(fullPath);
                    picPoster.SizeMode = PictureBoxSizeMode.Zoom;
                }
            }
        }
        

        private void UCMovieCard_Click(object sender, EventArgs e)
        {
            //kich hoạt sự kiện để UC cha biết
            OnSelect?.Invoke(this, e);
        }

        private void UCMovieCard_Load(object sender, EventArgs e)
        {

        }
    }
}
