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
        private StaffLogic staffLogic;
        public UCStaffs()
        {
            InitializeComponent();
        }
        // Ham load danh sach nhan vien
        private void LoadStaffs()
        {
            // load danh sach nhan vien tu database va hien thi tren giao dien
            dgvMM.DataSource = staffLogic.ShowListStaff();
        }
        private void UCStaffs_Load(object sender, EventArgs e)
        {
            staffLogic = new StaffLogic();
            LoadStaffs();
        }

        private void kryptonLabel1_Click(object sender, EventArgs e)
        {

        }

        private void btnAddStaff_Click(object sender, EventArgs e)
        {
            AddStaff_popup addStaffPopup = new AddStaff_popup();
            addStaffPopup.ShowDialog(this); // Hien thi Usercontrol AddStaff trong mot popup
            LoadStaffs(); // Tai lai danh sach nhan vien sau khi them moi
        }
    }
}
