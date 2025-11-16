using System;
using System.Collections.Generic; // Thêm
using System.Data;
using System.Drawing;
using System.IO; // Thêm
using System.Windows.Forms;
using Cinema_management.DAL;
using System.Data.SqlClient; // Thêm

namespace Cinema_management
{
    public partial class AddNewMovie : UserControl
    {
        public int? MovieIDToEdit { get; set; } = null;
        // ---------------------------------

        private Database db;
        private string selectedPosterPath = null; // Lưu đường dẫn ảnh tạm

        public AddNewMovie()
        {
            InitializeComponent();
            db = new Database();
            this.Load += new System.EventHandler(this.AddNewMovie_Load);
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);

            // Đăng ký sự kiện: Click vào PictureBox để upload ảnh
            this.btnUploadPoster.Click += new System.EventHandler(this.pictureBox1_Click);
        }

        // Tải form: Kiểm tra xem đang "Add" hay "Edit"
        private void AddNewMovie_Load(object sender, EventArgs e)
        {
            kryptonDateTimePicker1.Format = DateTimePickerFormat.Custom;
            kryptonDateTimePicker1.CustomFormat = "dd/MM/yyyy";

            if (MovieIDToEdit.HasValue)
            {
                //EDIT 
                btnSave.Text = "Update";
                LoadMovieForEditing(MovieIDToEdit.Value);
            }
            else
            {
                //ADD
                btnSave.Text = "Save Movie";
            }
        }

