using SEDC.CSharpAdv.Class07.EventsAdv.Publishers;
using SEDC.CSharpAdv.Class07.EventsAdv.Subscribers;
using System;

namespace SEDC.CSharpAdv.Class07.EventsAdv
{
    class Program
    {
        static void Main(string[] args)
        {
            // publishers
            var rentalStore = new RentalStore();


            // subscribers
            var mailService = new EmailService();
            var pushNorifications = new PushNotifications();

            rentalStore.NotifyUsers += mailService.SendMail;
            rentalStore.NotifyUsers += pushNorifications.SendPushNotification;

            rentalStore.AddNewMovie("Some movie");

            Console.ReadLine();
        }
    }
}
