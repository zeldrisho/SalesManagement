using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using BUS_QLBanHang;
namespace GUI_QLBanHang
{
    public partial class SendMail : Form
    {
        public SendMail(string email , string pass,bool isUpdate = false)
        {
            InitializeComponent();
            this.email = email;
            this.password = pass;
            this.isUpdate = isUpdate;
        }
        
        private string result = "";
        public string getResult { get { return result; } }
        private string email; // email cần gửi tin
        private string password; // mật khẩu đăng nhập phần mềm
        private bool isUpdate;
        private void SendMail_Load(object sender, EventArgs e)
        {
            Thread r = new Thread(send);
            r.IsBackground = true;
            r.Start();
        }
        private void send()
        {
            // login email để gửi tin 
            // tự thay tài khoản email và password của tài khoản gmail mún gửi tin 
            // nhớ cho phép login ứng dụng kém an toàn nhá
            string loginEmail = "sof205.ps16903@gmail.com";
            string loginPassword = "thanhnps16903";
            BUS_Mail mail = new BUS_Mail(loginEmail, loginPassword); // tạo đối tượng để gửi mail truyền tk,pass để login
            result = mail.sendMail(email, password,isUpdate) ; // nếu là cập nhật mật khẩu thì true, còn nếu là mật khẩu thì false;
            pictureBox1.Invoke(new Action(() => Close()));
        }
    }
}
