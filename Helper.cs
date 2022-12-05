using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp1
{
    public class Helper
    {
        public static string SenttMsg(string to, string subject, string body, out bool result)
        {
            try
            {
                //Подготовили письмо
                MailMessage msg = new MailMessage();
            msg.From = new MailAddress("Fedotov.a@gmail.com", "Fedotov Anton");

            msg.To.Add(to);
            //msg.CC.Add("");
            msg.Subject = subject;
            msg.Priority = MailPriority.High;
            msg.Body = body;
            //msg.IsBodyHtml = true;

            SmtpClient smtp = new SmtpClient();
            smtp.Host = "smtp.gmail.com";
            smtp.Port = 587;
            smtp.DeliveryMethod = SmtpDeliveryMethod.Network;
            smtp.Credentials = new NetworkCredential("login", "password");

            //отправляем письмо
            
                smtp.Send(msg); //отправь письмо
                result = true;
                return "Сообщение отправлено";
            }
            catch (Exception ex)
            {
                result = false;
                return ex.Message;
            }

        }
    }
}
