using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Cinema_management.Staff_Management;
using Cinema_management.DAL;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data;


namespace Cinema_management.Staff_Management
{
    public class StaffLogic
    {
        private Database dtb;
        public StaffLogic()
        {
            dtb = new Database();
        }

        public bool ValidateUserName(Staff staff)
        {
            string query = "SELECT COUNT(*) FROM NHANVIEN WHERE USERNAME = @Username";
            SqlParameter[] parameters = new SqlParameter[] {
                new SqlParameter("@Username", staff.AccountUsername)
            };
            DataTable db = dtb.ReadData(query, parameters);
            int count = Convert.ToInt32(db.Rows[0][0]);
            return count > 0;
        }

        public bool AddNewStaff(Staff newStaff,string passAgain)
        {
            #region validation
            // kiem tra ten co hop le khong
            if (string.IsNullOrEmpty(newStaff.Name)){
                MessageBox.Show("Staff name cannot be empty.");
                return false;
            }

            // kiem tra email co hop le khong
            if (string.IsNullOrEmpty(newStaff.Email) || !newStaff.Email.Contains("@") || !newStaff.Email.Contains(".com"))
            {
                MessageBox.Show("Invalid email address.");
                return false;
            }

            // kiem tra so dien thoai co hop le khong
            if (string.IsNullOrEmpty(newStaff.PhoneNumber) || newStaff.PhoneNumber.Length < 10)
            {
                MessageBox.Show("Invalid phone number.");
                return false;
            }

            // kiem tra ngay sinh co hop le khong
            if (newStaff.BirthDate >= DateTime.Now)
            {
                MessageBox.Show("Invalid birth date.");
                return false;
            }

            // kiem tra ngay vao lam co hop le khong
            if (newStaff.HireDate > DateTime.Now || newStaff.HireDate <= newStaff.BirthDate)
            {
                MessageBox.Show("Invalid hire date.");
                return false;
            }

            // kiem tra gioi tinh hop le khong
            if (string.IsNullOrEmpty(newStaff.Gender)){
                MessageBox.Show("Invalid Gender.");
            }

            // kiem tra mat khau co hop le khong
            if (string.IsNullOrEmpty(newStaff.AccountPassword))
            {
                MessageBox.Show("Password cannot be empty.");
                return true;
            }
            
            // kiem tra admin nhap co dung mat khau khong
            if(newStaff.AccountPassword != passAgain)
            {
                MessageBox.Show("Passwords do not match.");
                return false;
            }

            // kiem tra username co bi trong khong
            if(string.IsNullOrEmpty(newStaff.AccountUsername))
            {
                MessageBox.Show("Username cannot be empty.");
                return false;
            }

            // kiem tra username da ton tai chua
            if (ValidateUserName(newStaff)) { 
                MessageBox.Show("Username already exists. Please choose a different username.");
                return false;
            }

            #endregion validation

            string query = "INSERT INTO NHANVIEN(HOTEN,SODIENTHOAI,NGAYSINH,NGAYVAOLAM,VAITRO,GIOITINH,EMAIL,USERNAME,PASSWORD)" +
                           "VALUES(@Name,@PhoneNumber,@BirthDate,@HireDate,@Position,@Gender,@Email,@AccountUsername,@AccountPassword)";
            SqlParameter[] sqlParameters = new SqlParameter[]
            {
                new SqlParameter("@Name", newStaff.Name),
                new SqlParameter("@PhoneNumber", newStaff.PhoneNumber),
                new SqlParameter("@BirthDate", newStaff.BirthDate),
                new SqlParameter("@HireDate", newStaff.HireDate),
                new SqlParameter("@Position", newStaff.Position),
                new SqlParameter("@Gender",newStaff.Gender),
                new SqlParameter("@Email", (object)newStaff.Email ?? DBNull.Value),
                new SqlParameter("@AccountUsername", newStaff.AccountUsername),
                new SqlParameter("@AccountPassword", newStaff.AccountPassword)
            };
            return dtb.ChangeData(query, sqlParameters);
        }
    }
}
