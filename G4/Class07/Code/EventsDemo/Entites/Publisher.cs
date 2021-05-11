using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace EventsDemo.Entites
{
    public delegate void MessageEventHandler(string message);
    public class Publisher
    {
        // events are of type delegate
        public event MessageEventHandler EventHandler;

        public void Publish(string message)
        {
            Console.WriteLine($"Publishing: {message}");
            Thread.Sleep(3000);
            Console.WriteLine("Notifying subscribers...");
            NotifyAllSubscribers(message);
        }

        protected virtual void NotifyAllSubscribers(string message)
        {
            // this Invokes (calls) the methods attached to the delegate (event)
            EventHandler?.Invoke(message); // null conditional operator (if not null Invoke)
        }
    }
}
