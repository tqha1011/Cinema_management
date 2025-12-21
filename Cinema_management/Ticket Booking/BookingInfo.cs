using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cinema_management.Ticket_Booking
{
    /////////// CLASS LƯU THÔNG TIN TẠM CỦA HÓA ĐƠN
    public class BookingInfo
    {
        public int MaSuatChieu { get; set; }
        public string TenPhim { get; set; }
        public string TenPhong { get; set; }
        public DateTime ThoiGianChieu { get; set; }
        public decimal GiaVe {  get; set; }
        public int MaNhanVien { get; set; } //lay tu session dang nhap

        public List<string> DanhSachGhe { get; set; } = new List<string>();

        // Ds đồ ăn (key: mã đồ ăn, value: số lượng)
        public Dictionary<int, int> DanhSachDoAn { get; set; } = new Dictionary<int, int>();
        
        // DS phụ để hiển thị tên và giá ở bill cuối
        public Dictionary<int, decimal> GiaDoAn { get; set; } = new Dictionary<int, decimal>();
        public Dictionary<int, string> TenDoan { get; set; } = new Dictionary<int, string>();

        public decimal TongTienDoAn { get; set; } = 0;

        public decimal TongTienVe => DanhSachGhe.Count * GiaVe;
        public decimal TongTien => (DanhSachGhe.Count * GiaVe) + TongTienDoAn;
    }
}
