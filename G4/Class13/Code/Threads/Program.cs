using System;
using System.Threading;

namespace Threads
{
    class Program
    {
        static void Main(string[] args)
        {

            //SendMessages();
            SendMessagesWithThreads();
        }

        // Synchronous
        public static void SendMessages()
        {
            Console.WriteLine("Getting ready...");
            Thread.Sleep(2000);
            Console.WriteLine("First message arrived!");
            Thread.Sleep(2000);
            Console.WriteLine("Second message arrived!");
            Thread.Sleep(2000);
            Console.WriteLine("Third message arrived!");
            Console.WriteLine("All messages received!");
            Console.ReadLine();
        }

        //Asynchronous
        public static void SendMessagesWithThreads()
        {
            Console.WriteLine("Getting ready...");

            Thread myThread = new Thread(() =>
            {
                Thread.Sleep(2000);
                Console.WriteLine("First message arrived!");
            });
            // lines of code
            myThread.Start();

            new Thread(() =>
            {
                Thread.Sleep(2000);
                Console.WriteLine("Second message arrived!");
            }).Start();

            new Thread(() =>
            {
                Thread.Sleep(2000);
                Console.WriteLine("Third message arrived!");
            }).Start();

            Console.WriteLine("All messages received!");
            Console.ReadLine();
        }
    }
}
