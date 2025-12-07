using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;
using Cinema_management.DAL;
using Cinema_management.MessageboxCustom;
using Cinema_management.MessageboxCustom.Utils;

namespace Cinema_management.Food_and_Beverage
{
    public class FoodLogic
    {
        private Database dtb;
        public FoodLogic()
        {
            dtb = new Database();
        }

        public bool ValidateInformation(Food newFood)
        {
            // kiem tra ten co hop le khong
            if (string.IsNullOrEmpty(newFood.Name))
            {
                Alert.Show("Tên đồ ăn không được để trống!", MessagboxCustom.AlertMessagebox.AlertType.Error);
                return false;
            }

            // kiem tra gia tien co hop le khong
            if (newFood.Money < 0)
            {
                Alert.Show("Giá đồ ăn không hợp lệ!", MessagboxCustom.AlertMessagebox.AlertType.Error);
                return false;
            }

            // kiem tra so luong
            if (newFood.Quantity < 0)
            {
                Alert.Show("Số lượng đồ ăn không hợp lệ!", MessagboxCustom.AlertMessagebox.AlertType.Error);
                return false;
            }
            // kiem tra ma loai do an co khop khong
            if(newFood.Type <= 0)
            {
                Alert.Show("Loại đồ ăn không hợp lệ!", MessagboxCustom.AlertMessagebox.AlertType.Error);
                return false;
            }
            return true;
        }

        #region Add Food
        public bool AddFood(Food newFood,int ID = 0)
        {
            bool success = false;
            if (ValidateInformation(newFood))
            {
                string query = "INSERT INTO DOAN(TENDOAN,GIADOAN,MOTADOAN,MALOAIDOAN,ANHDOAN)" +
                               "VALUES(@Name,@Price,@Description,@Type,@Image); " +
                               "DECLARE @NewID INT = SCOPE_IDENTITY(); " +
                               
                               "INSRT INTO KHODOAN(MADOAN,SOLUONG) " +
                               "VALUES(@NewID, @Quantity)";
                SqlParameter[] sqlParameter = new SqlParameter[]
                {
                        new SqlParameter("@Name",newFood.Name),
                        new SqlParameter("@Price",newFood.Money),
                        new SqlParameter("@Description", (object)newFood.Description ?? DBNull.Value),
                        new SqlParameter("@Type",newFood.Type),
                        new SqlParameter("@Image", newFood.imgFood),
                        new SqlParameter("@Quantity", newFood.Quantity)
                };
                return dtb.ChangeData(query, sqlParameter);
            }
            else
            {
                return false;
            }
        }
        #endregion

        #region Update food
        public bool UpdateFood(Food updateFood, int ID)
        {
            // kiem tra du lieu truoc khi update
            if (ValidateInformation(updateFood))
            {
                string query = "UPDATE DOAN " +
                               "SET TENDOAN = @Ten,GIADOAN = @Price,MOTADOAN = @Desciption," +
                               "MALOAIDOAN = @Type, ANHDOAN = @Img" +
                               "WHERE MADOAN = @Id";
                // khoi tao tham so
                SqlParameter[] sqlParameters = new SqlParameter[]
                {
                        new SqlParameter("@Ten", updateFood.Name),
                        new SqlParameter("@Price", updateFood.Money),
                        new SqlParameter("@Description", (object)updateFood.Description ?? DBNull.Value),
                        new SqlParameter("@Type", updateFood.Type),
                        new SqlParameter("@Img", updateFood.imgFood),
                        new SqlParameter("@Id", ID)
                };
                return dtb.ChangeData(query, sqlParameters);
            }
            else
            {
                return false;
            }
        }
        #endregion

        #region Get Food Details
        public Food GetDetails(int ID)
        {
            string query = "SELECT d.*, k.SOLUONG " +
                           "FROM DOAN d JOIN LOAIDOAN l ON d.MADOAN = l.MADOAN " +
                           "WHERE MADOAN = @Id";
            SqlParameter[] sqlParameter = new SqlParameter[]
            {
                new SqlParameter("@Id",ID)
            };
            DataTable table = dtb.ReadData(query, sqlParameter);
            if(table.Equals(null) || table.Rows.Count == 0)
            {
                return null; // tra ve null neu khong co do an trong database
            }
            else
            {
                DataRow row = table.Rows[0];
                Food food = new Food();
                food.Id = Convert.ToInt32(row["MADOAN"]);
                food.Name = row["TENDOAN"].ToString();

                // kiem tra du lieu
                if (row["GIADOAN"] != DBNull.Value)
                {
                    food.Money = Convert.ToDecimal(row["GIADOAN"]);
                }
                food.Description = row["MOTADOAN"].ToString();

                // kiem tra du lieu
                if (row["MALOAIDOAN"] != DBNull.Value)
                {
                    food.Type = Convert.ToInt32(row["MALOAIDOAN"]);
                }

                food.imgFood = row["ANHDOAN"].ToString();

                if (table.Columns.Contains("SOLUONG") && row["SOLUONG"] != DBNull.Value)
                {
                    food.Quantity = Convert.ToInt32(row["SOLUONG"]);
                }
                else
                {
                    food.Quantity = 0;
                }
                return food;
            }
        }
        #endregion

        #region Delete Food
        public bool DeleteFood(int ID)
        {
            // dùng update để sau này có thống kê dính món ngừng bán thì không bị crash
            string query = "UPDATE DOAN SET SELLING = 0 WHERE MADOAN = @Id";
            SqlParameter[] sqlParameters = new SqlParameter[]
            {
                new SqlParameter("@Id",ID)
            };
            return dtb.ChangeData(query, sqlParameters);
        }
        #endregion

        #region Get Type of Food

        public DataTable GetFoodTypes()
        {
            string query = "SELECT * FROM LOAIDOAN";
            DataTable table = dtb.ReadData(query, null);
            if(table.Equals(null) || table.Rows.Count == 0)
            {
                return null;
            }
            else
            {
                return table;
            }
        }
        #endregion
    }
}
