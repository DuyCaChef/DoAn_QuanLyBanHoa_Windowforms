using System;

namespace QuanLyBanHoa.Models
{
    public class KhuyenMai
    {
        public int MaKM { get; set; }
        public string TenCT { get; set; }
        public decimal TyLeGiam { get; set; }
        public DateTime NgayBD { get; set; }
        public DateTime NgayKT { get; set; }
    }
}