using System;
using System.Diagnostics;
using System.Threading;

namespace SEDC.CSharpAdv.Class12.Asynchronous
{
    class Program
    {
        static void Main(string[] args)
        {
            RunJobsInOneThreadAsync();

            var stopwatch = new Stopwatch();
            stopwatch.Start();

            RunJob();

            Console.WriteLine("Please enter your name:");
            string a = Console.ReadLine();
            Console.WriteLine(a);

            stopwatch.Stop();
            Console.WriteLine(stopwatch.ElapsedMilliseconds);

            Console.WriteLine("====RUNING ASYNC====");

            stopwatch.Reset();
            stopwatch.Start();

            RunJobAsync();

            Console.WriteLine("Please enter your name:");
            a = Console.ReadLine();
            Console.WriteLine(a);

            stopwatch.Stop();
            Console.WriteLine(stopwatch.ElapsedMilliseconds);

            Console.ReadLine();
        }

        static void RunJob()
        {
            Console.WriteLine("Getting ready");
            FirstLongRuningJob();
            SecondLongRuningJob();
            ThirdLongRuningJob();
        }

        static void RunJobAsync()
        {
            Console.WriteLine("Getting ready");
            Thread firstThread = new Thread(() =>
            {
                FirstLongRuningJob();
            });
            firstThread.Start();

            Thread secondThread = new Thread(() =>
            {
                SecondLongRuningJob();
            });
            secondThread.Start();

            new Thread(() =>
            {
                ThirdLongRuningJob();
            }).Start();
        }

        static void RunJobsInOneThreadAsync()
        {
            Console.WriteLine("Getting ready");
            new Thread(() => 
            {
                FirstLongRuningJob();
                Console.WriteLine("Second Thread");
                SecondLongRuningJob();
                Console.WriteLine("Second Thread");
                ThirdLongRuningJob();
                Console.WriteLine("Second Thread");
            }).Start();
        }

        static void FirstLongRuningJob()
        {
            Thread.Sleep(3000);
            Console.WriteLine("First long runing task completed");
        }

        static void SecondLongRuningJob()
        {
            Thread.Sleep(6000);
            Console.WriteLine("Second long runing task completed");
        }

        static void ThirdLongRuningJob()
        {
            Thread.Sleep(3000);
            Console.WriteLine("Third long runing task completed");
        }
    }
}
