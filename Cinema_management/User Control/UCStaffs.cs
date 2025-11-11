using Cinema_management.Staff_Management;
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
    public partial class UCStaffs : UserControl
    {
        public UCStaffs()
        {
            InitializeComponent();
        }

        private void kryptonLabel1_Click(object sender, EventArgs e)
        {

        }

        private void btnAddStaff_Click(object sender, EventArgs e)
        {
            AddStaff_popup addStaffPopup = new AddStaff_popup();
            addStaffPopup.ShowDialog(this); // Hien thi Usercontrol AddStaff trong mot popup
        }
    }
}
