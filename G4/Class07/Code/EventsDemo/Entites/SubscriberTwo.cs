using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace EventsDemo.Entites
{
    public class SubscriberTwo
    {
        public void SubscribeTwoProcessing(string message)
        {
            Thread.Sleep(7000);
            Console.WriteLine($"Subscriber Two received this message: {message}");
        }
    }
}
