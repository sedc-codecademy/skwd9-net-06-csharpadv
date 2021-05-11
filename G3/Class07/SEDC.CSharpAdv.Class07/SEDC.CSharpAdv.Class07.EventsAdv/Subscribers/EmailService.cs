using SEDC.CSharpAdv.Class07.EventsAdv.Models;
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

        public void SendMail(object source, MovieEventArgs args)
        {
            Console.WriteLine("Sending mail....");
            Console.WriteLine($"The movie {args.Title} is available at hte store");
        }

        public void SendMail(object source, VideoEventArgs args)
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("Sending mail....");
            Console.WriteLine(
                $"The movie {args.Movie.Title} is available at hte store it was relesed {args.Movie.ReleaseDate.ToLongDateString()}");
            Console.ResetColor();
        }
    }
}
