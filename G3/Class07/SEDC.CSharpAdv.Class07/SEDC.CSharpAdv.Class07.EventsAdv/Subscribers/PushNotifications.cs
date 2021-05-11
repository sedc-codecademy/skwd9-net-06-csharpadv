using System;
using System.Collections.Generic;
using System.Text;

namespace SEDC.CSharpAdv.Class07.EventsAdv.Subscribers
{
    public class PushNotifications
    {
        public void SendPushNotification(object sender, EventArgs args)
        {
            Console.WriteLine("Sending push notifications...");
        }
    }
}
