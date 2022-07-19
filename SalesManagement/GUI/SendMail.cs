using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using BUS;

namespace GUI
{
    public partial class SendMail : Form
    {
        private string result = "";
        public string getResult { get { return result; } }
        private string email; // email cần gửi tin
        private string password; // mật khẩu đăng nhập phần mềm
        private bool isUpdate;

        public SendMail()
        {
            InitializeComponent();
        }

        public SendMail(string email, string pass, bool isUpdate = false)
        {
            InitializeComponent();
            this.email = email;
            this.password = pass;
            this.isUpdate = isUpdate;
        }

        private void SendMail_Load(object sender, EventArgs e)
        {
            Thread r = new Thread(Send);
            r.IsBackground = true;
            r.Start();
        }
        private void Send()
        {
            // Tự thay email và password của tài khoản gmail dùng để gửi
            // Nhớ cho phép login ứng dụng kém an toàn (nếu tìm không thấy thì dùng mail edu)
            string loginEmail = "2024801030101@student.tdmu.edu.vn";
            string loginPassword = "Trung@tftmobile";
            // Tạo đối tượng để gửi mail truyền email, pass để login
            BUS_Mail mail = new BUS_Mail(loginEmail, loginPassword);
            // Nếu là cập nhật mật khẩu thì true, còn nếu là mật khẩu thì false
            result = mail.SendMail(email, password, isUpdate);
            pcbLoader.Invoke(new Action(() => Close()));
        }
    }
}
