using System;

namespace Events
{
    public class FirstSubscriber
    {
        public void ProcessMessage(string message)
        {
            Console.WriteLine("First subscriber!!!");
            Console.WriteLine($"I got the following {message}");
        }
    }
}
