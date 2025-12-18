using Cinema_management.MessageboxCustom.Utils;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cinema_management.Ticket_Booking
{
    public partial class UCPhimDangChieu : UserControl
    {
        // sự kiện để báo cho form cha biết đã chọn xong suất chiếu
        public event Action<int> OnSuatChieuSelected;

        string connectionString = ConfigurationManager.ConnectionStrings["Azure"].ConnectionString;

        // List backup
        private List<Control> _renderedControls = new List<Control>();

        public UCPhimDangChieu()
        {
            InitializeComponent();

            dtpSearchDate.Value = DateTime.Now;

            SetDoubleBuffered(flowPanelMovies);
            
            LoadMoviesAsync();
            //LoadMovies();
        }
        public static void SetDoubleBuffered(Control control)
        {
            typeof(Control).InvokeMember("DoubleBuffered",
                BindingFlags.SetProperty | BindingFlags.Instance | BindingFlags.NonPublic,
                null, control, new object[] { true });
        }

        private void dtpSearchDate_ValueChanged(object sender, EventArgs e)
        {
            //load lại danh sách phim theo ngày mới chọn
            LoadMoviesAsync(dtpSearchDate.Value);
        }

        public async void LoadMoviesAsync(DateTime? filterDate = null)
        {
            DateTime DateToUse = filterDate ?? dtpSearchDate.Value;

            try
            {
                // Chạy query dưới background thread
                DataTable dt = await Task.Run(() => GetMoviesFromDB(DateToUse));

                // Vẽ giao diện trên UI thread
                RenderMovies(dt);
            }
            catch (Exception ex)
            {
                Alert.Show("Lỗi tải danh sách phim: " + ex.Message, MessagboxCustom.AlertMessagebox.AlertType.Error);
            }
        }

        // Hàm lấy dữ liệu trả về DataTable
        private DataTable GetMoviesFromDB(DateTime date)
        {
            DataTable dt = new DataTable();
            string query = @"SELECT DISTINCT P.MAPHIM, P.TENPHIM, P.ANHPHIM
                            FROM PHIM P
                            JOIN SUATCHIEU S ON P.MAPHIM = S.MAPHIM
                            WHERE CAST(S.THOIGIANCHIEU AS DATE) = @NgayChieu";

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@NgayChieu", date.Date);

                SqlDataReader reader = cmd.ExecuteReader();
                dt.Load(reader);
            }
            return dt;
        }

        // Hàm Render giao diện tối ưu
        private void RenderMovies(DataTable dt)
        {
            // Tạm dừng vẽ để tránh nhấp nháy
            flowPanelMovies.Visible = false;
            flowPanelMovies.SuspendLayout();

            // Dọn dẹp control cũ
            foreach (Control c in flowPanelMovies.Controls) c.Dispose();
            flowPanelMovies.Controls.Clear();
            _renderedControls.Clear();

            // Kiểm tra nếu không có phim
            if (dt.Rows.Count == 0)
            {
                Label lblThongBao = new Label();
                lblThongBao.Text = "Không có suất chiếu nào trong ngày này.";
                lblThongBao.AutoSize = true;
                lblThongBao.Font = new Font("Nunito", 18, FontStyle.Italic);
                lblThongBao.ForeColor = Color.Gray; 
                lblThongBao.Margin = new Padding(50);

                flowPanelMovies.Controls.Add(lblThongBao);
                flowPanelMovies.ResumeLayout();
                flowPanelMovies.Visible = true;
                return;
            }

            foreach (DataRow row in dt.Rows)
            {
                UCMovieCard item = new UCMovieCard();

                int maPhim = Convert.ToInt32(row["MAPHIM"]);
                string tenPhim = row["TENPHIM"].ToString();

                // Xử lý ảnh
                string anhPhim = row["ANHPHIM"] != DBNull.Value ? row["ANHPHIM"].ToString() : "";

                item.SetData(maPhim, tenPhim, anhPhim);
                item.Margin = new Padding(20);

                item.OnSelect += Item_OnSelect;

                _renderedControls.Add(item);
            }

            flowPanelMovies.Controls.AddRange(_renderedControls.ToArray());

            flowPanelMovies.ResumeLayout();
            flowPanelMovies.Visible = true;
        }

        //public void LoadMovies(DateTime? filterDate = null)
        //{
        //    flowPanelMovies.Controls.Clear();

        //    DateTime DateToUse = filterDate ?? dtpSearchDate.Value;

        //    string query = @"SELECT DISTINCT P.MAPHIM, P.TENPHIM, P.ANHPHIM
        //                    FROM PHIM P
        //                    JOIN SUATCHIEU S ON P.MAPHIM = S.MAPHIM
        //                    WHERE CAST(S.THOIGIANCHIEU AS DATE) = @NgayChieu";

        //    using (SqlConnection conn = new SqlConnection(connectionString))
        //    {
        //        try
        //        {
        //            conn.Open();
        //            SqlCommand cmd = new SqlCommand(query, conn);

        //            //truyền tham số ngày
        //            cmd.Parameters.AddWithValue("@NgayChieu", DateToUse.Date);

        //            SqlDataReader reader = cmd.ExecuteReader();

        //            //kiểm tra có phim trong ngày ko
        //            if (!reader.HasRows)
        //            {
        //                Label lblThongBao = new Label();
        //                lblThongBao.Text = "Không có suất chiếu nào trong ngày này.";
        //                lblThongBao.AutoSize = true;
        //                lblThongBao.Font = new Font("Arial", 14, FontStyle.Italic);
        //                flowPanelMovies.Controls.Add(lblThongBao);
        //                return;
        //            }

        //            while (reader.Read())
        //            {
        //                UCMovieCard item = new UCMovieCard();

        //                int maPhim = Convert.ToInt32(reader["MAPHIM"]);
        //                string tenPhim = reader["TENPHIM"].ToString();
        //                string anhPhim = reader["ANHPHIM"] != DBNull.Value ? reader["ANHPHIM"].ToString() : "";

        //                item.SetData(maPhim, tenPhim, anhPhim);

        //                item.OnSelect += Item_OnSelect;

        //                flowPanelMovies.Controls.Add(item);

        //            }

        //        }
        //        catch (Exception ex)
        //        {
        //            Alert.Show("Lỗi tải danh sách phim: " + ex.Message, MessagboxCustom.AlertMessagebox.AlertType.Error);
        //        }
        //    }                     
        //}

        private void Item_OnSelect(object sender, EventArgs e)
        {
            UCMovieCard item = sender as UCMovieCard;

            //mở form chọn suất chiếu
            FormChonSuatChieu frm = new FormChonSuatChieu(item.MaPhim, dtpSearchDate.Value);

            if(frm.ShowDialog() == DialogResult.OK)
            {
                OnSuatChieuSelected?.Invoke(frm.SelectedMaSuatChieu);
            }    
        }

        private void panelMM_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
