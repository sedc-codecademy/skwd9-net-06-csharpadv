using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace SEDC.CSharpAdv.Class14.SB
{
    public class MailService
    {
        private string _mailTemplatePath = "./EmailTemplate.txt";

        public void SendMail(string email, string username, string customername, string clientname)
        {
            Console.WriteLine($"Sending mail to {email}");
            Console.WriteLine("The message is:");
            Console.WriteLine(CreateMailMessage(username, customername, clientname));
        }

        private string CreateMailMessage(string username, string customername, string clientname)
        {
            var mailMessage = new StringBuilder(GetTempalte());

            string message = mailMessage
                .Replace("{customer}", customername)
                .Replace("{username}", username)
                .Replace("{clientname}", clientname)
                .ToString();

            return message;
        }

        private string GetTempalte()
        {
            using (var sr = new StreamReader(_mailTemplatePath))
            {
                return sr.ReadToEnd();
            }
        }
    }
}
