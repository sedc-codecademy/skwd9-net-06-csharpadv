using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace SEDC.CSharpAdv.Class07.Events
{
    public class MailService
    {
        public Dictionary<string, bool> userSubscribed = new Dictionary<string, bool>
        {
            { "Trajan", true },
            { "Nikola", true },
            { "Peor", false },
            { "Mile", true },
            { "Cacko", false },
            { "Tosho", false },
            { "Student1", true },
            { "Blazo", false }
        };


        public void SendMail(string str)
        {
            Console.WriteLine("Sendiung mail....");

            foreach (var item in userSubscribed)
            {
                if (item.Value)
                {
                    Console.WriteLine($"{item.Key} check it out. we have a new moview relese. {str} is out now!");
                }
                Thread.Sleep(2000);
            }

            Console.WriteLine("Finished sending mails");
        }
    }
}
