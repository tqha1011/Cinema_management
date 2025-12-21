using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using Krypton.Toolkit;
using Cinema_management.MessageboxCustom.Utils;

namespace Cinema_management.Ticket_Booking
{
    public partial class FormChonSuatChieu : Form
    {
        private int maPhim;
        private DateTime ngayChieu;

        public int SelectedMaSuatChieu { get; set; } //biến trả về kết quả
        string connectionString = ConfigurationManager.ConnectionStrings["Azure"].ConnectionString;

        // Đường dẫn thư mục chứa ảnh (Ngang hàng với file .csproj và Form1.cs)
        // Lưu ý: Dùng Path.GetFullPath để chuẩn hóa đường dẫn
        private string _posterFolderPath = Path.GetFullPath(Path.Combine(Application.StartupPath, @"..\..\Posters"));

        public FormChonSuatChieu(int maPhim, DateTime ngayChieu) //constructor
        {
            InitializeComponent();
            this.maPhim = maPhim;
            this.ngayChieu = ngayChieu;
        }

        private void FormChonSuatChieu_Load(object sender, EventArgs e)
        {
            lblNgayChieu.Text = ngayChieu.ToString("dd/MM/yyyy");
            LoadMovieInfo(); // load thông tin phim
            LoadShowTimes(); //load danh sách giờ chiếu
        }

        private void LoadMovieInfo()
        {
            string query = @"SELECT TENPHIM, ANHPHIM FROM PHIM
                             WHERE MAPHIM = @MaPhim";

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@MaPhim", maPhim);

                    SqlDataReader reader = cmd.ExecuteReader();
                    if (reader.Read())
                    {
                        lblTenPhim.Text = reader["TENPHIM"].ToString();

                        //xử lý ảnh
                        string imagePath = reader["ANHPHIM"] != DBNull.Value ? reader["ANHPHIM"].ToString() : "";
                        string fileName = imagePath;
                        if (!string.IsNullOrEmpty(fileName))
                        {
                            string fullPath = Path.Combine(_posterFolderPath, fileName);
                            if (File.Exists(fullPath))
                            {
                                picPoster.Image = Image.FromFile(fullPath);
                                picPoster.SizeMode = PictureBoxSizeMode.Zoom;
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    Alert.Show("Lỗi khi tải thông tin phim!", MessagboxCustom.AlertMessagebox.AlertType.Error);
                }
            }
        }

        private void LoadShowTimes()
        {
            flowPanelSuatChieu.Controls.Clear();

            //CHỈ LẤY SUẤT CHIẾU CHƯA DIỄN RA
            string query = @"SELECT S.MASUATCHIEU, S.THOIGIANCHIEU, P.TENPHONG
                            FROM SUATCHIEU S
                            JOIN PHONGCHIEU P ON S.MAPHONG = P.MAPHONG
                            WHERE S.MAPHIM = @MaPhim
                            AND CAST(S.THOIGIANCHIEU AS DATE) = @NgayChieu
                            AND S.THOIGIANCHIEU > @ThoiGianHienTai
                            ORDER BY S.THOIGIANCHIEU";

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@MaPhim", maPhim);
                    cmd.Parameters.AddWithValue("@NgayChieu", ngayChieu.Date);

                    cmd.Parameters.AddWithValue("@ThoiGianHienTai", DateTime.Now);

                    SqlDataReader reader = cmd.ExecuteReader();

                    //NẾU KHÔNG CÒN SUẤT CHIẾU NÀO
                    if (!reader.HasRows)
                    {
                        Label lblThongBao = new Label();
                        lblThongBao.Text = "Hết suất chiếu trong hôm nay.";
                        lblThongBao.AutoSize = true;
                        lblThongBao.ForeColor = Color.Red;
                        flowPanelSuatChieu.Controls.Add(lblThongBao);
                        return;
                    }
                    
                    while (reader.Read())
                    {
                        int maSuatChieu = Convert.ToInt32(reader["MASUATCHIEU"]);
                        DateTime thoiGian = Convert.ToDateTime(reader["THOIGIANCHIEU"]);
                        String tenPhong = reader["TENPHONG"].ToString();

                        KryptonButton btnTime = new KryptonButton();
                        btnTime.Text = thoiGian.ToString("HH:mm");

                        // Lưu Mã suất chiếu vào Tag để dùng sau này
                        btnTime.Tag = maSuatChieu;

                        btnTime.Size = new Size(180, 60);
                        btnTime.StateCommon.Border.Color1 = Color.Transparent;
                        btnTime.StateCommon.Border.Rounding = 20;
                        btnTime.StateCommon.Border.GraphicsHint = PaletteGraphicsHint.AntiAlias;

                        btnTime.StateCommon.Back.Color1 = Color.FromArgb(230, 0, 18);
                        btnTime.StateCommon.Back.Color2 = Color.FromArgb(154, 5, 0);
                        btnTime.StateCommon.Back.ColorAngle = 60;
                        btnTime.StateCommon.Back.ColorStyle = PaletteColorStyle.Linear;

                        btnTime.StateCommon.Content.ShortText.Color1 = Color.White;
                        btnTime.StateCommon.Content.ShortText.Font = new Font("Nunito", 14, FontStyle.Bold);

                        btnTime.OverrideDefault.Back.Color1 = Color.FromArgb(230, 0, 18);
                        btnTime.OverrideDefault.Back.Color2 = Color.FromArgb(154, 5, 0);
                        btnTime.OverrideDefault.Back.ColorAngle = 60;
                        btnTime.OverrideDefault.Back.ColorStyle = PaletteColorStyle.Linear;
                        btnTime.OverrideDefault.Border.Color1 = Color.Transparent;
                        btnTime.OverrideDefault.Border.GraphicsHint = PaletteGraphicsHint.AntiAlias;

                        btnTime.Click += BtnTime_Click;
                        flowPanelSuatChieu.Controls.Add(btnTime);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi tải suất chiếu: " + ex.Message);
                }
            }
            
        }

        private void BtnTime_Click(object sender, EventArgs e)
        {
            KryptonButton btn = sender as KryptonButton;
            if (btn != null)
            {
                // Lấy mã suất chiếu từ Tag
                this.SelectedMaSuatChieu = (int)btn.Tag;

                // Báo kết quả OK về form cha
                this.DialogResult = DialogResult.OK;

                // Đóng form này lại
                this.Close();
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

    }
}
