using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace SEDC.AsyncAwait
{
    class Program
    {
        public static void SendMessage(string message)
        {
            Console.WriteLine("Sending message...");
            Thread.Sleep(7000);
            Console.WriteLine($"The message: { message } was sent!");
        }

        public static async Task SendMessageAsync(string message)
        {
            Console.WriteLine("Sending message...");
            await Task.Run(() =>
            {
                Thread.Sleep(10000);
                Console.WriteLine($"The message { message } was sent!");
            });
        }


        public static async Task<List<string>> GetUserNames()
        {
            Console.WriteLine("Getting list of users");
            List<string> names = new List<string>();
            await Task.Run(() =>
            {
                Thread.Sleep(5000);
                names.AddRange(new List<string> { "Martin", "Petre", "Ivo" });
                return names;
            });
            return names;
        }


        public static void ShowAd(string product)
        {
            Console.WriteLine("While you wait let us show you an ad:");
            Thread.Sleep(1000);

            Console.WriteLine("Buy the best product in the world!");
            Console.ForegroundColor = ConsoleColor.DarkCyan;

            Thread.Sleep(1000);
            Console.WriteLine(product);
            Console.ResetColor();

            Thread.Sleep(1000);

            Console.WriteLine(" now and get ");
            Console.ForegroundColor = ConsoleColor.Green;

            Thread.Sleep(1000);
            Console.WriteLine("FREE");
            Console.ResetColor();

            Thread.Sleep(1000);
            Console.WriteLine(" shipping worldwide");

            Console.ResetColor();
        }


        static void Main(string[] args)
        {
            // Example of synchronous execution 
            // SendMessage("Hello there folks!");

            Task result =  SendMessageAsync("Hello there we are testing the async method!");
            Console.WriteLine(result.Status);

            Thread.Sleep(2000);
            ShowAd("Brand new Huawei P40 pro");

            Console.WriteLine(result.Status);


            List<string> users = GetUserNames().Result;
            users.ForEach(Console.WriteLine);




            Console.ReadLine();
        }
    }
}
