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
    public partial class AddStaff : UserControl
    {
        public AddStaff()
        {
            InitializeComponent();
        }

        private void btnExitAddStaf_Click(object sender, EventArgs e)
        {
            if(this.ParentForm!=null)
            {
                this.ParentForm.Close();
            }
        }

        private void txbEmail_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
