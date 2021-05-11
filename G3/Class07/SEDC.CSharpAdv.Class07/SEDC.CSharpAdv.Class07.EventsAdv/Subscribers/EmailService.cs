using System;
using System.Collections.Generic;
using System.Text;

namespace SEDC.CSharpAdv.Class07.EventsAdv.Subscribers
{
    public class EmailService
    {
        public void SendMail(object source, EventArgs args)
        {
            Console.WriteLine("Sending mail....");
        }
    }
}
