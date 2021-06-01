
using System;

namespace NullableDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            int? number;
            bool? success;

            Result p = new Result();

            p.Score = 100;

            Console.WriteLine(p.Score);

            //if (p.Score != null)
            //{
            //    Console.WriteLine(p.Score.Value);
            //}

            if (p.Score.HasValue)
            {
                Console.WriteLine(p.Score.Value);
            }

            p.Score = null;

            Result r1 = new Result()
            {
                Id = 5,
                IsEmployee = true,
                Score = 95,
                PassedTheExam = true
            };

            Result r2 = new Result()
            {
                Id = 8,
                IsEmployee = true,
                Score = 20,
                PassedTheExam = false
            };

            Print(r1, "Risto");
            Print(r2);
        }

        static void Print(Result p, string name = "******")
        {
            //string userName = string.IsNullOrEmpty(name) ? "*******" : name;

            Console.WriteLine($"{name}: {p.Score}");
        }
    }
}
