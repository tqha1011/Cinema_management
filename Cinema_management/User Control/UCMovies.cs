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

namespace Cinema_management
{
    public partial class UCMovies : UserControl
    {
        
        public UCMovies()
        {
            InitializeComponent();

            // đăng ký: khi addNewMovie1 bắn sk MovieSaved thì hàm AddNewMovie1_MovieSaved form này chạy
            addNewMovie1.MovieSaved += AddNewMovie1_MovieSaved;

            addNewMovie1.Visible = false;
        }

        private void AddNewMovie1_MovieSaved(object sender, Movie movieData)
        {
            // movieData chính là đối tượng "newMovie" được gửi từ AddNewMovie.cs
            dgvMM.Rows.Add(
                movieData.MovieName,
                movieData.Genre,
                movieData.AgeRating,
                movieData.Duration,
                movieData.Description,
                movieData.ReleaseDate
                );
            addNewMovie1.Visible = false;
        }
        private void UCMovies_Load(object sender, EventArgs e)
        {
            dgvMM.AllowUserToAddRows = false;
            dgvMM.ReadOnly = true;
            dgvMM.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            Color white = Color.White;
            dgvMM.StateCommon.Background.Color1 = white;
            dgvMM.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(255, 255, 255);


            dgvMM.Rows.Add("Bo gia", "Drama", "P", "120");
        }

        private void kryptonButton1_Click(object sender, EventArgs e)
        {

        }

        private void kryptonDataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void kryptonButton2_Click(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            addNewMovie1.Visible = true;
            addNewMovie1.BringToFront(); //dua len lop tren cung
        }
    }
}
