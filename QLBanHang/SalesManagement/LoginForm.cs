using BusinessLogic;
using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;

namespace SalesManagement
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            //Lấy thông tin Tên đăng nhập (UserId) người dùng nhập vào
            var userId = txtUserId.Text;

            //Lấy thông tin Mật khẩu (Password) người dùng nhập vào
            var password = txtPassword.Text;

            ILoginService biz = new LoginService();
            
            var returnValue = biz.Login(userId, password);

            if (returnValue == 1)
            {
                MessageBox.Show("Đăng nhập thành công");
            }
            else
            {
                MessageBox.Show("Đăng nhập thất bại");
            }
        }
    }
}