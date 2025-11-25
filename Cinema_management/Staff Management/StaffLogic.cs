using System;
using Cinema_management.MessageboxCustom;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Cinema_management.Staff_Management;
using Cinema_management.DAL;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data;
using System.Text.RegularExpressions;
using Cinema_management.MessageboxCustom.Utils;


namespace Cinema_management.Staff_Management
{
    public class StaffLogic
    {
        private Database dtb;
        public StaffLogic()
        {
            dtb = new Database();
        }

        public bool ValidateUserName(Staff staff, int id)
        {
            int count;
            if (id == 0)
            {
                string query = "SELECT COUNT(*) FROM NHANVIEN WHERE USERNAME = @Username";
                SqlParameter[] parameters = new SqlParameter[] {
                new SqlParameter("@Username", staff.AccountUsername)
            };
                DataTable db = dtb.ReadData(query, parameters);
                count = Convert.ToInt32(db.Rows[0][0]);
                return count > 0;
            }
            else
            {
                string query = "SELECT COUNT(*) FROM NHANVIEN WHERE USERNAME = @Username AND MANV != @Id";
                SqlParameter[] parameters = new SqlParameter[] {
                    new SqlParameter("@Username", staff.AccountUsername),
                    new SqlParameter("@Id", id)
                };
                DataTable db = dtb.ReadData(query, parameters);
                count = Convert.ToInt32(db.Rows[0][0]);
                return count > 0;
            }
        }
        #region validate email
        // ham kiem tra email hop le
        public bool ValidateEmail(string email)
        {
            if(string.IsNullOrEmpty(email))
            {
                return true; // email co the de trong
            }
            // Regex pattern cho email hop le
            // Linh hoat cac loai duoi email
            Regex emailRegex = new Regex(@"^[^@\s]+@[^@\s]+\.[^@\s]+$");
            return emailRegex.IsMatch(email);
        }
        #endregion

        #region validate infomation
        // ham kiem tra thong tin nhan vien hop le
        public bool ValidateInfo(Staff newStaff, string passAgain, int id)
        {
            // kiem tra ten nhan vien co bi bo trong khong
            if (string.IsNullOrEmpty(newStaff.Name))
            {
                Alert.Show("Tên không được bỏ trống!",MessagboxCustom.AlertMessagebox.AlertType.Error);
                return false;
            }

            // kiem tra email co hop le khong
            if (!ValidateEmail(newStaff.Email))
            {
                Alert.Show("Email không hợp lệ!", MessagboxCustom.AlertMessagebox.AlertType.Error);
                return false;
            }

            // kiem tra so dien thoai co hop le khong
            if (string.IsNullOrEmpty(newStaff.PhoneNumber) || newStaff.PhoneNumber.Length < 10)
            {
                Alert.Show("Số điện thoại không hợp lệ!", MessagboxCustom.AlertMessagebox.AlertType.Error);
                return false;
            }

            // kiem tra ngay sinh co hop le khong
            if (newStaff.BirthDate >= DateTime.Now || newStaff.BirthDate >= newStaff.HireDate)
            {
                Alert.Show("Ngày sinh không hợp lệ!", MessagboxCustom.AlertMessagebox.AlertType.Error);
                return false;
            }

            // kiem tra ngay vao lam co hop le khong
            if (newStaff.HireDate > DateTime.Now || newStaff.HireDate <= newStaff.BirthDate)
            {
                Alert.Show("Ngày vào làm không hợp lệ!", MessagboxCustom.AlertMessagebox.AlertType.Error);
                return false;
            }

            // kiem tra gioi tinh hop le khong
            if (string.IsNullOrEmpty(newStaff.Gender))
            {
                Alert.Show("Giới tính không hợp lệ", MessagboxCustom.AlertMessagebox.AlertType.Error);
                return false;
            }

            // kiem tra username co bi bo trong khong
            if (string.IsNullOrEmpty(newStaff.AccountUsername))
            {
                Alert.Show("Username không được bỏ trống", MessagboxCustom.AlertMessagebox.AlertType.Error);
                return false;
            }

            // kiem tra username da ton tai chua
            if (ValidateUserName(newStaff, id))
            {
                Alert.Show("Username đã tồn tại", MessagboxCustom.AlertMessagebox.AlertType.Error);
                return false;
            }

            // kiem tra mat khau co hop le khong
            if (string.IsNullOrEmpty(newStaff.AccountPassword))
            {
                Alert.Show("Mật khẩu không được bỏ trống!", MessagboxCustom.AlertMessagebox.AlertType.Error);
                return false;
            }

            // kiem tra admin nhap co dung mat khau khong
            if (newStaff.AccountPassword != passAgain)
            {
                Alert.Show("Mật khẩu nhập lại không khớp", MessagboxCustom.AlertMessagebox.AlertType.Error);
                return false;
            }

            return true;
        }
        #endregion

        #region Add New Staff
        // ham AddNewStaff de them nhan vien moi
        public bool AddNewStaff(Staff newStaff, string passAgain, int ID = 0)
        {
            if (ValidateInfo(newStaff, passAgain, ID) == false) // check thong tin hop le
            {
                return false;
            }
            else
            {
                // tao cau truy van SQL de chen du lieu nhan vien moi
                string query = "INSERT INTO NHANVIEN(HOTEN,SODIENTHOAI,NGAYSINH,NGAYVAOLAM,VAITRO,GIOITINH,EMAIL,USERNAME,PASSWORD)" +
                               "VALUES(@Name,@PhoneNumber,@BirthDate,@HireDate,@Position,@Gender,@Email,@AccountUsername,@AccountPassword)";

                // tao mang tham so SQL
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

                return dtb.ChangeData(query, sqlParameters); // thuc hien cau truy van va tra ve ket qua
            }
        }
        #endregion

