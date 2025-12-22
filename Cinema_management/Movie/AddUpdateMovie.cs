using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using Cinema_management.DAL;
using Cinema_management.MessageboxCustom.Utils;
using Cinema_management.MessageboxCustom;

namespace Cinema_management
{
    public partial class AddUpdateMovieForm : Form
    {
        private Database db = new Database();
        private string _movieIDToEdit = null;
        private string _posterFileName = null; // Lưu tên file ảnh (ví dụ: "a1b2c3d4_abc.jpg")

        // Đường dẫn thư mục chứa ảnh (Ngang hàng với file .csproj và Form1.cs)
        // Lưu ý: Dùng Path.GetFullPath để chuẩn hóa đường dẫn
        private string _posterFolderPath = Path.GetFullPath(Path.Combine(Application.StartupPath, @"..\..\Posters"));

        public AddUpdateMovieForm(string movieID = null)
        {
            InitializeComponent();
            _movieIDToEdit = movieID;

            // Tạo thư mục nếu chưa có (để tránh lỗi)
            if (!Directory.Exists(_posterFolderPath))
            {
                Directory.CreateDirectory(_posterFolderPath);
            }
        }

        private void AddUpdateMovieForm_Load(object sender, EventArgs e)
        {
            InitComboBoxData();
            txtMovieID.Enabled = false; // Khóa ID phim

            if (!string.IsNullOrEmpty(_movieIDToEdit))
            {
                // --- CHẾ ĐỘ SỬA ---
                label.Text = "Update Movie";
                txtMovieID.Text = _movieIDToEdit;
                LoadMovieData();
            }
            else
            {
                // --- CHẾ ĐỘ THÊM MỚI ---
                label.Text = "Add New Movie";
                txtMovieID.Text = GetNextMovieID().ToString();

                // Mặc định chọn item đầu tiên
                if (cbbGenre.Items.Count > 0) cbbGenre.SelectedIndex = 0;
                if (cbbAge.Items.Count > 0) cbbAge.SelectedIndex = 0;
            }
        }

        private int GetNextMovieID()
        {
            try
            {
                string query = "SELECT IDENT_CURRENT('PHIM') + IDENT_INCR('PHIM')";
                DataTable dt = db.ReadData(query);
                if (dt.Rows.Count > 0 && dt.Rows[0][0] != DBNull.Value)
                {
                    return Convert.ToInt32(dt.Rows[0][0]);
                }
                return 1;
            }
            catch
            {
                return 1;
            }
        }

        private void InitComboBoxData()
        {
            cbbGenre.Items.Clear();
            cbbGenre.Items.AddRange(new string[] { "Hành động", "Tình cảm", "Kinh dị", "Hài hước", "Khoa học viễn tưởng", "Hoạt hình" });

            cbbAge.Items.Clear();
            cbbAge.Items.AddRange(new string[] { "0", "13", "16", "18" });
        }

        private void LoadMovieData()
        {
            string query = "SELECT * FROM PHIM WHERE MAPHIM = @MAPHIM";
            SqlParameter[] parameters = { new SqlParameter("@MAPHIM", _movieIDToEdit) };

            DataTable dt = db.ReadData(query, parameters);
            if (dt.Rows.Count > 0)
            {
                DataRow row = dt.Rows[0];

                txtMovieName.Text = row["TENPHIM"].ToString();
                cbbGenre.Text = row["THELOAIPHIM"].ToString();
                cbbAge.Text = row["GIOIHANTUOI"].ToString();
                txtDirector.Text = row["TENTACGIA"].ToString();
                txtDuration.Text = row["THOILUONGPHIM"].ToString();
                rtbDescription.Text = row["MOTAPHIM"].ToString();

                if (row["NGAYPHATHANH"] != DBNull.Value)
                    dtpReleaseDate.Value = Convert.ToDateTime(row["NGAYPHATHANH"]);

                // --- LOAD ẢNH ---
                string fileName = row["ANHPHIM"].ToString();
                if (!string.IsNullOrEmpty(fileName))
                {
                    string fullPath = Path.Combine(_posterFolderPath, fileName);
                    if (File.Exists(fullPath))
                    {
                        picPoster.Image = Image.FromFile(fullPath);
                        picPoster.SizeMode = PictureBoxSizeMode.Zoom;
                        _posterFileName = fileName; // Lưu lại tên file cũ
                    }
                }
            }
        }

        private void btnUploadPoster_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string sourceFilePath = openFileDialog.FileName;

                // Hiển thị ảnh lên PictureBox
                picPoster.Image = Image.FromFile(sourceFilePath);
                picPoster.SizeMode = PictureBoxSizeMode.Zoom;

                // Lưu đường dẫn gốc vào Tag để tí nữa copy
                picPoster.Tag = sourceFilePath;

