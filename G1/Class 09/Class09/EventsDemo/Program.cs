using System;
using EventsDemo.Models;

namespace EventsDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Market kam = new Market("Kam");
            Market vero = new Market("Vero");

            User risto = new User("Risto", "Panchevski", 32, ProductType.Food);
            User radmila = new User("Radmila", "Kocovska", 30, ProductType.Cosmetics);
            User goran = new User("Goran", "Turundzov", 28, ProductType.Electronics);
            User andrej = new User("Andrej", "Ivanov", 25, ProductType.Food);
            User aleksandar = new User("Aleksandar", "Planic", 33, ProductType.Other);

            //kam.SendPromotion(ProductType.Food);
            //vero.SendPromotion(ProductType.Electronics);

            kam.SubscribeForPromotion("risto@gmail.com", risto.ReadPromotion);
            kam.SubscribeForPromotion("radmila@gmail.com", radmila.ReadPromotion);
            kam.SubscribeForPromotion("goran@gmail.com", goran.ReadPromotion);

            vero.SubscribeForPromotion("risto@gmail.com", risto.ReadPromotion);
            vero.SubscribeForPromotion("andrej@gmail.com", andrej.ReadPromotion);
            vero.SubscribeForPromotion("aleksandar@gmail.com", aleksandar.ReadPromotion);

            kam.SendPromotion(ProductType.Food);
            vero.SendPromotion(ProductType.Electronics);

            kam.UnsubscribeForPromotion("Too boring", risto.ReadPromotion);

            kam.SendPromotion(ProductType.Electronics);
            vero.SendPromotion(ProductType.Other);

            kam.PrintAllComplaints();
            vero.PrintAllComplaints();

            Employee employee = new Employee("Petko", "Petkovski", 5);
            kam.SubscribeForNotifications(employee.NotificationSubscriber);

            kam.SubscribeForNotifications(risto.ReadNotification);
            kam.SendNotification("Za veligden rabotime do 16h");
        }
    }
}
