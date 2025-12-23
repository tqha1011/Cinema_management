using Cinema_management.DAL;
using Cinema_management.Staff_Management;
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
    public partial class UCDashboard : UserControl
    {
        public UCDashboard()
        {
            InitializeComponent();
            timerClock.Start();
            UpdateDateTime();
            LoadDashboardStats();
        }

        private void UpdateDateTime()
        {
            DateTime now = DateTime.Now;
            lblTime.Text = now.ToString("HH:mm:ss");
            lblDate.Text = now.ToString("dddd, dd/MM/yyyy");
        }

        private void timerClock_Tick(object sender, EventArgs e)
        {
            UpdateDateTime();
        }

        private void LoadDashboardStats()
        {
            try
            {
                grDateTime.Visible = true;

                Database db = new Database();

                string queryMovies = "SELECT COUNT(*) FROM PHIM";
                DataTable dtMovies = db.ReadData(queryMovies);
                if (dtMovies != null && dtMovies.Rows.Count > 0)
                    lbCardValue.Text = dtMovies.Rows[0][0].ToString();

                string queryShows = "SELECT COUNT(*) FROM SUATCHIEU WHERE CAST(THOIGIANCHIEU AS DATE) = CAST(GETDATE() AS DATE)";
                DataTable dtShows = db.ReadData(queryShows);
                if (dtShows != null && dtShows.Rows.Count > 0)
                    kryptonLabel9.Text = dtShows.Rows[0][0].ToString();

                string queryStaff = "SELECT COUNT(*) FROM NHANVIEN";
                DataTable dtStaff = db.ReadData(queryStaff);
                if (dtStaff != null && dtStaff.Rows.Count > 0)
                    kryptonLabel6.Text = dtStaff.Rows[0][0].ToString();
            }
            catch (Exception) { }
        }

        private void tableLayoutPanel2_Paint(object sender, PaintEventArgs e) { }
        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e) { }
        private void lbCardValue_Click(object sender, EventArgs e) { }
        private void kryptonLabel2_Click(object sender, EventArgs e) { }
        private void kryptonGroup1_Panel_Paint(object sender, PaintEventArgs e) { }
        private void kryptonLabel9_Click(object sender, EventArgs e) { }
        private void kryptonLabel14_Click(object sender, EventArgs e) { }

        private void btnAddMovie_Click(object sender, EventArgs e)
        {
            AddUpdateMovieForm frm = new AddUpdateMovieForm(null);

            if (frm.ShowDialog() == DialogResult.OK)
            {
                LoadDashboardStats();
            }
        }

        private void grQuickActions_Panel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnAddStaff_Click(object sender, EventArgs e)
        {
            AddStaff_popup addStaffPopup = new AddStaff_popup();
            addStaffPopup.ShowDialog(this);
            LoadDashboardStats();
        }
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
                ClientSize = new System.Drawing.Size(1200,700),
                FormBorderStyle = FormBorderStyle.FixedDialog,
                MaximizeBox = false,
                MinimizeBox = false
            };

            addShowtime.Dock = DockStyle.Fill;
            form.Controls.Add(addShowtime);

            form.ShowDialog();
            LoadDashboardStats();
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            OpenShowtimeForm(null);
        }
    }
}