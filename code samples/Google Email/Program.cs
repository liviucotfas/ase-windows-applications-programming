using System.Net.Mail;

namespace EmailSample
{
	internal class Program
    {
		private static void Main()
        {
            MailMessage mail = new MailMessage();
            System.Net.NetworkCredential cred = new System.Net.NetworkCredential("email", "password");
            mail.To.Add("lcotfas@gmail.com");
            mail.Subject = "TheSubject";
            mail.From = new MailAddress("email");
            mail.IsBodyHtml = true;
            mail.Body = "<b>Un mesaj aici</b>";
            mail.Attachments.Add(new Attachment("fisierDeTrimis.txt"));

            SmtpClient smtp = new SmtpClient("smtp.live.com");
            smtp.UseDefaultCredentials = false;
            smtp.EnableSsl = true;
            smtp.Credentials = cred;
            smtp.Port = 25;
            smtp.Send(mail);
        }
    }
}
