using System;
using System.Threading;

namespace Events
{
    public class SecondSubscriber
    {
        public void GetMessage(string message)
        {
            Thread.Sleep(4000);
            Console.WriteLine("Second subscriber!!!");
            Console.WriteLine($"My message is {message}");
        }
    }
}
