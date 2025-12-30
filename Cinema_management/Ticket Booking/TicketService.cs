using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Cinema_management.MessageboxCustom.Utils;
using Cinema_management.Ticket_Booking;
using Cinema_management.MessageboxCustom;

namespace Cinema_management.Services
{
    /////////// CLASS THỰC HIỆN LƯU XUỐNG DATABASE 
    public class TicketService
    {
        string connectionString = ConfigurationManager.ConnectionStrings["Azure"].ConnectionString;

        public bool LuuGiaoDich(BookingInfo bookingData)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                SqlTransaction transaction = conn.BeginTransaction(); //bắt đầu giao dịch

                try
                {
                    ////TẠO HÓA ĐƠN
                    string queryHD = @"INSERT INTO HOADON (NGAYLAP, TONGTIEN, MANV, DATHANHTOAN)
                                        VALUES (GETDATE(), @Tong, @MaNV, 1);
                                        SELECT SCOPE_IDENTITY()";

                    SqlCommand cmdHD = new SqlCommand(queryHD, conn, transaction);
                    cmdHD.Parameters.AddWithValue("@Tong", bookingData.TongTien);
                    cmdHD.Parameters.AddWithValue("@MaNV", bookingData.MaNhanVien);

                    // lấy ID của hóa đơn vừa tạo
                    int maHD = Convert.ToInt32(cmdHD.ExecuteScalar());

                    //// TẠO VÉ
                    foreach (string ghe in bookingData.DanhSachGhe)
                    {
                        // Tìm ID ghế từ tên ghế
                        string queryGetID = @"SELECT G.MAGHE FROM GHE G
                                               JOIN SUATCHIEU S ON G.MAPHONG = S.MAPHONG
                                               WHERE S.MASUATCHIEU = @MaSC AND G.TENGHE = @TenGhe";

                        SqlCommand cmdGetID = new SqlCommand(queryGetID, conn, transaction);
                        cmdGetID.Parameters.AddWithValue("@MaSC", bookingData.MaSuatChieu);
                        cmdGetID.Parameters.AddWithValue("@TenGhe", ghe);

                        object result = cmdGetID.ExecuteScalar();
                        if (result == null)
                            throw new Exception($"Lỗi không tìm thấy tên ghê {ghe}");
                        int maGhe = Convert.ToInt32(result);

                        // INSERT Vé 
                        try
                        {
                            string queryVe = @"INSERT INTO VE (MASUATCHIEU, MAHOADON, MAGHE, GIAVE, TRANGTHAIVE)
                                           VALUES (@MaSC, @MaHD, @MaGhe, @Gia, N'Đã bán')";

                            SqlCommand cmdVe = new SqlCommand(queryVe, conn, transaction);
                            cmdVe.Parameters.AddWithValue("@MaSC", bookingData.MaSuatChieu);
                            cmdVe.Parameters.AddWithValue("@MaHD", maHD);
                            cmdVe.Parameters.AddWithValue("@MaGhe", maGhe);
                            cmdVe.Parameters.AddWithValue("@Gia", bookingData.GiaVe);
                            cmdVe.ExecuteNonQuery();
                        }
                        catch (SqlException ex)
                        {
                            if(ex.Number == 2627 || ex.Number == 2601) // MÃ LỖI TRÙNG KHÓA CHÍNH
                            {
                                throw new Exception("Ghế " + ghe + " đã được bán. Vui lòng chọn ghế khác.");
                            }
                        }
                    }

                    //// TẠO CHI TIẾT ĐỒ ĂN
                    if (bookingData.DanhSachDoAn.Count > 0)
                    {
                        foreach (var item in bookingData.DanhSachDoAn)
                        {
                            int maDoan = item.Key;
                            int soLuongMua = item.Value;

                            string queryFood = @"INSERT INTO CHITIETHOADON (MAHOADON, MADOAN, SOLUONG, THANHTIEN)
                                                 VALUES (@MaHD, @MaDoan, @SL, @SL * (SELECT GIADOAN 
                                                                                     FROM DOAN WHERE MADOAN = @MaDoan))";

                            SqlCommand cmdFood = new SqlCommand(queryFood, conn, transaction);
                            cmdFood.Parameters.AddWithValue("@MaHD", maHD);
                            cmdFood.Parameters.AddWithValue("@MaDoan", maDoan);
                            cmdFood.Parameters.AddWithValue("@SL", soLuongMua);
                            cmdFood.ExecuteNonQuery();

                            string queryUpdateKho = @"UPDATE KHODOAN 
                                                      SET SOLUONG = SOLUONG - @SLMua 
                                                      WHERE MADOAN = @MaDoanKho";

                            SqlCommand cmdKho = new SqlCommand(queryUpdateKho, conn, transaction);
                            cmdKho.Parameters.AddWithValue("@SLMua", soLuongMua);
                            cmdKho.Parameters.AddWithValue("@MaDoanKho", maDoan);

                            int rowsAffected = cmdKho.ExecuteNonQuery();
                        }
                    }

                    //// NẾU THÀNH CÔNG --> commit
                    transaction.Commit();
                    return true;
                }
                catch (Exception ex)
                {
                    //// NẾU LỖI --> ROLLBACK
                    transaction.Rollback();
                    Alert.Show(ex.Message,MessagboxCustom.AlertMessagebox.AlertType.Error);
                    throw;
                }
            }
        }
    }
}
