using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cinema_management
{
    public partial class AddNewMovie : UserControl
    {
        public delegate void SaveMovieHandler(object sender, Movie movieData);
        public event SaveMovieHandler MovieSaved;
        public AddNewMovie()
        {
            InitializeComponent();
        }

        private void pnAdd_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            Movie newMovie = new Movie();
            newMovie.MovieName = txbMovieName.Text;
            newMovie.DirectorName = txbDirector.Text;
            newMovie.Genre = cbbGenre.Text;
            newMovie.AgeRating = cbbAge.Text;
            if (int.TryParse(txbDuration.Text, out int duration))
                newMovie.Duration = duration;
            else
            {
                MessageBox.Show("Vui lòng nhập số hợp lệ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            newMovie.ReleaseDate = kryptonDateTimePicker1.Value;
            newMovie.Poster = pictureBox1.Image;

            // 2. Bắn sự kiện "MovieSaved" và gửi kèm đối tượng "newMovie"
            // Dấu ?.Invoke đảm bảo code không lỗi nếu không ai lắng nghe sự kiện
            MovieSaved?.Invoke(this, newMovie);

            // Xoa data và ẩn UC
            ClearFields();
            this.Visible = false;
        }
        private void ClearFields()
        {
            txbMovieName.Clear();
            txbDirector.Clear();
            cbbGenre.SelectedIndex = -1;
            cbbAge.SelectedIndex = -1;
            txbDuration.Clear();
            txbScript.Clear();
            kryptonDateTimePicker1.Value = DateTime.Now;
            pictureBox1.Image = null;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            ClearFields();
            //xoa data vua nhap
        }
    }
}
