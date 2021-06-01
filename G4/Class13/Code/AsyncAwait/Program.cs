using System;
using System.Threading;
using System.Threading.Tasks;

namespace AsyncAwait
{
    class Program
    {
        static void Main(string[] args)
        {
            //// Example for synchronous execution (It does not show the add while waiting)
            //SendMessage("Hey G4");

            // Example of asynchronous execution
            var x = SendMessageAsync("Hey G4");
            Console.WriteLine(x.Status);

            ShowAd("Debugger");
            Console.ReadLine();

            //Console.WriteLine(x.Status);

            //// Making sync with async?!? (complicating code for nothing)
            //MainThread();

            // our custom async method
            Task<string> myCustomAsyncMethod = TaskWithValue();
            Console.WriteLine("My custom method");
            Console.WriteLine(myCustomAsyncMethod.Status);

            Console.WriteLine(myCustomAsyncMethod.Result);
            Console.ReadLine();
        }

        // Making sync with async ?! ( complicating code for nothing )
        // Awaiting everything example
        // This is a bonus example of what would happen if we await everything
        public static async Task MainThread()
        {
            await SendMessageAsync("Hey there G4");
            ShowAd("Debugger 2.0");

            Console.ReadLine();
        }

        public static void SendMessage(string message)
        {
            Console.WriteLine("Sending message...");
            Thread.Sleep(7000);
            Console.WriteLine($"The message '{message}' was sent!");
        }

        // Naming convention is to add Async to the end of the name
        public static async Task SendMessageAsync(string message)
        {
            Console.WriteLine("Sending message...");
            await Task.Run(() =>
            {
                Thread.Sleep(7000);
                Console.WriteLine($"The message '{message}' was sent!");
            });
        }

        public static async Task<string> TaskWithValue()
        {
            await Task.Run(() =>
            {
                Thread.Sleep(7000);
                Console.WriteLine($"We are executing something!");
            });
            return "I am the return value";
        }

        public static void ShowAd(string product)
        {
            Console.WriteLine("====================================");
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
            Console.WriteLine("====================================");
        }
    }
}
