using System;
using System.Collections.Generic;
using System.Text;
using System.Net.Mail;
namespace Shop.Services
{
    public class MessageSender
    {
        public void Send(string emailText, string emailSubject, string emailFrom, string emailTo, string emailPassword)
        {
            MailMessage mail = new MailMessage();
            SmtpClient SmtpServer = new SmtpClient("smtp.gmail.com");

            mail.From = new MailAddress(emailFrom);
            mail.To.Add(emailTo);
            mail.Subject = emailSubject;
            mail.Body = emailText;

            SmtpServer.Port = 587;
            SmtpServer.Credentials = new System.Net.NetworkCredential(emailFrom, emailPassword);
            SmtpServer.EnableSsl = true;

            SmtpServer.Send(mail);
        }
    }
}
