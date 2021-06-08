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

            //Single task example
            Task myTask = new Task(() =>
            {
                Thread.Sleep(2000);
                Console.WriteLine("Running after 2000ms");
            });

            myTask.Start();

            Task myTask2 = new Task(() =>
            {
                Thread.Sleep(2000);
                Console.WriteLine("Running task 2 after 2000ms");
            });

            myTask2.Start();

            Task.Run(() =>
            {
                Thread.Sleep(3000);
                Console.WriteLine("Running task 3 after 3000ms");
            });

            //Single task with return type Example
            Task<int> valueTask = new Task<int>(() =>
            {
                Thread.Sleep(4000);
                Console.WriteLine("Running task 4 after 4000ms");
                return 5;
            });

            valueTask.Start();

            var result = valueTask.Result;
            Console.WriteLine("valuTask result is: " + $" {result}");

            Console.WriteLine("App end...");

            // Running 30 tasks at once and see how they execute asynchronously 
            // If the numbers go from 1 to 30 then open a lot of chrome browser windows while it works or do some intensive action on the operating system
            for (int i = 1; i <= 30; i++) 
            {
                int temp = i;
                Task.Run(() =>
                {
                    Thread.Sleep(2000);
                    Console.WriteLine($"TASK NO. {temp}");
                });
            }

            Console.ReadLine();
        }
    }
}
