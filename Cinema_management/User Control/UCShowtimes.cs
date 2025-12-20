using Cinema_management.DAL;
using Krypton.Toolkit;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;

namespace Cinema_management
{
    public partial class UCShowtimes : UserControl
    {
        private DateTime _currentMonday;
        private Database db = new Database();

        public UCShowtimes()
        {
            InitializeComponent();
            _currentMonday = GetMonday(DateTime.Now);
        }

        private void UCShowtimes_Load(object sender, EventArgs e)
        {
            LoadRoomComboBox();
            RegisterColumnClickEvents();
            LoadWeekData();
        }

        private DateTime GetMonday(DateTime date)
        {
            int diff = (7 + (date.DayOfWeek - DayOfWeek.Monday)) % 7;
            return date.AddDays(-1 * diff).Date;
        }

        private void LoadRoomComboBox()
        {
            string query = "SELECT TENPHONG FROM PHONGCHIEU ORDER BY TENPHONG";
            DataTable dt = db.ReadData(query);

            if (dt != null)
            {
                DataRow dr = dt.NewRow();
                dr["TENPHONG"] = "Tất cả phòng";
                dt.Rows.InsertAt(dr, 0);

                cbbRoom.DataSource = dt;
                cbbRoom.DisplayMember = "TENPHONG";
                cbbRoom.ValueMember = "TENPHONG";

                // Mặc định chọn "Phòng 1" (thường là index 1 vì index 0 là "Tất cả phòng")
                if (cbbRoom.Items.Count > 1)
                {
                    cbbRoom.SelectedIndex = 1;
                }
                else
                {
                    cbbRoom.SelectedIndex = 0;
                }
            }
            cbbRoom.SelectedIndexChanged += (s, e) => LoadWeekData();
        }

        private void LoadWeekData()
        {
            UpdateHeaderLabels();
            ClearAllColumns();

            DateTime startOfWeek = _currentMonday;
            DateTime endOfWeek = _currentMonday.AddDays(7);

            string query = @"
                SELECT 
                    sc.MASUATCHIEU, 
                    p.TENPHIM, 
                    pc.TENPHONG, 
                    sc.THOIGIANCHIEU
                FROM SUATCHIEU sc
                JOIN PHIM p ON sc.MAPHIM = p.MAPHIM
                JOIN PHONGCHIEU pc ON sc.MAPHONG = pc.MAPHONG
                WHERE sc.THOIGIANCHIEU >= @Start AND sc.THOIGIANCHIEU < @End
            ";

            List<SqlParameter> paramsList = new List<SqlParameter> {
                new SqlParameter("@Start", startOfWeek),
                new SqlParameter("@End", endOfWeek)
            };

            if (cbbRoom.SelectedValue != null)
            {
                string selectedRoom = cbbRoom.SelectedValue.ToString();
                if (selectedRoom != "Tất cả phòng")
                {
                    query += " AND pc.TENPHONG = @RoomName";
                    paramsList.Add(new SqlParameter("@RoomName", selectedRoom));
                }
            }

            query += " ORDER BY sc.THOIGIANCHIEU";

            DataTable dt = db.ReadData(query, paramsList.ToArray());

            if (dt != null)
            {
                foreach (DataRow row in dt.Rows)
                {
                    int id = Convert.ToInt32(row["MASUATCHIEU"]);
                    string tenPhim = row["TENPHIM"].ToString();
                    string tenPhong = row["TENPHONG"].ToString();
                    DateTime thoiGian = Convert.ToDateTime(row["THOIGIANCHIEU"]);

                    UCShowtimeBlock block = new UCShowtimeBlock();
                    block.SetData(id, tenPhim, thoiGian, tenPhong);

                    block.Width = flpMon.ClientSize.Width - 10;
                    block.Height = 120;
                    block.Margin = new Padding(3, 3, 3, 5);

                    block.OnBlockClicked += (s, e) => OpenEditForm(id);

                    switch (thoiGian.DayOfWeek)
                    {
                        case DayOfWeek.Monday: flpMon.Controls.Add(block); break;
                        case DayOfWeek.Tuesday: flpTue.Controls.Add(block); break;
                        case DayOfWeek.Wednesday: flpWed.Controls.Add(block); break;
                        case DayOfWeek.Thursday: flpThu.Controls.Add(block); break;
                        case DayOfWeek.Friday: flpFri.Controls.Add(block); break;
                        case DayOfWeek.Saturday: flpSat.Controls.Add(block); break;
                        case DayOfWeek.Sunday: flpSun.Controls.Add(block); break;
                    }
                }
            }
        }

