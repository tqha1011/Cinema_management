using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Net.Mail;
using System.Windows.Forms;

namespace Cinema_management.Log_in
{
    public class EmailServices
    {
        private static string senderEmail = "quangha10112006@gmail.com";
        private static string senderPassword = "camk ehgu gkkm konk";

        public static async Task<bool> SendEmailAsync(string recipientEmail, string subject, string body)
        {
            try
            {
                using (var client = new SmtpClient("smtp.gmail.com", 587))
                {
                    client.EnableSsl = true;
                    client.Credentials = new NetworkCredential(senderEmail, senderPassword);
                    var mailMessage = new MailMessage
                    {
                        From = new MailAddress(senderEmail),
                        Subject = subject,
                        Body = body,
                        IsBodyHtml = true,
                    };
                    mailMessage.To.Add(recipientEmail);
                    await client.SendMailAsync(mailMessage);
                }
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }
    }
}
