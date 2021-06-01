using System;
using System.Threading;
using System.Threading.Tasks;

namespace Tasks
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("App start...");

            // Single Task Example
            Task myTask = new Task(() =>
            {
                Thread.Sleep(2000);
                Console.WriteLine("Running after 2000ms");
            });
            myTask.Start();

            // Single Task with return type
            Task<int> valueTask = new Task<int>(() =>
            {
                Thread.Sleep(2000);
                Console.WriteLine("We can now get the number...");
                return 6;
            });
            valueTask.Start();

            // Checking result of a task
            Task.Run(() =>
            {
                Thread.Sleep(3000);
                Console.WriteLine("This is executed immediately...");
            });

            Console.WriteLine(valueTask.Result);
            Console.WriteLine("App End...");


            Console.WriteLine("Where do you see me??!?");

            //// Running 20 tasks at once and see how they execute asynchronously
            //for (int i = 0; i < 30; i++)
            //{
            //    int temp = i;
            //    Task.Run(() =>
            //    {
            //        Thread.Sleep(5000);
            //        Console.WriteLine($"TASK NO. {temp}");
            //    });
            //}
            Console.ReadLine();
        }
    }
}
