using SEDC.CSharpAdv.Class07.EventsAdv.Models;
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

        public void SendPushNotification(object source, MovieEventArgs args)
        {
            Console.WriteLine("Sending push notifications...");
            Console.WriteLine($"The movie {args.Title} is available at hte store");
        }

        public void SendPushNotification(object source, VideoEventArgs args)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Sending push notifications...");
            Console.WriteLine(
                $"The movie {args.Movie.Title} is available at hte store it was relesed {args.Movie.ReleaseDate.ToLongDateString()}");
            Console.ResetColor();
        }
    }
}
