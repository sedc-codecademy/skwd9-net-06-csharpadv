using System;
using System.Threading;

namespace Threads
{
    class Program
    {
        static void Main(string[] args)
        {
            //SendMessages();
            SendMessagesInParallel();
            Console.ReadLine();
        }

        public static void SendMessages()
        {
            Console.WriteLine("Started sending messages..");
            Thread.Sleep(2000);
            Console.WriteLine("First message arrived!");
            Thread.Sleep(2000);
            Console.WriteLine("Second message arrived");
            Thread.Sleep(3000);
            Console.WriteLine("Third message arrived");
            Console.WriteLine("All messages have arrived");
        }

        //Asynchronous (working with threads)
        public static void SendMessagesInParallel()
        {
            Console.WriteLine("Sending messages started..");
            Thread firstThread = new Thread(() =>
             {
                 Thread.Sleep(2000);
                 Console.WriteLine("First message arrived!");
             });
            firstThread.Start();
            Thread secondThread = new Thread(() =>
            {
                Thread.Sleep(2000);
                Console.WriteLine("Second message arrived!");
            });
            secondThread.Start();
            new Thread(() =>
            {
                Thread.Sleep(3000);
                Console.WriteLine("Third message arrived!");
            }).Start();
            Console.WriteLine("All messages have arrived!");
        }
    }

}
