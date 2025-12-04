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
        public UCPhimDangChieu()
        {
            InitializeComponent();

            dtpSearchDate.Value = DateTime.Now;

            LoadMovies();
        }

        private void dtpSearchDate_ValueChanged(object sender, EventArgs e)
        {
            //load lại danh sách phim theo ngày mới chọn
            LoadMovies(dtpSearchDate.Value);
        }

        public void LoadMovies(DateTime? filterDate = null)
        {
            flowPanelMovies.Controls.Clear();

            DateTime DateToUse = filterDate ?? dtpSearchDate.Value;

            string query = @"SELECT DISTINCT P.MAPHIM, P.TENPHIM, P.ANHPHIM
                            FROM PHIM P
                            JOIN SUATCHIEU S ON P.MAPHIM = S.MAPHIM
                            WHERE CAST(S.THOIGIANCHIEU AS DATE) = @NgayChieu";

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand(query, conn);

                    //truyền tham số ngày
                    cmd.Parameters.AddWithValue("@NgayChieu", DateToUse.Date);

                    SqlDataReader reader = cmd.ExecuteReader();

                    //kiểm tra có phim trong ngày ko
                    if (!reader.HasRows)
                    {
                        Label lblThongBao = new Label();
                        lblThongBao.Text = "Không có suất chiếu nào trong ngày này.";
                        lblThongBao.AutoSize = true;
                        lblThongBao.Font = new Font("Arial", 14, FontStyle.Italic);
                        flowPanelMovies.Controls.Add(lblThongBao);
                        return;
                    }

                    while (reader.Read())
                    {
                        UCMovieCard item = new UCMovieCard();

                        int maPhim = Convert.ToInt32(reader["MAPHIM"]);
                        string tenPhim = reader["TENPHIM"].ToString();
                        string anhPhim = reader["ANHPHIM"] != DBNull.Value ? reader["ANHPHIM"].ToString() : "";
                        
                        item.SetData(maPhim, tenPhim, anhPhim);

                        item.OnSelect += Item_OnSelect;

                        flowPanelMovies.Controls.Add(item);

                    }

                }
                catch (Exception ex)
                {
                    Alert.Show("Lỗi tải danh sách phim: " + ex.Message, MessagboxCustom.AlertMessagebox.AlertType.Error);
                }
            }                     
        }

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
