using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace SEDC.CSharpAdv.Class12.Tasks
{
    class Program
    {
        static void Main(string[] args)
        {
            Task myTask = new Task(() =>
            {
                LongRuningJob();
            });
            //Console.WriteLine(myTask.Status + "Line 15");
            //myTask.Start();
            //Console.WriteLine(myTask.Status + "Line 17");


            //ReturnResultFromTask();
            //DoSomething();

            //RunTaskOnStart();

            RuningMultipleTasksAtOnce();

            Console.ReadLine();
        }

        static void LongRuningJob()
        {
            Console.WriteLine("Started running");
            Thread.Sleep(3000);
            Console.WriteLine("Completed");
        }

        static void ReturnResultFromTask()
        {
            Task<int> taskThatReturnsInteger = new Task<int>(() =>
            {
                Thread.Sleep(3000);
                Console.WriteLine("We can now get the number");
                return 6;
            });
            taskThatReturnsInteger.Start();
            Console.WriteLine("Starting task");

            Console.WriteLine(taskThatReturnsInteger.Result);
        }

        static List<int> LongRunningJobEvenNumbers()
        {
            var listOfInts = new List<int>();
            for (int i = 0; i < 200; i++)
            {
                Thread.Sleep(100);
                if(i % 2 == 0)
                {
                    listOfInts.Add(i);
                }
            }
            return listOfInts;
        }

        static void DoSomething()
        {
            Task<List<int>> taskList = new Task<List<int>>(() =>
            {
                return LongRunningJobEvenNumbers();
            });
            taskList.Start();

            // more code..

            for (int i = 0; i < 200; i++)
            {
                Thread.Sleep(120);
                if(i % 2 != 0)
                {
                    Console.WriteLine(i);
                }
            }

            List<int> result = taskList.Result;

            foreach (var num in result)
            {
                Console.WriteLine(num);
            }
        }

        static void RunTaskOnStart()
        {
            Task.Run(() =>
            {
                Console.WriteLine("I have started");
                Thread.Sleep(3000);
                Console.WriteLine("Im Finished");
            });

            Task<int> task = Task.Run(() => 6);
            Console.WriteLine(task.Result);
        }

        static void RuningMultipleTasksAtOnce()
        {
            for (int i = 0; i < 20; i++)
            {
                int temp = i;
                Task.Run(() =>
                {
                    Thread.Sleep(2000);
                    Console.WriteLine($"Task No. {temp}");
                });
            }
        }
    }
}
