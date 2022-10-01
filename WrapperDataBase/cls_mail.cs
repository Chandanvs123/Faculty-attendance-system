using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net.Mail;

namespace WrapperDataBase
{
    public class cls_mail
    {
        public static int send_Mail_to_student(String to_Address, String username, String str_Pass)
        {


            try
            {
                //MailMessage mail = new MailMessage();
                //SmtpClient SmtpServer = new SmtpClient("smtp.gmail.com");

                //mail.From = new MailAddress("rajashekhara.hsn@gmail.com", "RIT");
                //mail.To.Add("rajashekhara.hsn@gmail.com");

                //mail.Subject = "User name and Password";
                //mail.Body = "You Have been Successfully Registered To Rajeev College" + Environment.NewLine + Environment.NewLine + "User Name : " + username + Environment.NewLine
                //    + " Password : " + str_Pass + Environment.NewLine + Environment.NewLine + " Warm Welcome form RIT";
                //// Attachment attachment = new Attachment(filename);
                ////mail.Attachments.Add(attachment);

                ////SmtpServer.Port = 25;
                ////SmtpServer.Credentials = new System.Net.NetworkCredential("rajashekhara.hsn@gmail.com", "rajaOmganeshaOmraja");
                ////SmtpServer.EnableSsl = true;

                //SmtpServer.Send(mail);

                SmtpClient smtpClient = new SmtpClient("smtp.gmail.com", 25);

                smtpClient.Credentials = new System.Net.NetworkCredential("rajashekhara.hsn@gmail.com", "d");
                smtpClient.UseDefaultCredentials = true;
                smtpClient.DeliveryMethod = SmtpDeliveryMethod.Network;
                smtpClient.EnableSsl = true;
                MailMessage mail = new MailMessage();

                //Setting From , To and CC
                mail.From = new MailAddress("rajashekhara.hsn@gmail.com", "MyWeb Site");
                mail.To.Add(new MailAddress("rajashekhara.hsn@gmail.com"));
                mail.CC.Add(new MailAddress("MyEmailID@gmail.com"));

                smtpClient.Send(mail);

                return 1;
            }
            catch (Exception ex)
            {
                return 0;
            }
        }

    }
}
