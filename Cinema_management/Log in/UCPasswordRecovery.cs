using Cinema_management.Log_in;
using Cinema_management.MessageboxCustom.Utils;
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
    public partial class UCPasswordRecovery : UserControl
    {
        StaffLogic staffLogic;
        private string serverOTP = "";
        private string currentEmail = "";   
        public UCPasswordRecovery()
        {
            InitializeComponent();
            txtPassNew.PasswordChar = '●';
            txtPassNew.Visible = false;
            lblEmailExist.Visible = false;
            lblCheck.Visible = false;
            ptbLock.Visible = false;
            staffLogic = new StaffLogic();
            btnConfirm.Visible = false;
            btnConfirm.Enabled = false;
            txtVerified.Visible = false;
        }

        private async void btnSendCode_Click(object sender, EventArgs e)
        {
            string emailRecover = txtEmailConfirm.Text.Trim();
            lblCheck.Visible = true;
            if(staffLogic.CheckEmailExists(emailRecover)) // check email tồn tại trong hệ thống
            {
                lblEmailExist.Visible = false;
                currentEmail = emailRecover; // lưu email hiện tại để sử dụng sau
                serverOTP = new Random().Next(100000, 999999).ToString(); // tạo mã OTP ngẫu nhiên
                string header = "Mã xác nhận đặt lại mật khẩu";
                string body = $"<p>Mã xác nhận của bạn là: <b>{serverOTP}</b></p>";
                btnSendCode.Enabled = false;
                this.Cursor = Cursors.WaitCursor;
                bool sent = await EmailServices.SendEmailAsync(emailRecover, header, body); // gửi email bất đồng bộ
                this.Cursor = Cursors.Default;
                btnSendCode.Enabled = true;
                if(sent)
                {
                    lblCheck.Visible = true;
                    ptbLock.Visible = true;
                    txtPassNew.Visible = true;
                    txtVerified.Visible = true;
                    txtVerified.Focus();
                    btnConfirm.Visible = true;
                    btnConfirm.Enabled = true;
                    Alert.Show("Mã xác nhận đã được gửi đến email của bạn.", MessagboxCustom.AlertMessagebox.AlertType.Success);
                }
                else
                {
                    Alert.Show("Gửi mã xác nhận thất bại. Vui lòng thử lại.", MessagboxCustom.AlertMessagebox.AlertType.Error);
                }
            }
            else
            {
                lblEmailExist.Visible = true;
                lblCheck.Visible = false;
            }
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            string userOTP = txtVerified.Text.Trim();
            string newPass = txtPassNew.Text.Trim();

            // check xem co trong khong
            if(string.IsNullOrEmpty(userOTP) || string.IsNullOrEmpty(newPass))
            {
                Alert.Show("Vui lòng điền đầy đủ thông tin.", MessagboxCustom.AlertMessagebox.AlertType.Error);
                return;
            }
            // neu khong trong thuc hien tiep
            if(userOTP != serverOTP)
            {
                Alert.Show("Mã xác nhận không đúng. Vui lòng kiểm tra lại.", MessagboxCustom.AlertMessagebox.AlertType.Error);
                return;
            }
            else
            {
                // goi ham update mat khau
                bool updated = staffLogic.UpdatePasswordByEmail(currentEmail, newPass);
                if(updated)
                {
                    Alert.Show("Mật khẩu của bạn đã được đặt lại thành công.", MessagboxCustom.AlertMessagebox.AlertType.Success);
                    if(this.ParentForm is FormLogin parent)
                    {
                        serverOTP = "";
                        parent.ShowUserControl(new UCLogin());
                    }
                }
                else
                {
                    Alert.Show("Đặt lại mật khẩu thất bại. Vui lòng thử lại.", MessagboxCustom.AlertMessagebox.AlertType.Error);
                }
            }
        }

        private void btnShowHide_Click(object sender, EventArgs e)
        {
            if(txtPassNew.PasswordChar == '●')
            {
                txtPassNew.PasswordChar = '\0';
            }
            else
            {
                txtPassNew.PasswordChar = '●';
            }
        }
    }
}
