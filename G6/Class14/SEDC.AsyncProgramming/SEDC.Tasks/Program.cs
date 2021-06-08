using System;
using System.Threading;
using System.Threading.Tasks;

namespace SEDC.Tasks
{
    class Program
    {
        static void Main(string[] args)
        {

            //Single Task Example

            //Console.WriteLine("App start...");

            //Task myTask = new Task(() =>
            //{
            //    Thread.Sleep(2000);
            //    Console.WriteLine("Running after 2000ms");
            //});

            //myTask.Start();

            //Task<int> valueTask = new Task<int>(() =>
            //{
            //    Thread.Sleep(3000);
            //    Console.WriteLine("We can now get the number...");
            //    return 10;
            //});
            //valueTask.Start();

            //// Get the result that some task returns
            //Console.WriteLine($"Aaaand the number is: { valueTask.Result }");

            //Task.Run(() =>
            //{
            //    Thread.Sleep(4000);
            //    Console.WriteLine("This is executed immedietely...");
            //});

            //Console.WriteLine("App End....");


            // Running 20 tasks at once and see how they execute asynchronously
            // If the numbers go from 1 to 20 then open a lot of chrome browser windows or tabs
            // While it works or do some intensive action on the operating system

            //for (int i = 0; i < 20; i++)
            //{
            //    int temp = i;
            //    Task.Run(() =>
            //    {
            //        Thread.Sleep(2000);
            //        Console.WriteLine($"TASK NO. { temp }");
            //    });
            //}


            Task<string> newTask = new Task<string>(() =>
            {
                Thread.Sleep(3000);
                return "Hello there";
            });

            // Checking the status of a task

            Console.WriteLine($"Before start the task has status of: { newTask.Status }");

            newTask.Start();

            Thread.Sleep(2000);
            Console.WriteLine($"After starting the task has status of: { newTask.Status }");

            // Check if task is completed or not
            if(newTask.IsCompleted)
            {
                Console.WriteLine("Task completed!");
            }
            else
            {
                Console.WriteLine("Task still running!");
            }

            Thread.Sleep(3000);
            Console.WriteLine($"After execution the task has status of: { newTask.Status }");


            if(newTask.IsCompleted)
            {
                Console.WriteLine("Please tell me that the task has finally completed!");
            }

            Console.ReadLine();
        }
    }
}
