using System;

namespace QuanLyBanHoa.Models
{
    public class DonHang
    {
        public int MaDH { get; set; }
        public int MaKH { get; set; }
        public int MaNV { get; set; }
        public DateTime NgayDatHang { get; set; }
        public decimal TongTien { get; set; }
        public int? MaKM { get; set; } // Dấu ? cho phép giá trị null
    }
}