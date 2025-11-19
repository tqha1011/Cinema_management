using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using Krypton.Toolkit;
using Cinema_management.DAL;
using System.Data.SqlClient;

namespace Cinema_management
{
    public partial class UCMovies : UserControl
    {
        private Database db;

        public UCMovies()
        {
            InitializeComponent();
            db = new Database();
        }

        private void UCMovies_Load(object sender, EventArgs e)
        {

            // Cài đặt DataGridView
            dgvMM.AllowUserToAddRows = false;
            dgvMM.ReadOnly = true;

            // Sửa lỗi vỡ giao diện
            dgvMM.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            dgvMM.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvMM.StateCommon.Background.Color1 = Color.White;
            dgvMM.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(255, 255, 255);

            // Cho phép click nút trong grid
            if (dgvMM.Columns.Contains("editBtn"))
            {
                dgvMM.Columns["editBtn"].ReadOnly = false;
            }
            if (dgvMM.Columns.Contains("delBtn"))
            {
                dgvMM.Columns["delBtn"].ReadOnly = false;
            }

            // Đăng ký sự kiện
            this.dgvMM.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvMM_CellContentClick);
            this.txbSearchMovie.TextChanged += new System.EventHandler(this.txbSearchMovie_TextChanged);

            // Tải dữ liệu lần đầu
            LoadMovies(); // Đổi tên hàm
        }

        /// <summary>
        /// Hàm trung tâm: Tải/Tải lại toàn bộ dữ liệu phim từ CSDL lên DataGridView
        /// (Đã sửa lại hàm của bạn cho đúng)
        /// </summary>
        private void LoadMovies() // Đổi tên hàm
        {
            try
            {
                string query = @"
                    SELECT MAPHIM, TENPHIM, THELOAIPHIM, GIOIHANTUOI, THOILUONGPHIM 
                    FROM PHIM
                    WHERE TENPHIM LIKE @SearchQuery 
                    ORDER BY TENPHIM";

                string searchQuery = "%" + txbSearchMovie.Text + "%";
                SqlParameter[] parameters = {
                    new SqlParameter("@SearchQuery", searchQuery)
                };

                DataTable dt = db.ReadData(query, parameters);

                dgvMM.Rows.Clear();

                if (dt != null && dt.Rows.Count > 0)
                {
                    foreach (DataRow row in dt.Rows)
                    {
                        int maPhim = Convert.ToInt32(row["MAPHIM"]);
                        string movieName = row["TENPHIM"].ToString();
                        string genre = row["THELOAIPHIM"].ToString();
                        string ageRating = row["GIOIHANTUOI"].ToString();
                        string duration = row["THOILUONGPHIM"].ToString();

                        // Sửa lỗi crash: Phải thêm 6 giá trị cho 6 cột
                        int rowIndex = dgvMM.Rows.Add(movieName, genre, ageRating, duration, "Edit", "Delete");

                        // Lưu ID vào Tag
                        dgvMM.Rows[rowIndex].Tag = maPhim;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi tải dữ liệu phim: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Hàm trung tâm để mở Form Add/Edit
        /// </summary>
        private void OpenMovieForm(int? movieID)
        {
            AddNewMovie addMovieUC = new AddNewMovie();

            if (movieID.HasValue)
            {
                addMovieUC.MovieIDToEdit = movieID.Value;
            }

            Form form = new Form
            {
                Text = movieID.HasValue ? "Edit Movie" : "Add New Movie",
                StartPosition = FormStartPosition.CenterParent,
                ClientSize = addMovieUC.Size,
                FormBorderStyle = FormBorderStyle.FixedDialog,
                MaximizeBox = false,
                MinimizeBox = false
            };

            addMovieUC.Dock = DockStyle.Fill;
            form.Controls.Add(addMovieUC);

            // Dùng ShowDialog() để "chờ" form này đóng
            form.ShowDialog();

            // Sau khi form đóng, mới chạy LoadMovies()
            LoadMovies();
        }

        /// <summary>
        /// Xử lý logic cho nút "Add New Movie" (Sửa lại)
        /// </summary>
        private void btnAdd_Click(object sender, EventArgs e)
        {
            OpenMovieForm(null);
        }

        /// <summary>
        /// Xử lý logic Tìm kiếm
        /// </summary>
        private void txbSearchMovie_TextChanged(object sender, EventArgs e)
        {
            LoadMovies();
        }

        #region Xử lý click trong DataGridView (Edit & Delete)

        /// <summary>
        /// Xử lý khi click vào nút "Edit" hoặc "Delete" trong grid
        /// </summary>
        private void dgvMM_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            string colName = dgvMM.Columns[e.ColumnIndex].Name;

            // Lấy ID từ Tag
            int movieID = (int)dgvMM.Rows[e.RowIndex].Tag;

            if (colName == "editBtn")
            {
                OpenMovieForm(movieID);
            }
            else if (colName == "delBtn")
            {
                ExecuteDelete(movieID);
            }
        }

        /// <summary>
        /// Hàm xử lý logic Xóa một phim
        /// </summary>
        private void ExecuteDelete(int movieID)
        {
            string message = "Bạn có chắc chắn muốn xóa phim này không? \n(Toàn bộ suất chiếu của phim này cũng sẽ bị xóa)";
            DialogResult result = MessageBox.Show(message, "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (result == DialogResult.Yes)
            {
                try
                {
                    SqlParameter param = new SqlParameter("@MaPhim", movieID);

                    string queryDeleteShows = "DELETE FROM SUATCHIEU WHERE MAPHIM = @MaPhim";
                    db.ChangeData(queryDeleteShows, new SqlParameter[] { param });

                    string queryDeleteMovie = "DELETE FROM PHIM WHERE MAPHIM = @MaPhim";
                    param = new SqlParameter("@MaPhim", movieID);

                    if (db.ChangeData(queryDeleteMovie, new SqlParameter[] { param }))
                    {
                        MessageBox.Show("Đã xóa phim thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LoadMovies();
                    }
                    else
                    {
                        MessageBox.Show("Xóa phim thất bại.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi khi xóa phim: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        #endregion

        private void kryptonButton1_Click(object sender, EventArgs e) { }
        private void kryptonDataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e) { }
        private void kryptonButton2_Click(object sender, EventArgs e) { }
        private void addNewMovie2_Load(object sender, EventArgs e) { }
    }
}
