using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using Cinema_management.DAL;
using Cinema_management.MessageboxCustom.Utils;
using Cinema_management.MessageboxCustom;

namespace Cinema_management
{
    public partial class UCMovies1 : UserControl
    {
        private Database db = new Database();

        public UCMovies1()
        {
            InitializeComponent();
        }

        // Sự kiện Load của UserControl (tương tự Form_Load)
        private void UCMovies1_Load(object sender, EventArgs e)
        {
            dtpSearchDate.ShowCheckBox = true;
            dtpSearchDate.Checked = false;
            LoadMovies();
        }

        // Hàm tải danh sách phim lên DataGridView
        private void LoadMovies()
        {
            try
            {
                string query = "SELECT MAPHIM, TENPHIM, THELOAIPHIM, GIOIHANTUOI, THOILUONGPHIM FROM PHIM WHERE 1=1"; // Thêm WHERE 1=1 để dễ nối chuỗi

                // Lọc theo tên
                if (!string.IsNullOrWhiteSpace(txtSearchMovie.Text))
                {
                    query += " AND TENPHIM LIKE @TenPhim";
                }

                // Lọc theo ngày 
                if (dtpSearchDate.Checked)
                {
                    // Dùng CAST để chỉ so sánh ngày, bỏ qua giờ phút giây
                    query += " AND CAST(NGAYPHATHANH AS DATE) = @NgayPhatHanh";
                }

                // Tạo tham số (Luôn tạo đủ để tránh lỗi thiếu tham số, dù câu query có dùng hay không)
                SqlParameter[] parameters = {
            new SqlParameter("@TenPhim", "%" + txtSearchMovie.Text + "%"),
            new SqlParameter("@NgayPhatHanh", dtpSearchDate.Value.Date)
        };

                // Gọi database
                DataTable dt = db.ReadData(query, parameters);
                dgvMM.DataSource = dt;

                // Chỉnh giao diện cột
                if (dgvMM.Columns.Contains("btnEdit"))
                    dgvMM.Columns["btnEdit"].DisplayIndex = dgvMM.Columns.Count - 2;

                if (dgvMM.Columns.Contains("btnDelete"))
                    dgvMM.Columns["btnDelete"].DisplayIndex = dgvMM.Columns.Count - 1;

                // Ẩn cột MAPHIM 
                if (dgvMM.Columns.Contains("MAPHIM")) dgvMM.Columns["MAPHIM"].Visible = false;
            }
            catch (Exception ex)
            {
                Alert.Show("Lỗi tải dữ liệu!", MessagboxCustom.AlertMessagebox.AlertType.Error);
            }
           
        }

        private void btnAddMovie_Click(object sender, EventArgs e)
        {
            // Mở form AddUpdateMovieForm ở chế độ THÊM MỚI (truyền null)
            AddUpdateMovieForm frm = new AddUpdateMovieForm(null);

            // Nếu form con trả về OK (đã lưu thành công) thì tải lại danh sách
            if (frm.ShowDialog() == DialogResult.OK)
            {
                LoadMovies();
            }
        }

        // Sự kiện click vào nút trong DataGridView (Sửa/Xóa)
        private void dgvMM_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Kiểm tra click hợp lệ (không click vào tiêu đề cột và dòng phải tồn tại)
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                // Lấy tên cột vừa được click
                string colName = dgvMM.Columns[e.ColumnIndex].Name;

                // Lấy MAPHIM của dòng hiện tại (Giả sử cột chứa ID có tên là "MAPHIM" hoặc index 0)
                string maPhim = dgvMM.Rows[e.RowIndex].Cells["MAPHIM"].Value.ToString();

                // --- XỬ LÝ NÚT SỬA (btnEdit) ---
                if (colName == "btnEdit")
                {
                    // Mở form AddUpdateMovieForm ở chế độ CẬP NHẬT (truyền maPhim)
                    AddUpdateMovieForm frm = new AddUpdateMovieForm(maPhim);

                    if (frm.ShowDialog() == DialogResult.OK)
                    {
                        LoadMovies(); // Tải lại danh sách sau khi sửa
                    }
                }
                // --- XỬ LÝ NÚT XÓA (btnDelete) ---
                else if (colName == "btnDelete")
                {
                    DialogResult result = Alert.ShowWarning($"Bạn chắc chắn muốn xóa phim này? Thao tác này sẽ xóa tất cả suất chiếu liên quan");
                    if (result == DialogResult.Yes)
                    {
                        // 1. Định nghĩa các truy vấn theo thứ tự xóa: Xóa con (SUATCHIEU) trước, xóa cha (PHIM) sau
                        string deleteSuatChieuQuery = "DELETE FROM dbo.SUATCHIEU WHERE MAPHIM = @MaPhim";
                        string deletePhimQuery = "DELETE FROM dbo.PHIM WHERE MAPHIM = @MaPhim";

                        string[] queries = { deleteSuatChieuQuery, deletePhimQuery };

                        // 2. Định nghĩa tham số (@MaPhim) cho từng lệnh SQL
                        SqlParameter paramSuatChieu = new SqlParameter("@MaPhim", maPhim);
                        SqlParameter paramPhim = new SqlParameter("@MaPhim", maPhim);

                        // Chuẩn bị mảng tham số cho ExecuteTransaction
                        SqlParameter[][] allParameters =
                        {
                            new SqlParameter[] { paramSuatChieu }, // Tham số cho DELETE SUATCHIEU
                            new SqlParameter[] { paramPhim }       // Tham số cho DELETE PHIM
                        };

                        try
                        {
                            if (db.ExecuteTransaction(queries, allParameters))
                            {
                                Alert.Show("Xóa phim và các suất chiếu liên quan thành công!", MessagboxCustom.AlertMessagebox.AlertType.Success);
                                LoadMovies();
                            }
                        }
                        catch (Exception ex)
                        {
                            // Bắt lỗi Transaction từ lớp Database. Nếu có lỗi, dữ liệu đã được Rollback.
                            Alert.Show("Xóa thất bại! Dữ liệu không bị thay đổi!", MessagboxCustom.AlertMessagebox.AlertType.Error);
                        }
                    }
                }
            }
        }

        // load lại khi tick vào ô checkbox trong SearchDate và khi nhập chữ vô SearchMovie
        private void dtpSearchDate_ValueChanged(object sender, EventArgs e)
        {
            LoadMovies();
        }

        private void txtSearchMovie_TextChanged(object sender, EventArgs e)
        {
            LoadMovies();
        }
    }
}