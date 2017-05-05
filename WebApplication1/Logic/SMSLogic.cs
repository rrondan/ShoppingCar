using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;
using Twilio;
namespace WebApplication1.Logic
{
    public class SMSLogic
    {
        public void EnviarMensaje(String numero, String mensaje)
        {
            string AccountSid = ConfigurationManager.AppSettings["TwilioAuthSID"].ToString();
            string AuthToken = ConfigurationManager.AppSettings["TwilioAuthTOKEN"].ToString();

            var twilio = new TwilioRestClient(AccountSid, AuthToken);
            twilio.SendSmsMessage("+15037665054", numero, mensaje);


        }
    }
}