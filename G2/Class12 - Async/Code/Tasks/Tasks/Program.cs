using System;
using System.Threading;
using System.Threading.Tasks;

namespace Tasks
{
    class Program
    {
        static void Main(string[] args)
        {
            Task ourFirstTask = new Task(() =>
            {
                Thread.Sleep(2000);
                Console.WriteLine("Started working after 2 secs");
            });
            ourFirstTask.Start();
            //return type of the function in the Task is int
            Task<int> resultTask = new Task<int>(() =>
            {
                Thread.Sleep(2000);
                Console.WriteLine("We are returning the result..");
                return 1;
            });
            resultTask.Start();
            Console.WriteLine(resultTask.Result);


            for(int i= 1; i <=20; i++)
            {
                int temp = i;
                //we put tasks into the queue
                Task.Run(() =>
                {
                    Thread.Sleep(2000);
                    Console.WriteLine($"Task number {temp}");
                });
            }
            Console.WriteLine("Some message at the end");
            Console.ReadLine();
        }
    }
}
