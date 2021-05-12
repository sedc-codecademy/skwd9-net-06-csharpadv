using System;

namespace SEDC.CSharpAdv.Class07.Events
{
    class Program
    {
        static void Main(string[] args)
        {
            var videoStore = new VideoStore(); // publisher - raises the event
            var mailService = new MailService(); // subscriber - listens to events

            videoStore.NotifyUsers += mailService.SendMail;

            videoStore.AddNewMovie("Terminator");
            Console.ReadLine();
        }
    }
}