        #region Update Staff
        public bool UpdateStaff(Staff updatedStaff, string passAgain, int ID)
        {
            if (!ValidateInfo(updatedStaff, passAgain,ID))
            {
                return false;
            }
            else
            {
                // tao cau truy van SQL de cap nhat du lieu nhan vien
                string query = "UPDATE NHANVIEN SET HOTEN = @Name, SODIENTHOAI = @PhoneNumber, NGAYSINH = @BirthDate, " +
                               "NGAYVAOLAM = @HireDate, VAITRO = @Position, GIOITINH = @Gender, EMAIL = @Email, " +
                               "USERNAME = @AccountUsername, PASSWORD = @AccountPassword WHERE MANV = @Id";

                // khoi tao mang tham so SQL
                SqlParameter[] sqlParameters = new SqlParameter[]
                {
                    new SqlParameter("@ID",ID),
                    new SqlParameter("@Name", updatedStaff.Name),
                    new SqlParameter("@PhoneNumber", updatedStaff.PhoneNumber),
                    new SqlParameter("@BirthDate", updatedStaff.BirthDate),
                    new SqlParameter("@HireDate", updatedStaff.HireDate),
                    new SqlParameter("@Position", updatedStaff.Position),
                    new SqlParameter("@Gender", updatedStaff.Gender),
                    new SqlParameter("@Email", (object)updatedStaff.Email ?? DBNull.Value),
                    new SqlParameter("@AccountUsername", updatedStaff.AccountUsername),
                    new SqlParameter("@AccountPassword", updatedStaff.AccountPassword)
                };
                return dtb.ChangeData(query, sqlParameters); // thuc hien cau truy van va tra ve ket qua
            }
        }
        #endregion

        #region show staff detail
        public DataTable ShowListStaff()
        {
            string query = "SELECT MANV AS 'ID', HOTEN AS 'Full Name', GIOITINH AS 'Gender', NGAYSINH AS 'Birthday', " +
                           "SODIENTHOAI AS 'Phone Number', EMAIL AS 'Email' , VAITRO AS 'Position', NGAYVAOLAM AS 'Hire Date' FROM NHANVIEN";
            return dtb.ReadData(query);

        }
        #endregion

        #region search staff
        public DataTable SearchStaff(string name)
        {
            string query = "SELECT MANV AS 'ID', HOTEN AS 'Full Name', GIOITINH AS 'Gender', NGAYSINH AS 'Birthday', " +
                           "SODIENTHOAI AS 'Phone Number', EMAIL AS 'Email', VAITRO AS 'Position' , NGAYVAOLAM AS 'Hire Date' FROM NHANVIEN" +
                           " WHERE HOTEN LIKE @name";
            SqlParameter[] sqlParameters = new SqlParameter[]
            {
                new SqlParameter("@name","%" + name + "%")
            };
            return dtb.ReadData(query, sqlParameters);
        }
        #endregion

        #region delete staff
        public bool DeleteStaff(int ID)
        {
            string query = "DELETE FROM NHANVIEN WHERE MANV = @ID";
            SqlParameter[] sqlParameters = new SqlParameter[]
            {
                new SqlParameter("@ID", ID)
            };
            return dtb.ChangeData(query, sqlParameters);
        }
        #endregion

        #region
        public Staff GetStaffById(int ID)
        {
            string query = "SELECT * FROM NHANVIEN WHERE MANV = @ID";
            SqlParameter[] sqlParameters = new SqlParameter[]
            {
                new SqlParameter("@ID", ID)
            };
            DataTable dt = dtb.ReadData(query, sqlParameters);
            if (dtb.Equals(null) || dt.Rows.Count == 0)
            {
                return null;
            }
            else
            {
                Staff staff = new Staff();
                staff.Id = Convert.ToInt32(dt.Rows[0]["MANV"]);
                staff.Name = dt.Rows[0]["HOTEN"].ToString();
                staff.Gender = dt.Rows[0]["GIOITINH"].ToString();
                staff.PhoneNumber = dt.Rows[0]["SODIENTHOAI"].ToString();
                staff.BirthDate = Convert.ToDateTime(dt.Rows[0]["NGAYSINH"]);
                staff.HireDate = Convert.ToDateTime(dt.Rows[0]["NGAYVAOLAM"]);
                staff.Position = dt.Rows[0]["VAITRO"].ToString();
                staff.Email = dt.Rows[0]["EMAIL"].ToString();
                staff.AccountUsername = dt.Rows[0]["USERNAME"].ToString();
                staff.AccountPassword = dt.Rows[0]["PASSWORD"].ToString();
                return staff;
            }
        }
        #endregion

        public bool CheckEmailExists(string email)
        {
            try
            {
                string query = "SELECT COUNT(*) FROM NHANVIEN WHERE EMAIL = @Email";
                SqlParameter[] parameters = new SqlParameter[]
                {
                new SqlParameter("@Email", email)
                };
                DataTable resultTable = dtb.ReadData(query, parameters);
                if (resultTable.Rows != null && resultTable.Rows.Count > 0)
                {
                    int count = Convert.ToInt32(resultTable.Rows[0][0]);
                    return count > 0;
                }
            }
            catch(Exception ex) 
            {
                MessageBox.Show(ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return false;
        }

        public bool UpdatePasswordByEmail(string email, string newPassword)
        {
            try
            {
                string query = "UPDATE NHANVIEN SET PASSWORD = @NewPassword WHERE EMAIL = @Email";
                SqlParameter[] parameters = new SqlParameter[]
                {
                    new SqlParameter("@NewPassword", newPassword),
                    new SqlParameter("@Email", email)
                };
                return dtb.ChangeData(query, parameters);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }
    }
}
