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
        private int currentStaffId = 0; // Luu ID nhan vien hien tai (0 neu them moi)
      
        public AddStaff(int id)
        {
            InitializeComponent();
            staffLogic = new StaffLogic();
            currentStaffId = id; // id = 0 thì thêm mới, id > 0 thì cập nhật
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
            bool success = false;
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
            if (currentStaffId == 0)
            {
                // Them moi nhan vien
                success = staffLogic.AddNewStaff(newStaff, passwordConfirm);
            }
            else
            {
                // Cap nhat nhan vien
                newStaff.Id = currentStaffId;
                success = staffLogic.UpdateStaff(newStaff, passwordConfirm, currentStaffId);
            }
            if(success)
            {
                MessageBox.Show("Lưu thông tin nhân viên thành công!", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
                if (this.ParentForm != null)
                {
                    this.ParentForm.Close();
                }
            }
            else
            {
                MessageBox.Show("Lưu thông tin nhân viên thất bại. Vui lòng kiểm tra lại dữ liệu nhập.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cbGender_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void AddStaff_Load(object sender, EventArgs e)
        {
            if (currentStaffId > 0)
            {
                LoadStaffForUpdate();
            }
        }

        private void LoadStaffForUpdate()
        {
            Staff existingStaff = staffLogic.GetStaffById(currentStaffId);
            if (existingStaff != null)
            {
                txbName.Text = existingStaff.Name;
                cbGender.Text = existingStaff.Gender;
                cboPosition.Text = existingStaff.Position;
                txbEmail.Text = existingStaff.Email;
                txbPhoneNum.Text = existingStaff.PhoneNumber;
                datePickerBirth.Value = existingStaff.BirthDate;
                datePickerHire.Value = existingStaff.HireDate;
                txbAccount.Text = existingStaff.AccountUsername;
                txbPassword.Text = existingStaff.AccountPassword;
                txbPasswordConfirm.Text = existingStaff.AccountPassword;
            }
        }
    }
}
