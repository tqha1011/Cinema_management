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
using System.Globalization;

namespace Cinema_management
{
    public partial class AddShowtime : UserControl
    {
        public int? ShowtimeIDToEdit { get; set; } = null;
        private Database db;

        public AddShowtime()
        {
            InitializeComponent();
            db = new Database();
            this.Load += new System.EventHandler(this.AddShowtime_Load);
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            this.cbbGenre.SelectedIndexChanged += new System.EventHandler(this.cbbGenre_SelectedIndexChanged);
        }

        private void kryptonLabel2_Click(object sender, EventArgs e) { }

        /// <summary>
        /// Chạy khi UserControl được tải: Cài đặt giao diện và tải ComboBoxes.
        /// </summary>
        private void AddShowtime_Load(object sender, EventArgs e)
        {
            LoadMovieComboBox();
            LoadRoomComboBox();

            kryptonDateTimePicker1.Format = DateTimePickerFormat.Custom;
            kryptonDateTimePicker1.CustomFormat = "dd/MM/yyyy";
            kryptonDateTimePicker2.Format = DateTimePickerFormat.Custom;
            kryptonDateTimePicker2.CustomFormat = "HH:mm";
            kryptonDateTimePicker2.ShowUpDown = true;
            kryptonDateTimePicker3.Format = DateTimePickerFormat.Custom;
            kryptonDateTimePicker3.CustomFormat = "dd/MM/yyyy";

            if (ShowtimeIDToEdit.HasValue)
            {
                kryptonLabel1.Text = "Edit Showtime";
                btnSave.Text = "Update Showtime";
                kryptonDateTimePicker1.Enabled = false;
                kryptonDateTimePicker3.Enabled = false;
                cbbMovieName.Enabled = false;
                LoadShowtimeForEditing(ShowtimeIDToEdit.Value);
            }
            else
            {
                kryptonLabel1.Text = "Add Showtime";
                btnSave.Text = "Save Showtime";
                kryptonDateTimePicker2.Value = DateTime.Now.Date.AddHours(19);
                kryptonDateTimePicker3.Value = kryptonDateTimePicker1.Value.AddDays(7);
            }
        }

