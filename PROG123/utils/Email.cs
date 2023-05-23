using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Threading.Tasks;

namespace PROG123.utils
{
    public class Email
    {
        public void SendEmail(string to, string subject, string body)
        {
            try
            {
                // create a MailMessage object
                MailMessage mail = new MailMessage();

                // your own gmail credentials
                string senderEmail = "some.email@gmail.com"; // a valid gmail email
                string senderPasswd = "password goes here"; // a valid password for the email above

                /*
                Note: Gmail has a setting for a less secure authentication. If this is turn off, you 
                may not be able to send an email from your gmail. Use this link to turn on and off.
                https://support.google.com/accounts/answer/6010255?hl=en-GB
            
                */

                // build the email
                mail.From = new MailAddress(senderEmail);
                mail.To.Add(to.ToString());
                mail.Subject = subject;
                mail.Body = body;

                // set it to tru if you want HTML
                mail.IsBodyHtml = true;

                // in case you want to attach a file
                //mail.Attachments.Add(new Attachment("C:\\someFile.jpg"));

                // SMTP Client for gmail only. Other emails will have different SMTP Clients.
                SmtpClient smtp = new SmtpClient("smtp.gmail.com", 587); // port 587

                // set the credentials
                smtp.Credentials = new NetworkCredential(senderEmail, senderPasswd);
                smtp.EnableSsl = true;

                // send the email
                smtp.Send(mail);
            }
            catch (Exception exp)
            {
                // do something with the exception y


            }

            
        }
    }
}
