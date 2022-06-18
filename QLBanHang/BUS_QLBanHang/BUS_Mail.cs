using System;
using System.Net;
using System.Net.Mail;
using System.Text;

namespace BUS_QLBanHang
{
    public class BUS_Mail
    {
        private string loginEmail;
        private string loginPass;

        public BUS_Mail(string loginEmail, string loginPass)
        {
            this.loginEmail = loginEmail;
            this.loginPass = loginPass;
        }

        public string sendMail(string recipientEmail, string recipientPass, bool isUpdate = false)
        {
            try
            {
                MailMessage message = new MailMessage();
                message.From = new MailAddress(loginEmail);
                message.To.Add(recipientEmail);
                if (isUpdate)
                {
                    message.Body = "Chào bạn, mật khẩu mới truy cập vào phần mềm của bạn là: " + recipientPass;
                    message.Subject = "Bạn đã yêu cầu cấp lại mật khẩu!";
                }
                else
                {
                    message.Body = string.Format("Chào mừng bạn đã được thêm vào danh sách nhân viên của phần mềm với " +
                                                 "thông tin đăng nhập là: \n- Email: {0} \n- Mật khẩu: {1} ", recipientEmail, recipientPass);
                    message.Subject = "Thông tin đăng nhập phần mềm!";
                }

                using (SmtpClient client = new SmtpClient())
                {
                    client.EnableSsl = true;
                    client.UseDefaultCredentials = false;
                    client.Credentials = new NetworkCredential(loginEmail, loginPass);
                    client.Host = "smtp.gmail.com";
                    client.Port = 587;
                    client.DeliveryMethod = SmtpDeliveryMethod.Network;
                    client.Send(message);
                }
                return "Vui lòng kiểm tra Email để nhận mật khẩu mới!";
            }
            catch (Exception e)
            {
                return e.Message;
            }
        }

        public string getPassword()
        {
            Random r = new Random();
            StringBuilder builder = new StringBuilder();
            builder.Append(randomString(4, true));
            builder.Append(r.Next(1000, 9999));
            builder.Append(randomString(2, false));
            return builder.ToString();
        }

        private string randomString(int size, bool lowerCase)
        {
            StringBuilder builder = new StringBuilder();
            Random r = new Random();
            char ch;
            for (int i = 0; i < size; i++)
            {
                ch = Convert.ToChar(Convert.ToInt32(Math.Floor(26 * r.NextDouble() + 65)));
                builder.Append(ch);
            }
            if (lowerCase)
            {
                return builder.ToString().ToUpper();
            }
            else return builder.ToString().ToLower();
        }
    }
}
