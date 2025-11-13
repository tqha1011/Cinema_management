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
    public partial class AddStaff : UserControl
    {
        private StaffLogic staffLogic;
        public AddStaff()
        {
            InitializeComponent();
            staffLogic = new StaffLogic();
        }

        private void btnExitAddStaf_Click(object sender, EventArgs e)
        {
            if (this.ParentForm != null)
            {
                this.ParentForm.Close();
            }
        }

        private void txbEmail_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnSaveStaff_Click(object sender, EventArgs e)
        {
            Staff newStaff = new Staff();
            newStaff.Name = txbName.Text;
            newStaff.Gender = cbGender.Text;
            newStaff.Position = cboPosition.Text;
            newStaff.Email = txbEmail.Text;
            newStaff.PhoneNumber = txbPhoneNum.Text;
            newStaff.BirthDate = datePickerBirth.Value;
            newStaff.HireDate = datePickerHire.Value;
            newStaff.AccountUsername = txbAccount.Text;
            newStaff.AccountPassword = txbPassword.Text;
            string passwordConfirm = txbPasswordConfirm.Text; // Xac nhan mat khau nhap lai
            if (staffLogic.AddNewStaff(newStaff, passwordConfirm))
            {
                MessageBox.Show("Add successfully");
                // tat form pop-up sau khi them thanh cong
                if (this.ParentForm != null)
                {
                    this.ParentForm.Close();
                }
            }
        }

        private void cbGender_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
