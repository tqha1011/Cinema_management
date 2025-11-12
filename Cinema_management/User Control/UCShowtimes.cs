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
    public partial class UCShowtimes : UserControl
    {
        public UCShowtimes()
        {
            InitializeComponent();
        }

        private void UCShowtimes_Load(object sender, EventArgs e)
        {
            dgvShows.Rows.Add("Bo gia", "2d", "120", "21:00");
        }

        private void lvShowtimes_Click(object sender, EventArgs e)
        {

        }

        private void lblShowtimes_Click(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            // Change from UserControl to Form for modal dialog functionality
            AddShowtime addShowtime = new AddShowtime();
            Form form = new Form
            {
                Text = "Add Showtime",
                AutoSize = true,
                AutoSizeMode = AutoSizeMode.GrowAndShrink,
                StartPosition = FormStartPosition.CenterParent
            };
            addShowtime.Dock = DockStyle.Fill;
            form.Controls.Add(addShowtime);
            //chang
            form.ShowDialog();
        }
    }
}