        /// <summary>
        /// Tải dữ liệu của một suất chiếu cụ thể lên form khi ở chế độ "Edit".
        /// </summary>
        private void LoadShowtimeForEditing(int maSuatChieu)
        {
            try
            {
                string query = @"
                    SELECT sc.MAPHIM, pc.TENPHONG, sc.THOIGIANCHIEU
                    FROM SUATCHIEU sc
                    JOIN PHONGCHIEU pc ON sc.MAPHONG = pc.MAPHONG
                    WHERE sc.MASUATCHIEU = @MaSuatChieu";

                SqlParameter[] parameters = { new SqlParameter("@MaSuatChieu", maSuatChieu) };
                DataTable dt = db.ReadData(query, parameters);

                if (dt != null && dt.Rows.Count > 0)
                {
                    DataRow row = dt.Rows[0];
                    DateTime thoiGianChieu = Convert.ToDateTime(row["THOIGIANCHIEU"]);
                    cbbMovieName.SelectedValue = row["MAPHIM"];
                    cbbGenre.SelectedValue = row["TENPHONG"];
                    kryptonDateTimePicker1.Value = thoiGianChieu.Date;
                    kryptonDateTimePicker3.Value = thoiGianChieu.Date;
                    kryptonDateTimePicker2.Value = thoiGianChieu;
                    UpdateTicketPrice();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi tải dữ liệu suất chiếu: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Tải danh sách phim (TENPHIM, MAPHIM) từ CSDL vào ComboBox.
        /// </summary>
        private void LoadMovieComboBox()
        {
            try
            {
                string query = "SELECT MAPHIM, TENPHIM FROM PHIM ORDER BY TENPHIM";
                DataTable dt = db.ReadData(query);
                if (dt != null)
                {
                    cbbMovieName.DataSource = dt;
                    cbbMovieName.DisplayMember = "TENPHIM";
                    cbbMovieName.ValueMember = "MAPHIM";
                    cbbMovieName.DropDownStyle = ComboBoxStyle.DropDownList;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi tải danh sách phim: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Tải danh sách phòng (TENPHONG) đang hoạt động từ CSDL vào ComboBox.
        /// </summary>
        private void LoadRoomComboBox()
        {
            try
            {
                string query = "SELECT TENPHONG FROM PHONGCHIEU WHERE TRANGTHAIPHONG = 1 ORDER BY TENPHONG";
                DataTable dt = db.ReadData(query);
                if (dt != null)
                {
                    cbbGenre.DataSource = dt;
                    cbbGenre.DisplayMember = "TENPHONG";
                    cbbGenre.ValueMember = "TENPHONG";
                    cbbGenre.DropDownStyle = ComboBoxStyle.DropDownList;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi tải danh sách phòng: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Kích hoạt khi thay đổi phòng, gọi hàm UpdateTicketPrice.
        /// </summary>
        private void cbbGenre_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateTicketPrice();
        }

        /// <summary>
        /// Tự động truy vấn và điền giá vé cơ bản vào TextBox khi phòng được chọn.
        /// </summary>
        private void UpdateTicketPrice()
        {
            try
            {
                if (cbbGenre.SelectedValue == null) return;
                string roomName = cbbGenre.SelectedValue.ToString();
                string query = @"
                    SELECT lp.GIAVECOBAN 
                    FROM LOAIPHONG lp
                    JOIN PHONGCHIEU pc ON lp.MALOAIPHONG = pc.MALOAIPHONG
                    WHERE pc.TENPHONG = @TenPhong";

                SqlParameter[] parameters = { new SqlParameter("@TenPhong", roomName) };
                DataTable dt = db.ReadData(query, parameters);

                if (dt != null && dt.Rows.Count > 0)
                {
                    decimal price = Convert.ToDecimal(dt.Rows[0]["GIAVECOBAN"]);
                    kryptonTextBox1.Text = price.ToString("N0", CultureInfo.GetCultureInfo("vi-VN")) + " đ";
                }
                else { kryptonTextBox1.Text = "0 đ"; }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi lấy giá vé: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                kryptonTextBox1.Text = "Lỗi";
            }
        }

        /// <summary>
        /// Kiểm tra xem một suất chiếu có bị trùng lịch trong phòng hay không.
        /// </summary>
        private bool IsShowtimeOverlapping(int maPhong, DateTime newStartTime, int newMovieID, int? showtimeIDToExclude)
        {
            try
            {
                string durationQuery = "SELECT THOILUONGPHIM FROM PHIM WHERE MAPHIM = @MaPhim";
                SqlParameter[] durationParams = { new SqlParameter("@MaPhim", newMovieID) };
                DataTable dtDuration = db.ReadData(durationQuery, durationParams);

                if (dtDuration == null || dtDuration.Rows.Count == 0)
                {
                    MessageBox.Show("Không tìm thấy thời lượng cho phim đã chọn.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return true;
                }
                int newDuration = Convert.ToInt32(dtDuration.Rows[0]["THOILUONGPHIM"]);
                DateTime newEndTime = newStartTime.AddMinutes(newDuration);

                string overlapQuery = @"
                    SELECT COUNT(sc.MASUATCHIEU)
                    FROM SUATCHIEU sc
                    JOIN PHIM p ON sc.MAPHIM = p.MAPHIM
                    WHERE 
                        sc.MAPHONG = @MaPhong
                        AND (@ShowtimeIDToExclude IS NULL OR sc.MASUATCHIEU != @ShowtimeIDToExclude)
                        AND (
                            @NewStartTime < DATEADD(minute, p.THOILUONGPHIM, sc.THOIGIANCHIEU) 
                            AND
                            @NewEndTime > sc.THOIGIANCHIEU
                        )";

                SqlParameter[] overlapParams = {
                    new SqlParameter("@MaPhong", maPhong),
                    new SqlParameter("@NewStartTime", newStartTime),
                    new SqlParameter("@NewEndTime", newEndTime),
                    new SqlParameter("@ShowtimeIDToExclude", (object)showtimeIDToExclude ?? DBNull.Value)
                };

                DataTable dtOverlap = db.ReadData(overlapQuery, overlapParams);
                int conflictCount = Convert.ToInt32(dtOverlap.Rows[0][0]);

                return conflictCount > 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi kiểm tra trùng lặp: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return true;
            }
        }

        /// <summary>
        /// Nút "Save/Update" chính, quyết định gọi ExecuteUpdate hoặc ExecuteInsert.
        /// </summary>
        private void btnSave_Click(object sender, EventArgs e)
        {
            if (ShowtimeIDToEdit.HasValue)
            {
                ExecuteUpdate(ShowtimeIDToEdit.Value);
            }
            else
            {
                ExecuteInsert();
            }
        }

        /// <summary>
        /// Logic Cập nhật (Update) một suất chiếu (chế độ Edit).
        /// </summary>
        private void ExecuteUpdate(int maSuatChieu)
        {
            try
            {
                if (cbbMovieName.SelectedValue == null || cbbGenre.SelectedValue == null) return;

                int maPhim = Convert.ToInt32(cbbMovieName.SelectedValue);
                string roomName = cbbGenre.SelectedValue.ToString();
                DateTime datePart = kryptonDateTimePicker1.Value.Date;
                TimeSpan timePart = kryptonDateTimePicker2.Value.TimeOfDay;
                DateTime newFullShowtime = datePart + timePart;

                int maPhong = Convert.ToInt32(db.ReadData("SELECT MAPHONG FROM PHONGCHIEU WHERE TENPHONG = @TenPhong",
                                new SqlParameter[] { new SqlParameter("@TenPhong", roomName) }).Rows[0][0]);

                if (IsShowtimeOverlapping(maPhong, newFullShowtime, maPhim, maSuatChieu))
                {
                    MessageBox.Show("Lỗi: Suất chiếu này bị trùng lịch với một suất chiếu khác trong phòng!", "Không thể cập nhật", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                string query = @"
                    UPDATE SUATCHIEU 
                    SET THOIGIANCHIEU = @ThoiGianChieu, MAPHONG = @MaPhong
                    WHERE MASUATCHIEU = @MaSuatChieu";

                SqlParameter[] parameters = {
                    new SqlParameter("@ThoiGianChieu", newFullShowtime),
                    new SqlParameter("@MaPhong", maPhong),
                    new SqlParameter("@MaSuatChieu", maSuatChieu)
                };

                if (db.ChangeData(query, parameters))
                {
                    MessageBox.Show("Cập nhật suất chiếu thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    if (this.ParentForm != null) this.ParentForm.Close();
                }
                else
                {
                    MessageBox.Show("Cập nhật thất bại.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi cập nhật: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Logic Thêm mới (Insert) một hoặc nhiều suất chiếu (chế độ Add).
        /// </summary>
        private void ExecuteInsert()
        {
            try
            {
                if (cbbMovieName.SelectedValue == null || cbbGenre.SelectedValue == null)
                {
                    MessageBox.Show("Vui lòng chọn đầy đủ phim và phòng.", "Thiếu thông tin", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                string roomName = cbbGenre.Text;
                TimeSpan timePart = kryptonDateTimePicker2.Value.TimeOfDay;
                int maPhim = Convert.ToInt32(cbbMovieName.SelectedValue);
                int maPhong = Convert.ToInt32(db.ReadData("SELECT MAPHONG FROM PHONGCHIEU WHERE TENPHONG = @TenPhong",
                                new SqlParameter[] { new SqlParameter("@TenPhong", roomName) }).Rows[0][0]);

                DateTime startDate = kryptonDateTimePicker1.Value.Date;
                DateTime endDate = kryptonDateTimePicker3.Value.Date;

                if (endDate < startDate)
                {
                    MessageBox.Show("Ngày kết thúc không thể nhỏ hơn ngày bắt đầu.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                int successCount = 0;
                int failCount = 0;
                string failMessages = "";

                for (DateTime date = startDate; date <= endDate; date = date.AddDays(1))
                {
                    DateTime fullShowtime = date + timePart;

                    if (IsShowtimeOverlapping(maPhong, fullShowtime, maPhim, null))
                    {
                        failCount++;
                        failMessages += $"- Ngày {date.ToShortDateString()} (Bị trùng lịch)\n";
                        continue;
                    }

                    string insertQuery = "INSERT INTO SUATCHIEU (MAPHIM, MAPHONG, THOIGIANCHIEU) VALUES (@MaPhim, @MaPhong, @ThoiGianChieu)";
                    SqlParameter[] insertParams = {
                        new SqlParameter("@MaPhim", maPhim),
                        new SqlParameter("@MaPhong", maPhong),
                        new SqlParameter("@ThoiGianChieu", fullShowtime)
                    };

                    if (db.ChangeData(insertQuery, insertParams))
                    {
                        successCount++;
                    }
                    else
                    {
                        failCount++;
                        failMessages += $"- Ngày {date.ToShortDateString()} (Lỗi CSDL)\n";
                    }
                }

                string resultMessage = $"Thêm thành công: {successCount} suất chiếu.\n";
                if (failCount > 0)
                {
                    resultMessage += $"Thêm thất bại: {failCount} suất chiếu.\nChi tiết:\n{failMessages}";
                }

                MessageBox.Show(resultMessage, "Tổng kết", MessageBoxButtons.OK, MessageBoxIcon.Information);

                if (successCount > 0 && this.ParentForm != null)
                {
                    this.ParentForm.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Đã xảy ra lỗi nghiêm trọng: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Đóng form popup.
        /// </summary>
        private void btnCancel_Click(object sender, EventArgs e)
        {
            if (this.ParentForm != null)
            {
                this.ParentForm.Close();
            }
        }
    }
}