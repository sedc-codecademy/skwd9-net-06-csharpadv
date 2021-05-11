using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace EventsDemo.Entites
{
    public class SubscriberOne
    {
        public void SubscribeOneProcessing(string message)
        {
            Thread.Sleep(5000);
            Console.WriteLine($"Subscriber One received this message: {message}");
        }
    }
}
