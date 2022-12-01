using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace QuizServer
{
    internal class MailServices
    {
        // Properties
        private string email;

        //Constructor
        public MailServices()
        {
            this.email = null;
        }
        public MailServices(string email)
        {
            this.email = email;
        }
        public void sendMail(string captcha)
        {
            var smtpClient = new SmtpClient("smtp.gmail.com")
            {

                Port = 587,
                Credentials = new NetworkCredential("voquocduy32@gmail.com", "izkekwucmaveomqh"),
                EnableSsl = true,
            };           
            smtpClient.Send("voquocduy32@gmail.com", email, "Hệ Thống Gửi Bạn Mã Xác Nhận",
                "Chào Mừng Đến Với Hệ Thống Thi Trắc Nghiệm\r\n Vui Lòng Liên Hệ: https://www.facebook.com/huytran9191 "
                    + "Nếu Cần Hỗ Trợ \r\n Mã Xác Nhận Của Bạn: " + captcha + "\r\n Xin Chào Và Cảm Ơn ^_^");
        }
    }
}
