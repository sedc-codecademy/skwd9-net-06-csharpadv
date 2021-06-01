using System;
using System.Collections.Generic;
using System.Linq;
using Exercise.Models;

namespace Exercise
{
    class Program
    {
        static void Main(string[] args)
        {
            //1
            //List<string> query = Storage.People.Where(x => x.FirstName.StartsWith("R")).OrderByDescending(x => x.Age)
            //    .Select(x => $"{x.FirstName} {x.LastName}")
            //    .ToList();

            //foreach (string item in query)
            //{
            //    Console.WriteLine(item);
            //}

            List<Person> query1 = Storage.People.Where(x => x.FirstName.StartsWith("R")).OrderByDescending(x => x.Age)
                .ToList();

            //query1.ForEach(x => Console.WriteLine($"{x.FirstName} {x.LastName}"));

            Console.WriteLine(string.Join("\n", query1.Select(x => $"{x.FirstName} {x.LastName}")));

            //2
            List<Dog> query2 = Storage.Dogs.Where(x => x.Age > 3 && x.Color == "Brown").OrderBy(x => x.Age).ToList();
            query2.ForEach(x => Console.WriteLine($"{x.Name} {x.Age}"));

            //3
            List<Person> query3 = Storage.People.Where(x => x.Dogs.Count > 2).OrderByDescending(x => x.FirstName)
                .ToList();

            query3.ForEach(x => Console.WriteLine($"{x.FirstName} {x.LastName}"));

            //4
            //List<Dog> query4 = Storage.People.First(x => x.FirstName == "Freddy").Dogs.Where(x => x.Age > 1)
            //    .ToList();

            //query4.ForEach(x => Console.WriteLine($"{x.Name} {x.Age}"));

            List<Dog> query4 = Storage.People.Where(x => x.FirstName == "Freddy").SelectMany(x => x.Dogs).Where(x => x.Age > 1).ToList();

            query4.ForEach(x => Console.WriteLine($"{x.Name} {x.Age}"));

            //5
            Dog query5 = Storage.People.First(x => x.FirstName == "Nathen").Dogs.First();
            Console.WriteLine($"{query5.Name} {query5.Age}");

            //6
            //List<Dog> query6 = Storage.People
            //    .Where(x => x.FirstName == "Cristofer" || x.FirstName == "Freddy" || x.FirstName == "Erin" ||
            //                x.FirstName == "Amelia").SelectMany(x => x.Dogs).Where(x => x.Color == "White")
            //    .OrderBy(x => x.Name).ToList();

            List<string> names = new List<string>() {"Cristofer", "Freddy", "Erin", "Amelia"};
            List<Dog> query6 = Storage.People
                .Where(x => names.Contains(x.FirstName)).SelectMany(x => x.Dogs).Where(x => x.Color == "White")
                .OrderBy(x => x.Name).ToList();

            query6.ForEach(x => Console.WriteLine($"{x.Name}"));
        }
    }
}
