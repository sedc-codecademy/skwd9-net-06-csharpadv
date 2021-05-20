using System;
using System.Text;
using System.Threading;
using RestaurantApp.Models;

namespace RestaurantApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.WriteLine("Lets start....");
            User risto = new User("Risto", "Panchevski");
            User radmila = new User("Radmila", "Kocovska");
            User goran = new User("Goran", "Turundzov");

            Restaurant enriko = new Restaurant("Enriko");

            Order ristoOrder = risto.CreateOrder("pasta", 250);
            enriko.MakeAnOrder(ristoOrder, risto.OrderCompleteSubscriber);

            Order radmilaOrder = radmila.CreateOrder("pizza", 300);
            enriko.MakeAnOrder(radmilaOrder, radmila.OrderCompleteSubscriber);

            Order goranOrder = goran.CreateOrder("sandwich", 250);
            enriko.MakeAnOrder(goranOrder, goran.OrderCompleteSubscriber);

            Order ristoOrder2 = risto.CreateOrder("pancake", 100);
            enriko.MakeAnOrder(ristoOrder2, risto.OrderCompleteSubscriber);

            while (true)
            {
                Thread.Sleep(12000);
                enriko.CheckOrders();
            }
        }
    }
}
