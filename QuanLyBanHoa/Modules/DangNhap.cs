using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Collections.Specialized.BitVector32;

namespace QuanLyBanHoa.Modules
{
    public partial class DangNhap : Form
    {
        public DangNhap()
        {
            InitializeComponent();
        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            string username = txtEmail.Text.Trim();
            string password = txtPass.Text.Trim();

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

                //FrmMain frmMain = new FrmMain();  Mở form chính
                //frmMain.Show();
                //this.Hide(); //Ẩn form đăng nhập
            }
            else if (username == staffUsername && password == staffPassword)
            {
                Session.UserName = username;
                Session.Role = "Nhân viên";
                Session.IsLoggedIn = true;

                MessageBox.Show("Đăng nhập thành công với vai trò Nhân viên!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                //FrmMain frmMain = new FrmMain();  Mở form chính
                //frmMain.Show();
                //this.Hide(); //Ẩn form đăng nhập
            }
            else
            {
                MessageBox.Show("Tên đăng nhập hoặc mật khẩu không đúng. Vui lòng thử lại.", "Lỗi đăng nhập", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void ckbHienMK_CheckedChanged(object sender, EventArgs e)
        {
            if (ckbHienMK.Checked)
            {
                txtPass.UseSystemPasswordChar = false; //Hiện mật khẩu
            }
            else
            {
                txtPass.UseSystemPasswordChar = true; //Ẩn mật khẩu
            }
        }
    }
}
