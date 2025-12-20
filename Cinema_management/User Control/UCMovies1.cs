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
                string query;
                if (ckbShowDeleted.Checked)
                    query = "SELECT MAPHIM, TENPHIM, THELOAIPHIM, GIOIHANTUOI, THOILUONGPHIM, TRANGTHAI, NGAYPHATHANH FROM PHIM WHERE TRANGTHAI = 0";
                else
                    query = "SELECT MAPHIM, TENPHIM, THELOAIPHIM, GIOIHANTUOI, THOILUONGPHIM, TRANGTHAI, NGAYPHATHANH FROM PHIM WHERE TRANGTHAI = 1";

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

                SqlParameter[] parameters = {
                new SqlParameter("@TenPhim", "%" + txtSearchMovie.Text + "%"),
                new SqlParameter("@NgayPhatHanh", dtpSearchDate.Value.Date)
                };

                // Gọi database
                DataTable dt = db.ReadData(query, parameters);
                dgvMM.DataSource = dt;

                if (dgvMM.Columns.Contains("btnEdit"))
                    dgvMM.Columns["btnEdit"].DisplayIndex = dgvMM.Columns.Count - 2;

                if (dgvMM.Columns.Contains("btnDelete"))
                    dgvMM.Columns["btnDelete"].DisplayIndex = dgvMM.Columns.Count - 1;

                if (dgvMM.Columns.Contains("MAPHIM")) dgvMM.Columns["MAPHIM"].DisplayIndex = 0;
            }
            catch (Exception ex)
            {
                Alert.Show("Lỗi tải dữ liệu!", MessagboxCustom.AlertMessagebox.AlertType.Error);
            }

        }

        private void btnAddMovie_Click(object sender, EventArgs e)
        {
            AddUpdateMovieForm frm = new AddUpdateMovieForm(null);
            if (frm.ShowDialog() == DialogResult.OK)
            {
                LoadMovies();
            }
        }

        private void dgvMM_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
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

        private void ckbShowDeleted_CheckedChanged(object sender, EventArgs e)
        {
            LoadMovies();
        }
        
        private string GetSelectedMovieID()
        {
            if (dgvMM.SelectedRows.Count > 0)
            {
                return dgvMM.SelectedRows[0].Cells["MAPHIM"].Value.ToString();
            }
            if (dgvMM.CurrentRow != null && dgvMM.CurrentRow.Index >= 0)
            {
                return dgvMM.CurrentRow.Cells["MAPHIM"].Value.ToString();
            }
            return null;
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            string maPhim = GetSelectedMovieID();

            if (string.IsNullOrEmpty(maPhim))
            {
                Alert.Show("Vui lòng chọn một phim để sửa!", MessagboxCustom.AlertMessagebox.AlertType.Error);
                return;
            }
            AddUpdateMovieForm frm = new AddUpdateMovieForm(maPhim);
            if (frm.ShowDialog() == DialogResult.OK)
                LoadMovies();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            string maPhim = GetSelectedMovieID();

            if (string.IsNullOrEmpty(maPhim))
            {
                Alert.Show("Vui lòng chọn một phim để xóa!", MessagboxCustom.AlertMessagebox.AlertType.Error);
                return;
            }
            DialogResult result = Alert.ShowWarning($"Bạn chắc chắn muốn ngừng chiếu phim này?");
            if (result == DialogResult.OK)
            {
                string updatePhim = "UPDATE PHIM SET TRANGTHAI = 0 WHERE MAPHIM = @MaPhim";
                string deleteSC = "DELETE FROM SUATCHIEU WHERE MAPHIM = @MaPhim AND THOIGIANCHIEU > GETDATE()";
                string[] queries = { updatePhim, deleteSC };
                SqlParameter[][] allParameters =
                {
                            new SqlParameter[] { new SqlParameter("@MaPhim", maPhim) },
                            new SqlParameter[] { new SqlParameter("@MaPhim", maPhim) }
                        };
                try
                {
                    if (db.ExecuteTransaction(queries, allParameters))
                    {
                        Alert.Show("Đã ngừng chiếu phim và hủy các suất chiếu tương lai thành công!", MessagboxCustom.AlertMessagebox.AlertType.Success);
                        LoadMovies();
                    }
                    else
                    {
                        // Hàm ExecuteTransaction của bạn có thể ném Exception. Nếu nó trả về FALSE mà không ném Exception
                        Alert.Show("Ngừng chiếu thất bại! Không có dữ liệu nào được thay đổi hoặc lỗi chưa được xử lý.", MessagboxCustom.AlertMessagebox.AlertType.Error);
                    }
                }
                catch (Exception ex)
                {
                    Alert.Show("Lỗi thực thi Transaction: " + ex.Message, MessagboxCustom.AlertMessagebox.AlertType.Error);
                }
            }
        }
    }
}