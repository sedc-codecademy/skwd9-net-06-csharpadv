using System;
using System.Threading;

namespace SEDC.Threads
{
    class Program
    {
        public static void SendMessages()
        {
            Console.WriteLine("Getting ready...");
            Thread.Sleep(2000);
            Console.WriteLine("First message arrived!");
            Thread.Sleep(5000);
            Console.WriteLine("Second message arrived!");
            Thread.Sleep(2000);
            Console.WriteLine("Third message arrived!");
            Console.WriteLine("All messages are recived!");
        }

        public static void SendMessagesWithThreads()
        {
            Console.WriteLine("Getting ready...");

            Thread myThread = new Thread(() =>
            {
                Thread.Sleep(2000);
                Console.WriteLine("First message arrived!");
            });
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

            Console.WriteLine("All messages are recived!");
        }

        static void Main(string[] args)
        {
            //SendMessages();
            SendMessagesWithThreads();
            
            
            Console.ReadLine();
        }
    }
}
