using EventsDemo.Entites;
using System;

namespace EventsDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Publisher pub = new Publisher();
            SubscriberOne sub1 = new SubscriberOne();
            SubscriberTwo sub2 = new SubscriberTwo();

            pub.EventHandler += sub1.SubscribeOneProcessing;
            pub.EventHandler += sub2.SubscribeTwoProcessing;

            pub.Publish("This is a message from the universe.");

            Console.ReadLine();
        }
    }
}
