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
            var bolckbasterStore = new BlockbasterStore();


            // subscribers
            var mailService = new EmailService();
            var pushNorifications = new PushNotifications();

            bolckbasterStore.Notifications += mailService.SendMail;
            bolckbasterStore.Notifications += pushNorifications.SendPushNotification;
            rentalStore.NotifyUsers += mailService.SendMail;
            rentalStore.NotifyUsers += pushNorifications.SendPushNotification;

            rentalStore.NotifyUsersVideoEvent += mailService.SendMail;
            rentalStore.NotifyUsersVideoEvent += pushNorifications.SendPushNotification;

            //bolckbasterStore.Notifications -= pushNorifications.SendPushNotification;

            rentalStore.AddNewMovie("Some movie");
            bolckbasterStore.NewMovieRelease("Treto poluvreme");

            Console.ReadLine();
        }
    }
}
