using System;
using System.Threading;

namespace Threads
{
    class Program
    {
        static void Main(string[] args)
        {
            //SendMessage();
            SendMessageWithThreads();
        }

        // Synchronous
        public static void SendMessage() 
        {
            Console.WriteLine("Getting Ready....");
            Thread.Sleep(2000);
            Console.WriteLine("First message arrived!");
            Thread.Sleep(2000);
            Console.WriteLine("Second message arrived!");
            Thread.Sleep(2000);
            Console.WriteLine("Third message arrived!");
            Console.WriteLine("All message are recieved!");
            Console.ReadLine();
        }

        // Asynchronous
        public static void SendMessageWithThreads() 
        {
            Console.WriteLine("Getting Ready....");

            Thread threadOne = new Thread(() =>
            {
                Thread.Sleep(2000);
                Console.WriteLine("First message arrived!");
            });
            threadOne.Start();

            Thread threadTwo = new Thread(() =>
            {
                Thread.Sleep(2000);
                Console.WriteLine("Second message arrived!");
            });
            threadTwo.Start();

            new Thread(() =>
            {
                Thread.Sleep(2000);
                Console.WriteLine("Third message arrived!");
            }).Start();

            Console.WriteLine("All message are recieved!");
            Console.ReadLine();
        }
    }
}
