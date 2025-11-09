namespace QuanLyBanHoa.Models
{
    public class NhanVien
    {
        public int MaNV { get; set; }
        public string TenNV { get; set; }
        public string ChucVu { get; set; }
        public string SoDienThoai { get; set; }
        // Thêm 2 thuộc tính này nếu đã cập nhật DB cho chức năng đăng nhập
        // public string Email { get; set; }
        // public string MatKhau { get; set; }
    }
}