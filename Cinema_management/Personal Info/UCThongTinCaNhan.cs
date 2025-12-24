using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Drawing2D;
using System.Configuration;
using System.Data.SqlClient;

namespace Cinema_management.Personal_Info
{
    public partial class UCThongTinCaNhan : UserControl
    {
        string connectionString = ConfigurationManager.ConnectionStrings["Azure"].ConnectionString;

        public UCThongTinCaNhan()
        {
            InitializeComponent();
        }

        public void MakePictureBoxRound(PictureBox pb)
        {
            // Tạo một đường dẫn đồ họa hình Elipse (hình tròn nếu pb vuông)
            GraphicsPath gp = new GraphicsPath();
            gp.AddEllipse(0, 0, pb.Width, pb.Height);

            // Gán vùng hiển thị của PictureBox theo đường dẫn đó
            pb.Region = new Region(gp);
        }

        private void UCThongTinCaNhan_Load(object sender, EventArgs e)
        {
            //MakePictureBoxRound(kryptonPictureBox1);
            LoadUserInfo();
        }

        private void LoadUserInfo() 
        {
            //ktra session
            if (Session.currMaNV == -1)
                return;

            string query = @"SELECT HOTEN, GIOITINH, NGAYSINH, SODIENTHOAI, NGAYVAOLAM, VAITRO,
                                    EMAIL, USERNAME, PASSWORD
                               FROM NHANVIEN
                                WHERE MANV = @MaNV";

            using(SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@MaNV", Session.currMaNV);

                    SqlDataReader reader = cmd.ExecuteReader();
                    if (reader.Read())
                    {
                        txtHoTen.Text = reader["HOTEN"].ToString();
                        string gioitinh = reader["GIOITINH"].ToString();
                        if (gioitinh == "Nam")
                            cbbGioiTinh.SelectedIndex = 0;
                        else cbbGioiTinh.SelectedIndex = 1;

                        txtSDT.Text = reader["SODIENTHOAI"].ToString();
                        string vitri = reader["VAITRO"].ToString();
                        if (vitri == "Quản lí")
                            cbbViTri.SelectedIndex = 1;
                        else if (vitri == "Nhân viên")
                           cbbViTri.SelectedIndex = 0;

                        txtEmail.Text = reader["EMAIL"].ToString();
                        dtpNgaySinh.Value = Convert.ToDateTime(reader["NGAYSINH"]);
                        dtpNgayVaoLam.Value = Convert.ToDateTime(reader["NGAYVAOLAM"]);

                        txtUsername.Text = reader["USERNAME"].ToString();
                        txtPass.Text = reader["PASSWORD"].ToString();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi khi tải thông tin: " + ex.Message);
                }
            }
        }

        private void kryptonPictureBox1_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
            //using (Pen pen = new Pen(Color.LightGray, 2))
            //{
            //    e.Graphics.DrawEllipse(pen, 0, 0, kryptonPictureBox1.Width - 1, kryptonPictureBox1.Height - 1);
            //}
        }

        private void kryptonTableLayoutPanel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
