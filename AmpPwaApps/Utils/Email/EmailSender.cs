using AmpPwaApps.Utils.Email;
using MailKit.Net.Smtp;
using MimeKit;
using System;

namespace AmpPwaApps.Utils
{
    public static class EmailSender
    {
        private const string SMTP_SERVER_EMAIL = "macaw.amp.sender@gmail.com";
        private const string SMTP_SERVER_PASS = "mac2wsome!";
        public static void SendEmail(EmailSettings settings)
        {
            try
            {             
                var mimeMessage = new MimeMessage();
                mimeMessage.From.Add(new MailboxAddress(settings.FromAdressTitle, settings.FromAddress));
                mimeMessage.To.Add(new MailboxAddress(settings.ToAddressTitle, settings.ToAddress));
                mimeMessage.Subject = settings.Subject;
                mimeMessage.Body = new TextPart("plain")
                {
                    Text = settings.BodyContent
                };

                using (var client = new SmtpClient())
                {
                    client.Connect(settings.SmtpServer, settings.SmtpPortNumber, false);
                    // Note: only needed if the SMTP server requires authentication  
                    // Error 5.5.1 Authentication   
                    client.Authenticate(SMTP_SERVER_EMAIL, SMTP_SERVER_PASS);
                    client.Send(mimeMessage);                   
                    client.Disconnect(true);
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
