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
                                  (Helper.getMailInfo("MailSenderUserName"),
                                   Helper.getMailInfo("MailSenderPassword"));
            Client.Host = Helper.getMailInfo("MailSenderSmtpServer");
            Client.Port = 587;
            Client.EnableSsl = true;

            return Client;
        }
        private string GetMailContent(User user, UserOrder order)
        {
            string Content = $"<h1> {user.FirstName} dziękujemy za złożenie zamówienia! </h1>";
            Content += $"<h2>Oto twoje zamówienie:</h2>";
            Content += "<ul>";
            List<MenuItem> OrderItems = order.ParseUserOrder();
            
            for(int index = 0; index < OrderItems.Count; index++)
            {
                Content += $"<li>{OrderItems[index].FullInfo}</li>";
            }

            Content += "</ul>";
            Content += $"<p>Uwagi do zamówienia: {order.OrderComments}</p>";
            return Content;
        }

        private MailMessage GetMailMessage(User user, UserOrder order)
        {
            MailMessage OrderMsg = new MailMessage();
            OrderMsg.To.Add(user.EMail);
            OrderMsg.From = new MailAddress(Helper.getMailInfo("FromEmail"),
                                       Helper.getMailInfo("FromDisplayName"));
            OrderMsg.Subject = $"Zamówienie w {Helper.getMailInfo("FromDisplayName")}";
            OrderMsg.IsBodyHtml = true;
            OrderMsg.Body = GetMailContent(user, order);

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
                MessageBox.Show($"Wysłanie wiadomości nie powiodło się {ex.Message}");
            }
            OrderMsg.Dispose();
        }
    }
}

    