        private void UpdateHeaderLabels()
        {
            lblDateRange.Text = $"Tuần: {_currentMonday:dd/MM} - {_currentMonday.AddDays(6):dd/MM/yyyy}";

            lblHeaderMon.Text = $"Thứ 2\n{_currentMonday:dd/MM}";
            lblHeaderTue.Text = $"Thứ 3\n{_currentMonday.AddDays(1):dd/MM}";
            lblHeaderWed.Text = $"Thứ 4\n{_currentMonday.AddDays(2):dd/MM}";
            lblHeaderThu.Text = $"Thứ 5\n{_currentMonday.AddDays(3):dd/MM}";
            lblHeaderFri.Text = $"Thứ 6\n{_currentMonday.AddDays(4):dd/MM}";
            lblHeaderSat.Text = $"Thứ 7\n{_currentMonday.AddDays(5):dd/MM}";
            lblHeaderSun.Text = $"CN\n{_currentMonday.AddDays(6):dd/MM}";

            lblHeaderMon.BackColor = lblHeaderTue.BackColor = lblHeaderWed.BackColor =
            lblHeaderThu.BackColor = lblHeaderFri.BackColor = lblHeaderSat.BackColor = lblHeaderSun.BackColor = Color.AliceBlue;

            DateTime today = DateTime.Today;
            if (today >= _currentMonday && today <= _currentMonday.AddDays(6))
            {
                Color highlightColor = Color.FromArgb(255, 240, 240);
                switch (today.DayOfWeek)
                {
                    case DayOfWeek.Monday: lblHeaderMon.BackColor = highlightColor; break;
                    case DayOfWeek.Tuesday: lblHeaderTue.BackColor = highlightColor; break;
                    case DayOfWeek.Wednesday: lblHeaderWed.BackColor = highlightColor; break;
                    case DayOfWeek.Thursday: lblHeaderThu.BackColor = highlightColor; break;
                    case DayOfWeek.Friday: lblHeaderFri.BackColor = highlightColor; break;
                    case DayOfWeek.Saturday: lblHeaderSat.BackColor = highlightColor; break;
                    case DayOfWeek.Sunday: lblHeaderSun.BackColor = highlightColor; break;
                }
            }
        }

        private void ClearAllColumns()
        {
            flpMon.Controls.Clear();
            flpTue.Controls.Clear();
            flpWed.Controls.Clear();
            flpThu.Controls.Clear();
            flpFri.Controls.Clear();
            flpSat.Controls.Clear();
            flpSun.Controls.Clear();
        }

        private void RegisterColumnClickEvents()
        {
            flpMon.Click += (s, e) => OpenAddForm(_currentMonday);
            flpTue.Click += (s, e) => OpenAddForm(_currentMonday.AddDays(1));
            flpWed.Click += (s, e) => OpenAddForm(_currentMonday.AddDays(2));
            flpThu.Click += (s, e) => OpenAddForm(_currentMonday.AddDays(3));
            flpFri.Click += (s, e) => OpenAddForm(_currentMonday.AddDays(4));
            flpSat.Click += (s, e) => OpenAddForm(_currentMonday.AddDays(5));
            flpSun.Click += (s, e) => OpenAddForm(_currentMonday.AddDays(6));
        }

        private void OpenEditForm(int maSuatChieu)
        {
            AddShowtime frm = new AddShowtime();
            frm.ShowtimeIDToEdit = maSuatChieu;
            Form popup = new Form
            {
                Text = "Cập nhật suất chiếu",
                StartPosition = FormStartPosition.CenterParent,
                Size = new Size(1067, 562),
                FormBorderStyle = FormBorderStyle.FixedDialog,
                MaximizeBox = false,
                MinimizeBox = false
            };
            frm.Dock = DockStyle.Fill;
            popup.Controls.Add(frm);
            popup.ShowDialog();
            LoadWeekData();
        }

        private void OpenAddForm(DateTime selectedDate)
        {
            AddShowtime frm = new AddShowtime();
            Form popup = new Form
            {
                Text = "Thêm suất chiếu",
                StartPosition = FormStartPosition.CenterParent,
                Size = new Size(1067, 600),
                FormBorderStyle = FormBorderStyle.FixedDialog,
                MaximizeBox = false,
                MinimizeBox = false
            };
            frm.Dock = DockStyle.Fill;
            popup.Controls.Add(frm);
            popup.ShowDialog();
            LoadWeekData();
        }

        private void btnPrevWeek_Click(object sender, EventArgs e)
        {
            _currentMonday = _currentMonday.AddDays(-7);
            LoadWeekData();
        }

        private void btnNextWeek_Click(object sender, EventArgs e)
        {
            _currentMonday = _currentMonday.AddDays(7);
            LoadWeekData();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            OpenAddForm(DateTime.Now);
        }

        private void panelTop_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}