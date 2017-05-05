using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Net.Mail;
using System.Net;
using System.Configuration;

namespace WebApplication1.Logic
{
    public class GmailLogic
    {

        public void SendMail(String correo,String asunto,String contenido)
        {
            var fromAddress = new MailAddress(ConfigurationManager.AppSettings["CorreoSistema"].ToString(), "Arqui");
            var toAddress = new MailAddress(correo, asunto);
            string fromPassword = ConfigurationManager.AppSettings["ClaveCorreoSistema"].ToString();
            string subject = asunto;
            string body = contenido;

            var smtp = new SmtpClient
            {
                Host = "smtp.gmail.com",
                Port = 587,
                EnableSsl = true,
                DeliveryMethod = SmtpDeliveryMethod.Network,
                Credentials = new NetworkCredential(fromAddress.Address, fromPassword),
                Timeout = 20000
            };
            using (var message = new MailMessage(fromAddress, toAddress)
            {
                Subject = subject,
                Body = body
            })
            {
                smtp.Send(message);
            }
        }
    }
}