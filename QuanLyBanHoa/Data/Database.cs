using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms; // Thêm cái này để dùng MessageBox
using MySql.Data.MySqlClient;

namespace QuanLyBanHoa.Data
{
    public class Database
    {
        // Đã thêm 'charset=utf8mb4' để hỗ trợ tốt tiếng Việt
        private static readonly string connectionString =
            "server=localhost;uid=root;pwd=Duy@2005;database=quanlybanhoa;charset=utf8mb4;";

        /// <summary>
        /// Trả về một kết nối MySQL mới.
        /// </summary>
        public static MySqlConnection GetConnection()
        {
            return new MySqlConnection(connectionString);
        }

        /// <summary>
        /// Kiểm tra xem thông tin kết nối có đúng không.
        /// </summary>
        public static bool TestConnection()
        {
            using (var conn = GetConnection())
            {
                try
                {
                    conn.Open();
                    return true;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Kết nối thất bại: " + ex.Message, "Lỗi Database", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
            }
        }
    }
}