                // --- TẠO TÊN FILE MỚI (Kết hợp GUID + Tên gốc) ---
                string originalFileName = Path.GetFileName(sourceFilePath);
                string uniquePrefix = Guid.NewGuid().ToString().Substring(0, 8);

                // Ví dụ: "a1b2c3d4_mai.jpg"
                _posterFileName = $"{uniquePrefix}_{originalFileName}";
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            // 1. Kiểm tra nhập liệu
            if (string.IsNullOrWhiteSpace(txtMovieName.Text))
            {
                Alert.Show("Vui lòng nhập tên phim!", MessagboxCustom.AlertMessagebox.AlertType.Error);
                txtMovieName.Focus();
                return;
            }

            if (!int.TryParse(txtDuration.Text, out int thoiLuong))
            {
                Alert.Show("Thời lượng phim phải là số phút!", MessagboxCustom.AlertMessagebox.AlertType.Error);
                return;
            }

            // 2. XỬ LÝ LƯU ẢNH VÀO FOLDER
            // Chỉ copy khi người dùng CÓ chọn ảnh mới (Tag != null)
            if (picPoster.Tag != null)
            {
                string sourceFile = picPoster.Tag.ToString();
                string destFile = Path.Combine(_posterFolderPath, _posterFileName);

                try
                {
                    File.Copy(sourceFile, destFile, true); // Copy và ghi đè nếu cần
                }
                catch (Exception)
                {

                    Alert.Show("Lỗi lưu ảnh!", MessagboxCustom.AlertMessagebox.AlertType.Error);
                    return; // Dừng lại nếu lỗi file
                }
            }
            // Lưu ý: Nếu Tag == null (người dùng ko đổi ảnh), thì _posterFileName vẫn giữ giá trị cũ (khi load data) 
            // hoặc null (nếu thêm mới ko chọn ảnh) -> Logic vẫn đúng.

            string query = "";
            SqlParameter[] parameters = null;

            // 3. LƯU VÀO DATABASE
            if (string.IsNullOrEmpty(_movieIDToEdit))
            {
                // --- INSERT ---
                query = @"INSERT INTO PHIM (TENPHIM, THELOAIPHIM, GIOIHANTUOI, TENTACGIA, THOILUONGPHIM, NGAYPHATHANH, MOTAPHIM, ANHPHIM) 
                          VALUES (@Ten, @TheLoai, @Tuoi, @TacGia, @ThoiLuong, @Ngay, @MoTa, @AnhPhim)";

                parameters = new SqlParameter[] {
                    new SqlParameter("@Ten", txtMovieName.Text),
                    new SqlParameter("@TheLoai", cbbGenre.SelectedItem?.ToString() ?? ""),
                    new SqlParameter("@Tuoi", cbbAge.SelectedItem?.ToString() ?? ""),
                    new SqlParameter("@TacGia", txtDirector.Text),
                    new SqlParameter("@ThoiLuong", thoiLuong),
                    new SqlParameter("@Ngay", dtpReleaseDate.Value),
                    new SqlParameter("@MoTa", rtbDescription.Text),
                    new SqlParameter("@AnhPhim", _posterFileName ?? (object)DBNull.Value) // Quan trọng: Lưu tên file ảnh
                };
            }
            else
            {
                // --- UPDATE ---
                query = @"UPDATE PHIM 
                          SET TENPHIM = @Ten, 
                              THELOAIPHIM = @TheLoai, 
                              GIOIHANTUOI = @Tuoi, 
                              TENTACGIA = @TacGia, 
                              THOILUONGPHIM = @ThoiLuong, 
                              NGAYPHATHANH = @Ngay, 
                              MOTAPHIM = @MoTa,
                              ANHPHIM = @AnhPhim 
                          WHERE MAPHIM = @MaPhim";

                parameters = new SqlParameter[] {
                    new SqlParameter("@MaPhim", _movieIDToEdit),
                    new SqlParameter("@Ten", txtMovieName.Text),
                    new SqlParameter("@TheLoai", cbbGenre.SelectedItem?.ToString() ?? cbbGenre.Text),
                    new SqlParameter("@Tuoi", cbbAge.SelectedItem?.ToString() ?? cbbAge.Text),
                    new SqlParameter("@TacGia", txtDirector.Text),
                    new SqlParameter("@ThoiLuong", thoiLuong),
                    new SqlParameter("@Ngay", dtpReleaseDate.Value),
                    new SqlParameter("@MoTa", rtbDescription.Text),
                    new SqlParameter("@AnhPhim", _posterFileName ?? (object)DBNull.Value) // Cập nhật tên file ảnh
                };
            }

            if (db.ChangeData(query, parameters))
            {
                Alert.Show("Lưu dữ liệu phim thành công!", MessagboxCustom.AlertMessagebox.AlertType.Success);
                
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}