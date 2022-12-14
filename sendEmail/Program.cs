using System;
using MailKit.Net.Smtp;
using MailKit;
using MimeKit;
//System.Net.Mail.Attachment attachment;

namespace TestClient
{
    class Program
    {
        public static void Main(string[] args)
        {
            var email = new MimeMessage();

            email.From.Add(new MailboxAddress("Secret Santa", "ksezim2002@gmail.com"));
            email.To.Add(new MailboxAddress("Who are you???", "ksezim2002@gmail.com"));

            email.Subject = "Yo-Ho! Давай узнаем кому ты будешь дарить подарок))) ";
            email.Body = new TextPart(MimeKit.Text.TextFormat.Html)
            {
                Text = "<b>Ты будещь дарить подарок </b>"
            };
            //System.Net.Mail.Attachment attachment;
            //attachment = new System.Net.Mail.Attachment("drfvde");
            //email.Attachments.Add(attachment);
           // email.Attachments.Add(new  System.Net.Mail.Attachment("D://temlog.txt"));
            using (var smtp = new SmtpClient())
            {
                smtp.Connect("smtp.gmail.com", 587, false);

                
                smtp.Authenticate("ksezim2002@gmail.com", "tgbtoibrlfoftwvm");

                smtp.Send(email);
                smtp.Disconnect(true);
            }
        }
    }
}
