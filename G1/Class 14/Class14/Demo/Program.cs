using System;
using System.Threading;
using System.Threading.Tasks;

namespace Demo
{
    class Program
    {
        static void Main(string[] args)
        //static async Task Main(string[] args)
        {
            Console.WriteLine("Starting the application");

            //SendMessage("123213123", "some message...");

            //async call for the method SendMessageAsync => this will not stop the execution of main, the SendMessageAsync is not waited
            //SendMessageAsync("123213123", "some message...");
            //MainThread();

            //sync execution of async method SendMessageAsync=> this will stop the execution of main
            //await SendMessageAsync("123213123", "some message...");
            //await MainThread();

            //string result = await SendMessageWithResultAsync("123213123", "some message...");
            //Console.WriteLine(result);

            //Task<string> task = SendMessageWithResultAsync("123213123", "some message...");
            //string result = task.Result;
            string result = SendMessageWithResultAsync("123213123", "some message...").Result;
            Console.WriteLine(result);

            

            Console.WriteLine("End application");
        }

        //static void SendMessage(string phone, string message)
        //{
        //    Console.WriteLine($"Sending message to {phone}: {message}");
        //    Thread.Sleep(5000);
        //    Console.WriteLine("Message sent!");
        //}

        public static async Task MainThread()
        {
            await SendMessageAsync("123213123", "some message...");
        }

        static async Task SendMessageAsync(string phone, string message)
        {
            await Task.Run(() =>
            {
                Console.WriteLine($"Sending message to {phone}: {message}");
                Thread.Sleep(5000);
                Console.WriteLine("Message sent!");
            });
        }

        static async Task<string> SendMessageWithResultAsync(string phone, string message)
        {
            return await Task.Run(() =>
            {
                Console.WriteLine($"Sending message to {phone}: {message}");
                Thread.Sleep(5000);
                return "Returned message";
            });
        }
    }
}
