using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Mail;
using System.Net.Mime;
using System.Configuration;
using System.Windows.Forms;

namespace PiizzeriaOrderApp
{
    public class EmailSender
    {
        private SmtpClient GetSmtp()
        {
            SmtpClient Client = new SmtpClient();
            Client.UseDefaultCredentials = false;
            Client.Credentials = new System.Net.NetworkCredential
                                  (ConfigurationManager.AppSettings.Get("MailSenderUserName"),
                                   ConfigurationManager.AppSettings.Get("MailSenderPassword"));
            Client.Host = ConfigurationManager.AppSettings.Get("MailSenderSmtpServer");
            Client.Port = 587;
            Client.EnableSsl = true;

            return Client;
        }
        private string GetMailContent(User user, UserOrder order)
        {
            string Content = $"Zamówienie nr {order.ID}: test";
            return Content;
        }

        private MailMessage GetMailMessage(User user, UserOrder order)
        {
            MailMessage OrderMsg = new MailMessage();
            OrderMsg.To.Add(user.EMail);
            OrderMsg.From = new MailAddress(ConfigurationManager.AppSettings.Get("FromEmail"),
                                       ConfigurationManager.AppSettings.Get("FromDisplayName"));
            OrderMsg.Subject = $"Zamówienie nr {order.ID}";
            OrderMsg.IsBodyHtml = true;
            OrderMsg.Body = GetMailContent(user, order); //add some content senpaaai

            return OrderMsg;
        }

        public void SendAnEmail(User user, UserOrder order)
        {
            SmtpClient Client = GetSmtp();
            MailMessage OrderMsg = GetMailMessage(user, order);

            try
            {
                Client.Send(OrderMsg);
                MessageBox.Show("Wysłanie zamówienia na e-mail powiodło się.");
            }
            catch(Exception ex)
            {
                MessageBox.Show($"Wysłanie wiadomości nie powiodło się {0}", ex.Message);
                throw;
            }
            OrderMsg.Dispose();
        }
    }
}

    