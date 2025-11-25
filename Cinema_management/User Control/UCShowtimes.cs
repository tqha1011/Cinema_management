using Cinema_management.DAL;
using Cinema_management.MessageboxCustom.Utils;
using Krypton.Toolkit;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cinema_management
{
    public partial class UCShowtimes : UserControl
    {
        private string currentRoomFilter = "All Showtimes";

        public UCShowtimes()
        {
            InitializeComponent();
            this.dgvShows.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvShows_CellContentClick);
        }

        /// <summary>
        /// Chạy khi UserControl được tải: Cài đặt giao diện và tải dữ liệu lần đầu.
        /// </summary>
        private void UCShowtimes_Load(object sender, EventArgs e)
        {
            //btnUpdate.Visible = false;
            btnDelete.Visible = false;

            if (dgvShows.Columns.Contains("Type"))
            {
                dgvShows.Columns["Type"].HeaderText = "Room";
                dgvShows.Columns["Type"].Name = "Room";
            }

            KryptonDataGridViewCheckBoxColumn chkColumn = new KryptonDataGridViewCheckBoxColumn();
            chkColumn.HeaderText = "";
            chkColumn.Name = "chkSelect";
            chkColumn.Width = 50;
            chkColumn.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            chkColumn.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            if (!dgvShows.Columns.Contains("chkSelect"))
            {
                dgvShows.Columns.Insert(0, chkColumn);
            }

            dtpSearchDate.Format = DateTimePickerFormat.Custom;
            dtpSearchDate.CustomFormat = "dd/MM/yyyy";
            dtpSearchDate.Value = DateTime.Today;

            // --- THÊM MỚI: Tải ComboBox lọc phim ---
            LoadMovieFilterComboBox();

            // Gắn sự kiện
            this.dtpSearchDate.ValueChanged += new System.EventHandler(this.Filter_Changed);
            this.cbbMovieFilter.SelectedIndexChanged += new System.EventHandler(this.Filter_Changed); // THÊM MỚI
            this.kryptonButton1.Click += new System.EventHandler(this.RoomFilter_Click);
            this.kryptonButton2.Click += new System.EventHandler(this.RoomFilter_Click);
            this.kryptonButton3.Click += new System.EventHandler(this.RoomFilter_Click);
            this.kryptonButton4.Click += new System.EventHandler(this.RoomFilter_Click);
            this.kryptonButton5.Click += new System.EventHandler(this.RoomFilter_Click);
            this.kryptonButton6.Click += new System.EventHandler(this.RoomFilter_Click);

            this.dgvShows.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvShows_CellValueChanged);
            this.dgvShows.CurrentCellDirtyStateChanged += new System.EventHandler(this.dgvShows_CurrentCellDirtyStateChanged);

            LoadShowtimesData();
        }

        /// <summary>
        /// Tải danh sách phim vào ComboBox lọc ---
        /// </summary>
        private void LoadMovieFilterComboBox()
        {
            try
            {
                Database db = new Database();
                string query = "SELECT TENPHIM FROM PHIM ORDER BY TENPHIM";
                DataTable dt = db.ReadData(query);

                if (dt != null)
                {
                    // Tạo một hàng mới cho "Tất cả phim"
                    DataRow newRow = dt.NewRow();
                    newRow["TENPHIM"] = "Tất cả phim";
                    dt.Rows.InsertAt(newRow, 0); // Thêm vào đầu danh sách

                    cbbMovieFilter.DataSource = dt;
                    cbbMovieFilter.DisplayMember = "TENPHIM";
                    cbbMovieFilter.ValueMember = "TENPHIM";
                    cbbMovieFilter.DropDownStyle = ComboBoxStyle.DropDownList;
                    cbbMovieFilter.SelectedIndex = 0; // Chọn "Tất cả phim" làm mặc định
                }
            }
            catch (Exception)
            {
                Alert.Show("Lỗi khi tải danh sách phim", MessagboxCustom.AlertMessagebox.AlertType.Error);
                //MessageBox.Show("Lỗi khi tải danh sách phim: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Kích hoạt sự kiện CellValueChanged ngay lập tức khi tick/bỏ tick checkbox.
        /// </summary>
        private void dgvShows_CurrentCellDirtyStateChanged(object sender, EventArgs e)
        {
            if (dgvShows.IsCurrentCellDirty)
            {
                if (dgvShows.CurrentCell.OwningColumn.Name == "chkSelect")
                {
                    dgvShows.CommitEdit(DataGridViewDataErrorContexts.Commit);
                }
            }
        }

        /// <summary>
        /// Được gọi khi giá trị ô checkbox thay đổi, dùng để cập nhật nút Delete.
        /// </summary>
        private void dgvShows_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dgvShows.Columns["chkSelect"].Index && e.RowIndex >= 0)
            {
                UpdateDeleteButtonVisibility();
            }
        }

        /// <summary>
        /// Ẩn/Hiện nút Delete dựa trên việc có checkbox nào được chọn hay không.
        /// </summary>
        private void UpdateDeleteButtonVisibility()
        {
            bool anyChecked = false;
            foreach (DataGridViewRow row in dgvShows.Rows)
            {
                if (Convert.ToBoolean(row.Cells["chkSelect"].Value) == true)
                {
                    anyChecked = true;
                    break;
                }
            }
            btnDelete.Visible = anyChecked;
        }

        /// <summary>
        /// Xử lý khi nhấn nút "Edit" (biểu tượng) trong một hàng của bảng.
        /// </summary>
        private void dgvShows_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && dgvShows.Columns[e.ColumnIndex].Name == "editBtn")
            {
                int maSuatChieu = (int)dgvShows.Rows[e.RowIndex].Tag;
                OpenShowtimeForm(maSuatChieu);
            }
        }

        /// <summary>
        /// Hàm trung tâm để mở Form Add/Edit. Nếu 'showtimeID' là null, mở ở chế độ Add.
        /// </summary>
        private void OpenShowtimeForm(int? showtimeID)
        {
            AddShowtime addShowtime = new AddShowtime();

            if (showtimeID.HasValue)
            {
                addShowtime.ShowtimeIDToEdit = showtimeID.Value;
            }

            Form form = new Form
            {
                Text = showtimeID.HasValue ? "Edit Showtime" : "Add Showtime",
                StartPosition = FormStartPosition.CenterParent,
                ClientSize = new System.Drawing.Size(1067, 562),
                FormBorderStyle = FormBorderStyle.FixedDialog,
                MaximizeBox = false,
                MinimizeBox = false
            };

            addShowtime.Dock = DockStyle.Fill;
            form.Controls.Add(addShowtime);

            form.ShowDialog();
            LoadShowtimesData();
        }

        /// <summary>
        /// Tải lại dữ liệu khi thay đổi bộ lọc (ngày hoặc phim).
        /// </summary>
        private void Filter_Changed(object sender, EventArgs e)
        {
            LoadShowtimesData();
        }

        /// <summary>
        /// Tải lại dữ liệu khi thay đổi bộ lọc (phòng).
        /// </summary>
        private void RoomFilter_Click(object sender, EventArgs e)
        {
            KryptonButton clickedButton = sender as KryptonButton;
            if (clickedButton != null)
            {
                currentRoomFilter = clickedButton.Text;
                LoadShowtimesData();
            }
        }

        /// <summary>
        /// Tải dữ liệu suất chiếu từ CSDL lên DataGridView dựa trên bộ lọc.
        /// </summary>
        private void LoadShowtimesData()
        {
            try
            {
                Database db = new Database();
                DateTime selectedDate = dtpSearchDate.Value.Date;

                string query = @"
                    SELECT 
                        sc.MASUATCHIEU, 
                        p.TENPHIM AS MovieName, 
                        pc.TENPHONG AS RoomName, 
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
                    WHERE 
                        CAST(sc.THOIGIANCHIEU AS DATE) = @SelectedDate 
                ";

                List<SqlParameter> parameters = new List<SqlParameter>
                {
                    new SqlParameter("@SelectedDate", selectedDate)
                };

                if (currentRoomFilter != "All Showtimes")
                {
                    query += " AND pc.TENPHONG = @RoomName";
                    parameters.Add(new SqlParameter("@RoomName", currentRoomFilter));
                }

                // --- THÊM MỚI: Lọc theo phim ---
                if (cbbMovieFilter.SelectedValue != null && cbbMovieFilter.SelectedValue.ToString() != "Tất cả phim")
                {
                    query += " AND p.TENPHIM = @TenPhim";
                    parameters.Add(new SqlParameter("@TenPhim", cbbMovieFilter.SelectedValue.ToString()));
                }

                query += " ORDER BY pc.TENPHONG, sc.THOIGIANCHIEU";

                DataTable dt = db.ReadData(query, parameters.ToArray());

                DataTable tempTable = dt.Clone();
                foreach (DataRow dr in dt.Rows)
                {
                    tempTable.ImportRow(dr);
                }

                dgvShows.Rows.Clear();

                if (tempTable != null && tempTable.Rows.Count > 0)
                {
                    foreach (DataRow row in tempTable.Rows)
                    {
                        int maSuatChieu = Convert.ToInt32(row["MASUATCHIEU"]);
                        string movieName = row["MovieName"].ToString();
                        string roomName = row["RoomName"].ToString();
                        string duration = row["Duration"].ToString();
                        DateTime showtime = Convert.ToDateTime(row["Showtime"]);

                        int rowIndex = dgvShows.Rows.Add(false, movieName, roomName, duration, showtime.ToString("HH:mm"));
                        dgvShows.Rows[rowIndex].Tag = maSuatChieu;
                    }
                }

                MergeShowtimeCells(tempTable);
                UpdateDeleteButtonVisibility();
            }
            catch (Exception)
            {
                Alert.Show("Lỗi khi tải dữ liệu suất chiếu", MessagboxCustom.AlertMessagebox.AlertType.Error);
                //MessageBox.Show("Lỗi khi tải dữ liệu suất chiếu: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Gom nhóm trực quan các ô trong bảng (ẩn tên phim/phòng nếu giống hàng trên).
        /// </summary>
        private void MergeShowtimeCells(DataTable dt)
        {
            if (dgvShows.Rows.Count == 0) return;

            for (int i = 0; i < dgvShows.Rows.Count; i++)
            {
                dgvShows.Rows[i].Cells["Movie"].Style.ForeColor = Color.Black;
                dgvShows.Rows[i].Cells["Room"].Style.ForeColor = Color.Black;
                dgvShows.Rows[i].Cells["chkSelect"].Style.Padding = new Padding(0);
                dgvShows.Rows[i].Cells["Movie"].Style.Padding = new Padding(0);
                dgvShows.Rows[i].Cells["Room"].Style.Padding = new Padding(0);
                dgvShows.Rows[i].Cells["Duration"].Style.Padding = new Padding(0);

                if (i == 0) continue;

                string currentMovie = dt.Rows[i]["MovieName"].ToString();
                string prevMovie = dt.Rows[i - 1]["MovieName"].ToString();
                string currentRoom = dt.Rows[i]["RoomName"].ToString();
                string prevRoom = dt.Rows[i - 1]["RoomName"].ToString();

                if (currentMovie == prevMovie && currentRoom == prevRoom)
                {
                    var currentMovieCell = dgvShows.Rows[i].Cells["Movie"];
                    var currentRoomCell = dgvShows.Rows[i].Cells["Room"];

                    currentMovieCell.Value = "";
                    currentMovieCell.Style.ForeColor = currentMovieCell.Style.BackColor;
                    currentRoomCell.Value = "";
                    currentRoomCell.Style.ForeColor = currentRoomCell.Style.BackColor;

                    dgvShows.Rows[i].Cells["chkSelect"].Style.Padding = new Padding(0, -1, 0, 0);
                    currentMovieCell.Style.Padding = new Padding(0, -1, 0, 0);
                    currentRoomCell.Style.Padding = new Padding(0, -1, 0, 0);
                    dgvShows.Rows[i].Cells["Duration"].Style.Padding = new Padding(0, -1, 0, 0);
                }
            }
        }

        /// <summary>
        /// Xử lý logic cho nút Delete (xóa các hàng đã được tick).
        /// </summary>
        private void btnDelete_Click(object sender, EventArgs e)
        {
            List<int> idsToDelete = new List<int>();
            foreach (DataGridViewRow row in dgvShows.Rows)
            {
                DataGridViewCheckBoxCell chk = row.Cells["chkSelect"] as DataGridViewCheckBoxCell;
                if (chk != null && Convert.ToBoolean(chk.Value) == true)
                {
                    idsToDelete.Add((int)row.Tag);
                }
            }

            string message = $"Bạn có chắc chắn muốn xóa {idsToDelete.Count} suất chiếu đã chọn không?";
            DialogResult result = Alert.ShowWarning(message);

            //DialogResult result = MessageBox.Show(message, "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                Database db = new Database();
                int successCount = 0;
                int failCount = 0;
                foreach (int maSuatChieu in idsToDelete)
                {
                    try
                    {
                        string query = "DELETE FROM SUATCHIEU WHERE MASUATCHIEU = @MaSuatChieu";
                        SqlParameter[] parameters = { new SqlParameter("@MaSuatChieu", maSuatChieu) };
                        if (db.ChangeData(query, parameters))
                        {
                            successCount++;
                        }
                        else
                        {
                            failCount++;
                        }
                    }
                    catch (Exception)
                    {
                        failCount++;
                    }
                }
                if (failCount > 0)
                {
                    string erMessage = $"\nXóa thất bại {failCount} suất chiếu (Có thể do đã có vé được bán).";
                    Alert.Show(erMessage, MessagboxCustom.AlertMessagebox.AlertType.Error);
                }
                else
                {
                    string successMessage = $"Đã xóa thành công {successCount} suất chiếu.";
                    Alert.Show(successMessage, MessagboxCustom.AlertMessagebox.AlertType.Success);
                }
                //MessageBox.Show(successMessage, "Kết quả", MessageBoxButtons.OK, MessageBoxIcon.Information);

                if (successCount > 0)
                {
                    LoadShowtimesData();
                }
            }
        }

        /// <summary>
        /// Xử lý logic cho nút Add New (mở form ở chế độ Add).
        /// </summary>
        private void btnAdd_Click(object sender, EventArgs e)
        {
            OpenShowtimeForm(null);
        }

        private void lvShowtimes_Click(object sender, EventArgs e) { }
        private void lblShowtimes_Click(object sender, EventArgs e) { }

        
    }
}