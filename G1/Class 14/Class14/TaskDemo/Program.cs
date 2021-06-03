using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Threading;
using System.Threading.Tasks;

namespace TaskDemo
{
    class Program
    {
        static async Task Main(string[] args)
        {
            Task task1 = new Task(() =>
            {
                Console.WriteLine("I am task 1");
                Thread.Sleep(1000);
            });

            Task task2 = new Task(() =>
            {
                Console.WriteLine("I am task 2");
                Thread.Sleep(2000);
            });

            Task<int> task3 = new Task<int>(() =>
            {
                Console.WriteLine("I am task 3");
                Thread.Sleep(3000);
                return 3;
            });

            //TaskStatus beforeExecution = task1.Status;
            //task1.Start();
            ////task1.RunSynchronously();
            //TaskStatus afterExecution = task1.Status;

            Stopwatch watch = new Stopwatch();

            watch.Start();
            task1.RunSynchronously();
            task2.RunSynchronously();
            task3.RunSynchronously();
            watch.Stop();

            Console.WriteLine(watch.Elapsed.Seconds);

            watch.Restart();
            List<Task> tasks = new List<Task>() {
                Task.Run(() =>
                    {
                        Console.WriteLine("I am task 1");
                        Thread.Sleep(1000);
                    }),
                Task.Run(() =>
                    {
                        Console.WriteLine("I am task 2");
                        Thread.Sleep(2000);
                    }),
                Task.Run(() =>
                    {
                        Console.WriteLine("I am task 3");
                        Thread.Sleep(3000);
                        return 3;
                    })
            };

            watch.Start();
            await Task.WhenAll(tasks);
            watch.Stop();

            Console.WriteLine(watch.Elapsed.Seconds);
        }
    }
}
