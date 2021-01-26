using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
namespace Bll
{
    public class EmailBll
    {
        public static void mail(string to, string body, string subject)
        {
            try
            {

                MailMessage mail = new MailMessage();
                SmtpClient SmtpServer = new SmtpClient("smtp.gmail.com");
                mail.From = new MailAddress("YoledetGroup@gmail.com");
                mail.To.Add(to);

                mail.Body = body;
                mail.Subject = subject;
                SmtpServer.Port = 587;
                SmtpServer.Credentials = new System.Net.NetworkCredential("YoledetGroup@gmail.com", "YG100100");
                SmtpServer.EnableSsl = true;

                SmtpServer.Send(mail);
            }
            catch (Exception e)
            {

            }

        }
        private static readonly Random _random = new Random();
        public static int RandomNumber(int min, int max)
        {
            return _random.Next(min, max);
        }
        public static string RandomString(int size, bool lowerCase = false)
        {
            var builder = new StringBuilder(size);
            char offset = lowerCase ? 'a' : 'A';
            const int lettersOffset = 26;

            for (var i = 0; i < size; i++)
            {
                var @char = (char)_random.Next(offset, offset + lettersOffset);
                builder.Append(@char);
            }

            return lowerCase ? builder.ToString().ToLower() : builder.ToString();
        }
        public static string RandomPassword()
        {
            var passwordBuilder = new StringBuilder();
            passwordBuilder.Append(RandomString(4, true));
            passwordBuilder.Append(RandomNumber(1000, 9999));
            passwordBuilder.Append(RandomString(2));
            return passwordBuilder.ToString();
        }
        public static long UpdatePassword(long UserId)
        {
            var selectUser = Dal.UserDal.selectUserById(UserId);
            var newPass = RandomPassword();
            var updatePassword = Dal.UserDal.UpdatePassword(selectUser, newPass);
            string massage = "הסיסמא החדשה שלך היא:" + newPass;
            string subject = "שינוי סיסמא";
            mail(selectUser.Email, massage, subject);

            return 1;
        }
    }
}
