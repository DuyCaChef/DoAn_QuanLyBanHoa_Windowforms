namespace QuanLyBanHoa
{
    // Lưu thông tin phiên làm việc hiện tại của người dùng
    public static class Session
    {
        public static string UserName { get; set; } = "";
        public static string Role { get; set; } = ""; // Ví dụ: "Admin", "NhanVien"
        public static bool IsLoggedIn { get; set; } = false;
        public static int UserId { get; set; } = -1; // Lưu thêm ID để tiện truy vấn

        // Hàm xóa session khi đăng xuất
        public static void Clear()
        {
            UserName = "";
            Role = "";
            IsLoggedIn = false;
            UserId = -1;
        }
    }
}