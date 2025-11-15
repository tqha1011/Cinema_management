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
        }
        private void UCMovies_Load(object sender, EventArgs e)
        {
            dgvMM.AllowUserToAddRows = false;
            dgvMM.ReadOnly = true;
            dgvMM.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            dgvMM.StateCommon.Background.Color1 = Color.White;
            //dgvMM.StateCommon.HeaderColumn.Content.Font = new Font("Microsoft YaHei UI", 12);
            //dgvMM.StateCommon.DataCell.Content.Font = new Font("Microsoft YaHei UI", 10);

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
    }
}
