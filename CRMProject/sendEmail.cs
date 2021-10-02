using MailKit.Net.Smtp;
using MimeKit;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Threading.Tasks;

namespace CRMProject
{
    public class sendEmail
    {
        static public void TryEmail(string email, string validationCodeMessage)
        {
            MimeMessage message = new MimeMessage();
            message.From.Add(new MailboxAddress("CRM System", "crmsystem99@gmail.com"));
            message.To.Add(MailboxAddress.Parse(email));
            message.Subject = "Forgot Password Code";

            var builder = new BodyBuilder();

            builder.TextBody = @validationCodeMessage;

            message.Body = builder.ToMessageBody();

            string emailAddress = "crmsystem99@gmail.com";
            string password = "dbcrmsystem";

            MailKit.Net.Smtp.SmtpClient client = new MailKit.Net.Smtp.SmtpClient();

            try
            {
                client.CheckCertificateRevocation = false;
                client.Connect("smtp.gmail.com", 465, true);
                client.Authenticate(emailAddress, password);
                client.Send(message);

                Console.WriteLine("Email Sent!");
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            finally
            {
                client.Disconnect(true);
                client.Dispose();
            }
        }
    }
}
