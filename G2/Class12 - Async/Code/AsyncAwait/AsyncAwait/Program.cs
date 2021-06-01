using System;
using System.Threading;
using System.Threading.Tasks;

namespace AsyncAwait
{
    class Program
    {
        static void Main(string[] args)
        {
            //SendMessages();


            //SendMessagesAsync("hi");
            //WriteMessages();

            OurMainMethod();
           
            Console.ReadLine();
        }


        public static async Task OurMainMethod()
        {
            await SendMessagesAsync("hi");
            WriteMessages();
        }
        //synchronous
        public static void SendMessages()
        {
            Console.WriteLine("Hello students");
            Thread.Sleep(5000);
            Console.WriteLine("Goodbye students");
        }
        //asynchronous
        public static async Task SendMessagesAsync(string message)
        {
            Console.WriteLine("Start");
            await Task.Run(() =>
            {
                Thread.Sleep(3000);
                Console.WriteLine($"Message {message} sent!");
            });
            Console.WriteLine("Stop");

        }

        public static void WriteMessages()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("This is message outside of the logic");
            Console.ResetColor();
        }
    }
}