        /// <summary>
        /// Tải dữ liệu phim lên form để sửa
        /// </summary>
        private void LoadMovieForEditing(int movieID)
        {
            try
            {
                string query = "SELECT * FROM PHIM WHERE MAPHIM = @MaPhim";
                SqlParameter[] parameters = { new SqlParameter("@MaPhim", movieID) };
                DataTable dt = db.ReadData(query, parameters);

                if (dt != null && dt.Rows.Count > 0)
                {
                    DataRow row = dt.Rows[0];
                    txbMovieName.Text = row["TENPHIM"].ToString();
                    txbDirector.Text = row["TENTACGIA"].ToString();
                    cbbGenre.Text = row["THELOAIPHIM"].ToString();
                    cbbAge.Text = row["GIOIHANTUOI"].ToString();
                    txbDuration.Text = row["THOILUONGPHIM"].ToString();
                    txbScript.Text = row["MOTAPHIM"].ToString();
                    kryptonDateTimePicker1.Value = Convert.ToDateTime(row["NGAYPHATHANH"]);

                    // Logic tải ảnh từ TÊN FILE
                    if (row["ANHPHIM"] != DBNull.Value)
                    {
                        string posterFileName = row["ANHPHIM"].ToString();
                        string posterDirectory = Path.Combine(Application.StartupPath, "Posters");
                        string fullPath = Path.Combine(posterDirectory, posterFileName);

                        if (File.Exists(fullPath))
                        {
                            using (Image img = Image.FromFile(fullPath))
                            {
                                pictureBox1.Image = new Bitmap(img);
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi tải dữ liệu phim: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Mở cửa sổ chọn file ảnh khi click vào PictureBox
        /// </summary>
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFile = new OpenFileDialog();
            openFile.Filter = "Image Files (*.jpg; *.jpeg; *.png)|*.jpg; *.jpeg; *.png";
            if (openFile.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.Image = new Bitmap(openFile.FileName);
                selectedPosterPath = openFile.FileName; // Lưu đường dẫn gốc
            }
        }

        /// <summary>
        /// Nút Save/Update chính
        /// </summary>
        private void btnSave_Click(object sender, EventArgs e)
        {
            // Validate (Kiểm tra) dữ liệu
            if (!int.TryParse(txbDuration.Text, out int duration))
            {
                MessageBox.Show("Vui lòng nhập Thời lượng là SỐ.", "Lỗi dữ liệu", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (!int.TryParse(cbbAge.Text, out int ageRating))
            {
                MessageBox.Show("Vui lòng nhập Giới hạn tuổi là SỐ (Ví dụ: P -> 0, C13 -> 13)", "Lỗi dữ liệu", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Quyết định gọi Insert hay Update
            if (MovieIDToEdit.HasValue)
            {
                ExecuteUpdate(MovieIDToEdit.Value, duration, ageRating);
            }
            else
            {
                ExecuteInsert(duration, ageRating);
            }
        }

        /// <summary>
        /// Logic THÊM MỚI (Insert)
        /// </summary>
        private void ExecuteInsert(int duration, int ageRating)
        {
            try
            {
                string posterFileNameToSave = null;
                if (selectedPosterPath != null) // Nếu có chọn ảnh
                {
                    string posterDirectory = Path.Combine(Application.StartupPath, "Posters");
                    if (!Directory.Exists(posterDirectory))
                    {
                        Directory.CreateDirectory(posterDirectory);
                    }
                    string extension = Path.GetExtension(selectedPosterPath);
                    posterFileNameToSave = Guid.NewGuid().ToString() + extension; // Tên file ngẫu nhiên
                    string destinationPath = Path.Combine(posterDirectory, posterFileNameToSave);
                    File.Copy(selectedPosterPath, destinationPath); // Copy ảnh vào thư mục Posters
                }

                string query = @"
                    INSERT INTO PHIM (TENPHIM, TENTACGIA, THELOAIPHIM, GIOIHANTUOI, THOILUONGPHIM, MOTAPHIM, NGAYPHATHANH, ANHPHIM) 
                    VALUES (@TenPhim, @TenTacGia, @TheLoaiPhim, @GioiHanTuoi, @ThoiLuong, @MoTaPhim, @NgayPhatHanh, @AnhPhim)";

                SqlParameter[] parameters = {
                    new SqlParameter("@TenPhim", txbMovieName.Text),
                    new SqlParameter("@TenTacGia", txbDirector.Text),
                    new SqlParameter("@TheLoaiPhim", cbbGenre.Text),
                    new SqlParameter("@GioiHanTuoi", ageRating),
                    new SqlParameter("@ThoiLuong", duration),
                    new SqlParameter("@MoTaPhim", txbScript.Text),
                    new SqlParameter("@NgayPhatHanh", kryptonDateTimePicker1.Value.Date),
                    new SqlParameter("@AnhPhim", (object)posterFileNameToSave ?? DBNull.Value) // Lưu TÊN FILE
                };

                if (db.ChangeData(query, parameters))
                {
                    MessageBox.Show("Thêm phim mới thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.ParentForm.Close(); // Tự động đóng form
                }
                else
                {
                    MessageBox.Show("Thêm phim thất bại! (Lỗi CSDL)", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi nghiêm trọng khi thêm phim: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Logic CẬP NHẬT (Update)
        /// </summary>
        private void ExecuteUpdate(int movieID, int duration, int ageRating)
        {
            try
            {
                string posterFileNameToSave = null;
                if (selectedPosterPath != null) // Nếu có chọn ảnh MỚI
                {
                    string posterDirectory = Path.Combine(Application.StartupPath, "Posters");
                    if (!Directory.Exists(posterDirectory))
                    {
                        Directory.CreateDirectory(posterDirectory);
                    }
                    string extension = Path.GetExtension(selectedPosterPath);
                    posterFileNameToSave = Guid.NewGuid().ToString() + extension;
                    string destinationPath = Path.Combine(posterDirectory, posterFileNameToSave);
                    File.Copy(selectedPosterPath, destinationPath);
                }

                string query;
                List<SqlParameter> parameters = new List<SqlParameter> {
                    new SqlParameter("@TenPhim", txbMovieName.Text),
                    new SqlParameter("@TenTacGia", txbDirector.Text),
                    new SqlParameter("@TheLoaiPhim", cbbGenre.Text),
                    new SqlParameter("@GioiHanTuoi", ageRating),
                    new SqlParameter("@ThoiLuong", duration),
                    new SqlParameter("@MoTaPhim", txbScript.Text),
                    new SqlParameter("@NgayPhatHanh", kryptonDateTimePicker1.Value.Date),
                    new SqlParameter("@MaPhim", movieID)
                };

                if (selectedPosterPath != null) // Nếu có ảnh mới
                {
                    query = @"UPDATE PHIM SET TENPHIM = @TenPhim, TENTACGIA = @TenTacGia, THELOAIPHIM = @TheLoaiPhim, 
                              GIOIHANTUOI = @GioiHanTuoi, THOILUONGPHIM = @ThoiLuong, MOTAPHIM = @MoTaPhim, 
                              NGAYPHATHANH = @NgayPhatHanh, ANHPHIM = @AnhPhim
                              WHERE MAPHIM = @MaPhim";
                    parameters.Add(new SqlParameter("@AnhPhim", posterFileNameToSave));
                }
                else // Nếu không chọn ảnh mới (giữ ảnh cũ)
                {
                    query = @"UPDATE PHIM SET TENPHIM = @TenPhim, TENTACGIA = @TenTacGia, THELOAIPHIM = @TheLoaiPhim, 
                              GIOIHANTUOI = @GioiHanTuoi, THOILUONGPHIM = @ThoiLuong, MOTAPHIM = @MoTaPhim, 
                              NGAYPHATHANH = @NgayPhatHanh
                              WHERE MAPHIM = @MaPhim";
                }

                if (db.ChangeData(query, parameters.ToArray()))
                {
                    MessageBox.Show("Cập nhật phim thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.ParentForm.Close(); // Tự động đóng
                }
                else
                {
                    MessageBox.Show("Cập nhật thất bại! (Lỗi CSDL)", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi nghiêm trọng khi cập nhật: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Nút Hủy
        /// </summary>
        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.ParentForm.Close();
        }
    }
}
