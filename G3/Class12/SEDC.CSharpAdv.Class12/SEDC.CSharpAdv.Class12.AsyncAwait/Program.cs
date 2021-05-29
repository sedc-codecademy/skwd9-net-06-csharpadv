using System;
using System.Diagnostics;
using System.Threading;
using System.Threading.Tasks;

namespace SEDC.CSharpAdv.Class12.AsyncAwait
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("====SYNC====");
            //SendMessage("Hey there SEDC students");
            //ShowAd("Potato");


            //Console.WriteLine("====ASYNC====");
            //var x = MainThread();
            ////Console.WriteLine(x.Status);
            //ShowAd("Potato");

            //ShowFullName().GetAwaiter();

            //var student = GetStudent().Result;
            //Console.WriteLine(student.FirstName + " First way");
            //var taskOfStudent = GetStudent();
            //var result = taskOfStudent.Result;
            //Console.WriteLine(result.FirstName + " Second way");

            //var student1 = GetStudent().GetAwaiter().GetResult();
            //Console.WriteLine(student1.FirstName + " Third way");

            WorkingWithIntegers();

            Console.ReadLine();
        }

        static async Task MainThread()
        {
            await SendMesseageAsync("Hey there SEDC students");
        }

        static void SendMessage(string message)
        {
            Console.WriteLine("Sending message");
            Thread.Sleep(7000);
            Console.WriteLine($"The message {message} was sent!");
        }

        static async Task SendMesseageAsync(string message)
        {
            Console.WriteLine("Sending message");
            await Task.Run(() =>
            {
                Thread.Sleep(7000);
                Console.WriteLine($"The message {message} was sent!");
            });
        }

        static void ShowAd(string product)
        {
            Console.WriteLine("While you wait let us show you and Ad:");
            Console.Write("Buy the best product in the world! ");
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.Write(product);
            Console.ResetColor();
            Console.Write(" now and get ");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write("FREE");
            Console.ResetColor();
            Console.Write(" shipping worldwide!");
            Console.WriteLine();
        }

        static async Task<string> GetFullName(string fname, string lname)
        {
            return await Task.Run(() => $"{fname} {lname}");
        }

        static async Task ShowFullName()
        {
            var fullNameTaks = GetFullName("Trajan", "Stevkovski");

            // lots of code

            string fullName = await fullNameTaks;

            Console.WriteLine(fullName);
        }

        static async Task<Student> GetStudent()
        {
            var student = new Student() { FirstName = "Bob", LastName = "Bobski", Age = 23 };

            return await Task.Run(() =>
            {
                Thread.Sleep(3000);
                return student;
            });
        }

        static async Task WorkingWithIntegers()
        {
            var wwi = new WorkingWithInts();

            var timer = Stopwatch.StartNew();

            // we will not wait for this to finish
            //var listOfIntsTask = wwi.GetAllEvenNumbersAsync();
            //ShowAd("Async/Await");

            // we will wait for this to finish
            var listOfIntsAsync = await wwi.GetAllEvenNumbersAsync();
            ShowAd("Async/Await");

            var listOfInts = wwi.GetAllEvenNumbers();
            ShowAd("Sync is slow");

            //var ints = await listOfIntsTask;

            Console.WriteLine(timer.ElapsedMilliseconds);
        }
    }
}
