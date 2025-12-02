using Cinema_management.Log_in;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Cinema_management.MessageboxCustom.Utils;
using Cinema_management.MessagboxCustom;

namespace Cinema_management
{
    public partial class UCLogin : UserControl
    {
        AuthLogic authLogic;
        public UCLogin()
        {
            InitializeComponent();
            this.DoubleBuffered = true;
            this.SetStyle(ControlStyles.UserPaint |
                  ControlStyles.AllPaintingInWmPaint |
                  ControlStyles.OptimizedDoubleBuffer, true);
            this.UpdateStyles();
            lblInfo.Visible = false;
            authLogic = new AuthLogic();
        }

        private void kryptonTextBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttonSpecAny1_Click(object sender, EventArgs e)
        {
            if(txtPass.PasswordChar == '\0')
            {
                txtPass.PasswordChar = '●';
            }
            else
            {
                txtPass.PasswordChar = '\0';
            }
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = txtUser.Text.Trim();
            string pass = txtPass.Text.Trim();
            string role = cboRole.SelectedItem?.ToString(); 

            // validate du lieu dau vao
            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(pass) || string.IsNullOrEmpty(role))
            {
                lblInfo.Visible = true;
            }
            else
            {
                lblInfo.Visible = false;
                // xu ly dang nhap
                bool success = authLogic.AuthenticateUser(username, pass, role);
                if (success)
                {
                    Alert.Show("Đăng nhập thành công", AlertMessagebox.AlertType.Success);
                    // Chuyển đến giao diện chính của ứng dụng
                    Form parentForm = this.FindForm();
                    if (parentForm != null)
                    {
                        parentForm.Hide();
                        FormMain mainForm = new FormMain();
                        DialogResult result = mainForm.ShowDialog();
                        if (result == DialogResult.OK)
                        {
                            parentForm.Show();
                            txtPass.Text = "";
                            txtUser.Text = username;
                            txtPass.Focus();
                        }
                        else
                        {
                            parentForm.Close();
                        }
                    }
                }
                else
                {
                    Alert.Show("Đăng nhập thất bại. Vui lòng kiểm tra lại thông tin.", AlertMessagebox.AlertType.Error);
                }
            }
        }

        private void llbQuenMK_Click(object sender, EventArgs e)
        {
            FormLogin parentForm = this.FindForm() as FormLogin;
            if (parentForm != null)
            {
                parentForm.ShowUserControl(new UCPasswordRecovery(),true);

            }
        }

        private void llbQuenMK_LinkClicked(object sender, EventArgs e)
        {

        }
    }
}
