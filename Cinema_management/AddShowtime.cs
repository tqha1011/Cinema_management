using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Cinema_management.DAL;
using System.Data.SqlClient;

namespace Cinema_management
{
    public partial class AddShowtime : UserControl
    {
        public AddShowtime()
        {
            InitializeComponent();

            // XÓA 2 DÒNG NÀY:
            // this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
        }

        private void kryptonLabel2_Click(object sender, EventArgs e)
        {

        }

        // Đảm bảo rằng bạn có 2 phương thức này (được tạo tự động khi bạn double-click)
        // Nếu chưa có, bạn hãy double-click vào nút Save và Cancel trong Designer
        // và dán nội dung logic vào.

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                Database db = new Database();

                // 1. Lấy thông tin từ các control
                string movieName = txbMovieName.Text;
                string roomName = cbbGenre.Text; // Đây là ComboBox chọn phòng
                DateTime datePart = kryptonDateTimePicker1.Value.Date; // Lấy ngày
                TimeSpan timePart = kryptonDateTimePicker2.Value.TimeOfDay; // Lấy giờ

                // Kết hợp ngày và giờ
                DateTime fullShowtime = datePart + timePart;

                // 2. Lấy MAPHIM từ TENPHIM
                string phimQuery = "SELECT MAPHIM FROM PHIM WHERE TENPHIM = @TenPhim";
                SqlParameter[] phimParams = { new SqlParameter("@TenPhim", movieName) };
                DataTable phimDt = db.ReadData(phimQuery, phimParams);

                if (phimDt == null || phimDt.Rows.Count == 0)
                {
                    MessageBox.Show("Tên phim không tồn tại trong cơ sở dữ liệu!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                int maPhim = Convert.ToInt32(phimDt.Rows[0]["MAPHIM"]);

                // 3. Lấy MAPHONG từ TENPHONG
                string phongQuery = "SELECT MAPHONG FROM PHONGCHIEU WHERE TENPHONG = @TenPhong";
                SqlParameter[] phongParams = { new SqlParameter("@TenPhong", roomName) };
                DataTable phongDt = db.ReadData(phongQuery, phongParams);

                if (phongDt == null || phongDt.Rows.Count == 0)
                {
                    MessageBox.Show("Tên phòng không tồn tại trong cơ sở dữ liệu!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                int maPhong = Convert.ToInt32(phongDt.Rows[0]["MAPHONG"]);

                // 4. Thêm suất chiếu mới vào bảng SUATCHIEU
                string insertQuery = "INSERT INTO SUATCHIEU (MAPHIM, MAPHONG, THOIGIANCHIEU) VALUES (@MaPhim, @MaPhong, @ThoiGianChieu)";
                SqlParameter[] insertParams = {
                    new SqlParameter("@MaPhim", maPhim),
                    new SqlParameter("@MaPhong", maPhong),
                    new SqlParameter("@ThoiGianChieu", fullShowtime)
                };

                bool success = db.ChangeData(insertQuery, insertParams);

                // 5. Thông báo kết quả và đóng form
                if (success)
                {
                    MessageBox.Show("Thêm suất chiếu mới thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    // Đóng form popup
                    if (this.ParentForm != null)
                    {
                        this.ParentForm.Close();
                    }
                }
                else
                {
                    MessageBox.Show("Thêm suất chiếu thất bại! (Có thể do trùng lặp)", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Đã xảy ra lỗi: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            // Đóng form popup
            if (this.ParentForm != null)
            {
                this.ParentForm.Close();
            }
        }

    }
}