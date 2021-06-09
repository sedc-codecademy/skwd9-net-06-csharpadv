using System;
using System.Threading;
using System.Threading.Tasks;

namespace AsyncAwait
{
    class Program
    {
        static void Main(string[] args)
        {
            //SendMessage("Hey there SEDC students!");

            //var messageTask = SendMessageAsync("Hey there SEDC students!");
            //Console.WriteLine(messageTask.Status);

            //ShowAd("Potato");
            //Console.ReadLine();
            //Console.WriteLine(messageTask.Status);

            Main();

            Console.ReadLine();
        }

        public static async Task Main() 
        {
            await SendMessageAsync("Hey there SEDC students!");
            ShowAd("Potato");
        }

        public static void SendMessage(string message) 
        {
            Console.WriteLine("Sending message...");
            Thread.Sleep(7000);
            Console.WriteLine($"The message {message} was sent!");
        }

        public static async Task SendMessageAsync(string message) 
        {
            Console.WriteLine("Sending message...");
            await Task.Run(() =>
            {
                Thread.Sleep(7000);
                Console.WriteLine($"The message {message} was sent!");
            });
        }

        public static void ShowAd(string product) 
        {
            Console.WriteLine("While you wait let us show you an ad:");
            Console.Write("Buy the best product in the world ");
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.Write(product);
            Console.ResetColor();
            Console.Write(" now and get ");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write("FREE");
            Console.ResetColor();
            Console.WriteLine(" shipping worldwide!");      
        }
    }
}
