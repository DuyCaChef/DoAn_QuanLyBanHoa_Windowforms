using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyBanHoa.Modules
{
    public partial class frmDangNhap : Form
    {
        public frmDangNhap()
        {
            InitializeComponent();
        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            string username = txtEmail.Text.Trim();
            string password = txtPass.Text.Trim();

            // Kiểm tra thông tin không được để trống
            if (string.IsNullOrWhiteSpace(username))
            {
                MessageBox.Show("Vui lòng nhập email!", "Thiếu thông tin", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtEmail.Focus();
                return;
            }

            if (string.IsNullOrWhiteSpace(password))
            {
                MessageBox.Show("Vui lòng nhập mật khẩu!", "Thiếu thông tin", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtPass.Focus();
                return;
            }

            //Tài khoản cố định cho admin và nhân viên
            string adminUsername = "admin123@gmail.com";
            string adminPassword = "admin@123";

            string staffUsername = "staff123@gmail.com";
            string staffPassword = "staff@123";

            //Kiểm tra thông tin đăng nhập
            if (username == adminUsername && password == adminPassword)
            {
                Session.UserName = username;
                Session.Role = "Admin";
                Session.IsLoggedIn = true;

                MessageBox.Show("Đăng nhập thành công với quyền Admin!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Mở form Hoa
                Hoa frmHoa = new Hoa();
                frmHoa.Show();
                this.Hide(); // Ẩn form đăng nhập
            }
            else if (username == staffUsername && password == staffPassword)
            {
                Session.UserName = username;
                Session.Role = "Nhân viên";
                Session.IsLoggedIn = true;

                MessageBox.Show("Đăng nhập thành công với vai trò Nhân viên!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Mở form Hoa
                Hoa frmHoa = new Hoa();
                frmHoa.Show();
                this.Hide(); // Ẩn form đăng nhập
            }
            else
            {
                MessageBox.Show("Tên đăng nhập hoặc mật khẩu không đúng. Vui lòng thử lại.", "Lỗi đăng nhập", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtPass.Clear();
                txtPass.Focus();
            }
        }

        private void ckbHienMK_CheckedChanged(object sender, EventArgs e)
        {
            txtPass.UseSystemPasswordChar = !ckbHienMK.Checked;
        }

        // Xử lý sự kiện khi form Hoa đóng lại
        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            base.OnFormClosing(e);
            
            // Nếu đang đăng nhập và đóng form đăng nhập thì thoát ứng dụng
            if (!Session.IsLoggedIn)
            {
                Application.Exit();
            }
        }
    }
}
