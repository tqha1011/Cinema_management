using Cinema_management.DAL;
using Cinema_management.MessagboxCustom;
using Cinema_management.MessageboxCustom.Utils;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cinema_management.Log_in
{
    public class AuthLogic
    {
        private Database dtb;
        public AuthLogic()
        {
            dtb = new Database();
        }

        public class LoginResult
        {
            public int MaNV { get; set; } = -1;
            public string HoTen { get; set; } = "";
        }

        //public int AuthenticateUser(string username, string password, string role)
        public LoginResult GetEmployeeID(string username, string password, string role)
        {
            LoginResult result = new LoginResult();
            try
            {
                //string query = "SELECT COUNT(*) FROM NHANVIEN WHERE USERNAME = @username AND PASSWORD = @password AND VAITRO = @role AND WORKING = 1";
                string query = "SELECT MANV, HOTEN FROM NHANVIEN WHERE USERNAME = @username AND PASSWORD = @password AND VAITRO = @role AND WORKING = 1";
                SqlParameter[] parameters = new SqlParameter[]
                {
                    new SqlParameter("@username", username),
                    new SqlParameter("@password", password),
                    new SqlParameter("@role", role)
                };

                var resultTable = dtb.ReadData(query, parameters);
                if (resultTable.Rows != null && resultTable.Rows.Count > 0)
                {
                    //int count = Convert.ToInt32(resultTable.Rows[0][0]);
                    //return count > 0;

                    result.MaNV = Convert.ToInt32(resultTable.Rows[0]["MANV"]);
                    result.HoTen = resultTable.Rows[0]["HOTEN"].ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return result;
        }
    }
}
