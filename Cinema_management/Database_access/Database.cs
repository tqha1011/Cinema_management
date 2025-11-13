using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Configuration;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cinema_management.DAL
{
    internal class Database
    {
        private string connectionString; // Chuỗi kết nối đến cơ sở dữ liệu

        // Constructor để khởi tạo chuỗi kết nối từ App.config
        public Database()
        {
            string connectionName = "Azure";  // Tên chuỗi kết nối trong App.config

            // Code bên dưới lấy chuỗi kết nối từ App.config
            // try - catch để không crash chương trình nếu không tìm thấy chuỗi kết nối
            try
            {
                connectionString = ConfigurationManager.ConnectionStrings[connectionName].ConnectionString;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Không tìm thấy chuỗi kết nối '{connectionName}' trong App.config" + ex.Message,"Lỗi cấu hình",MessageBoxButtons.OK, MessageBoxIcon.Error);
                connectionString = null;
            }
        }

        public SqlConnection GetConnection()
        {
            if (string.IsNullOrEmpty(connectionString))
            {
                throw new InvalidOperationException("Chuỗi kết nối không hợp lệ.");
            }
            return new SqlConnection(connectionString);
        }

        public DataTable ReadData(string query, SqlParameter[] parameters = null)
        {
            DataTable dataTable = new DataTable();
            if(string.IsNullOrEmpty(connectionString))
            {
                return dataTable;
            }

            try
            {
                // dung using để tự động dong kết nối
                using (SqlConnection connection = new SqlConnection(connectionString)) // Khởi tạo kết nối
                {
                    connection.Open(); // Mở kết nối
                    using (SqlCommand command = new SqlCommand(query, connection)) // Tạo command với câu truy vấn và kết nối
                    {
                        if(parameters != null) //nếu có tham số truyền vào thì thêm vào command
                        {
                            command.Parameters.AddRange(parameters);
                        }
                        using(SqlDataAdapter adapter = new SqlDataAdapter(command)) // SqlDataAdapter để điền dữ liệu vào DataTable
                        {
                            adapter.Fill(dataTable); // Đổ dữ liệu vào DataTable
                        }
                    }
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("Lỗi khi đọc dữ liệu: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return dataTable;
        }

        public bool ChangeData(string query, SqlParameter[] parameters = null)
        {
            bool success = false;
            if (string.IsNullOrEmpty(connectionString)) // kiểm tra chuỗi kết nối
            {
                return success;
            }
            // try - catch để tránh crash chương trình khi có lỗi thao tác dữ liệu
            try
            {
                using(SqlConnection connection = new SqlConnection(connectionString)) // khởi tạo kết nối
                {
                    connection.Open(); // mờ kết nối
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        if(parameters != null) // nếu có tham số truyền vào thì thêm vào command đã tạo
                        {
                            command.Parameters.AddRange(parameters);
                        }
                        int rowsAffected = command.ExecuteNonQuery(); // thực thi lệnh và trả về số hàng thay đổi

                        if (rowsAffected > 0) // Trả về true nếu có ít nhất một hàng bị thay đổi
                        {
                            success = true;
                        }
                    }
                }
            }
            catch(SqlException sqlEx) // bắt lỗi SQL cụ thể
            {
                if(sqlEx.Number == 2627 || sqlEx.Number == 2601) // lỗi vi phạm thuộc tính UNIQUE hoặc khóa chính
                {
                    MessageBox.Show("Lỗi: Dữ liệu bị trùng lặp", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    success = false;
                }
                else
                {
                    MessageBox.Show("Lỗi SQL khi thay đổi dữ liệu: " + sqlEx.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    success = false;
                }
            }
            catch (Exception ex) // bắt mọi loại lỗi
            {
                MessageBox.Show("Lỗi khi thay đổi dữ liệu: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                success = false;
            }
            return success;
        }
    }
}
