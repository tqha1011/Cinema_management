using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Krypton.Toolkit;
using Cinema_management.DAL; // Thêm thư viện để truy cập Database
using System.Data.SqlClient; // Thêm thư viện SQL

namespace Cinema_management
{
    public partial class UCShowtimes : UserControl
    {
        public UCShowtimes()
        {
            InitializeComponent();
        }

        // 1. Tạo phương thức mới để tải dữ liệu
        private void LoadShowtimesData()
        {
            try
            {
                Database db = new Database();

                // 2. Câu truy vấn SQL để lấy dữ liệu
                // Câu lệnh này JOIN các bảng để lấy thông tin Tên phim, Loại phòng, Thời lượng và Thời gian chiếu
                string query = @"
                    SELECT 
                        p.TENPHIM AS MovieName, 
                        lp.LOAIPHONG AS RoomType, 
                        p.THOILUONGPHIM AS Duration, 
                        sc.THOIGIANCHIEU AS Showtime
                    FROM 
                        SUATCHIEU sc
                    JOIN 
                        PHIM p ON sc.MAPHIM = p.MAPHIM
                    JOIN 
                        PHONGCHIEU pc ON sc.MAPHONG = pc.MAPHONG
                    JOIN 
                        LOAIPHONG lp ON pc.MALOAIPHONG = lp.MALOAIPHONG
                    ORDER BY 
                        sc.THOIGIANCHIEU;
                "; //

                // 3. Thực thi truy vấn và lấy kết quả
                DataTable dt = db.ReadData(query);

                // 4. Xóa các hàng cũ trong DataGridView
                dgvShows.Rows.Clear();

                // 5. Thêm dữ liệu từ DataTable vào DataGridView
                if (dt != null && dt.Rows.Count > 0)
                {
                    foreach (DataRow row in dt.Rows)
                    {
                        string movieName = row["MovieName"].ToString();
                        string roomType = row["RoomType"].ToString(); // Đây là LOAIPHONG (vd: '2D', 'Standard')
                        string duration = row["Duration"].ToString();
                        DateTime showtime = Convert.ToDateTime(row["Showtime"]); // Lấy giá trị DateTime

                        // Thêm hàng mới
                        // Chúng ta truyền đối tượng 'showtime' (kiểu DateTime) trực tiếp vào cột thứ 4
                        // vì nó là KryptonDataGridViewDateTimePickerColumn
                        dgvShows.Rows.Add(movieName, roomType, duration, showtime);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi tải dữ liệu suất chiếu: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // 6. Sửa sự kiện Load để gọi phương thức tải dữ liệu
        private void UCShowtimes_Load(object sender, EventArgs e)
        {
            // Xóa dòng code dữ liệu giả của bạn
            // dgvShows.Rows.Add("Bo gia", "2d", "120", "21:00");

            // Gọi phương thức tải dữ liệu thật
            LoadShowtimesData();
        }

        private void lvShowtimes_Click(object sender, EventArgs e)
        {

        }

        private void lblShowtimes_Click(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            // Tạo UserControl AddShowtime
            AddShowtime addShowtime = new AddShowtime();

            // Tạo một Form mới để chứa UserControl
            Form form = new Form
            {
                Text = "Add Showtime",
                StartPosition = FormStartPosition.CenterParent,

                // --- SỬA LỖI TẠI ĐÂY ---
                // Xóa AutoSize và đặt ClientSize cố định
                // Lấy kích thước từ file AddShowtime.Designer.cs
                ClientSize = new System.Drawing.Size(1067, 562),
                FormBorderStyle = FormBorderStyle.FixedDialog, // Tùy chọn: Chống người dùng thay đổi kích thước
                MaximizeBox = false,
                MinimizeBox = false
            };

            // Đặt DockStyle.Fill cho UserControl
            addShowtime.Dock = DockStyle.Fill;
            form.Controls.Add(addShowtime);

            // Hiển thị form
            form.ShowDialog();

            // Sau khi form đóng, tải lại dữ liệu
            LoadShowtimesData();
        }
    }
}