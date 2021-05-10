using System;
using System.Collections.Generic;
using System.Linq;

namespace AnonymousFunctionsDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine(Subtract(7, 2));

            //Func<> funk1 = () => { }
            //Func<int, int, int> f1 = (x, y) =>
            //{
            //    return x - y;
            //};

            Func<int, int, int> funk1 = (x, y) => x - y;

            int result = funk1(5, 2);
            Console.WriteLine(result);

            Func<List<int>, bool> isEmpty = (list) => list.Count == 0;

            List<int> newList = new List<int>();

            Console.WriteLine($"Is empty {isEmpty(newList)}");

            Func<int> funk2 = () =>
            {
                return 5;
            };

            List<string> names = new List<string> { "Risto", "Radmila", "Goran", "Dejan" };
            Print(names);

            //Action<List<string>> print = (list) =>
            //{
            //    Console.WriteLine(string.Join(", ", list));
            //};

            Action<List<string>> print = (list) => Console.WriteLine(string.Join(", ", list));
            print(names);

            Action<string> printRed = text =>
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine(text);
                Console.ResetColor();
            };

            Action<string> printGreen = text =>
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine(text);
                Console.ResetColor();
            };

            printRed("This is red text");
            Console.WriteLine("+++++++++++++++++");
            printGreen("This is green text");

            Action<string, ConsoleColor> consoleWriteLine = (text, color) =>
            {
                Console.ForegroundColor = color;
                Console.WriteLine(text);
                Console.ResetColor();
            };

            consoleWriteLine("This is red text", ConsoleColor.Red);
            Console.WriteLine("+++++++++++++++++");
            consoleWriteLine("This is green text", ConsoleColor.Green);

            //Usage of Anonymous functions in LINQ

            List<string> namesStartingWithR = names.Where(x => x.StartsWith("R")).ToList();

            List<Car> cars = new List<Car>
            {
                new Car("Leon", 150, "Seat"),
                new Car("Polo", 70, "VW"),
                new Car("306", 110, "Peugeot"),
                new Car("Ibiza", 110, "Seat")
            };

            //FILTER: Name: LE, >100, Seat
            List<Car> filterCars = cars.Where(x =>
                                                x.Manufacturer == "Seat"
                                                && x.Power > 100
                                                && x.Name.Contains("Le", StringComparison.InvariantCultureIgnoreCase))
                .ToList();

            //foreach filter
            Func<Car, bool> filterName = (c) =>
            {
                string filterForManufacturer = "Seat";
                string filterForName = string.Empty;

                return (string.IsNullOrEmpty(filterForManufacturer) || c.Manufacturer == filterForManufacturer)
                       && c.Power > 100
                       && (string.IsNullOrEmpty(filterForName) || c.Name.Contains(filterForName, StringComparison.InvariantCultureIgnoreCase));
            };

            List<Car> c1 = cars.Where(filterName).ToList();


            Func<int, int> test = (d) => d * 2;
            int res = Subtract(5, 3, test);
            Console.WriteLine(res);
        }

        static int Subtract(int a, int b, Func<int, int> test)
        {
            return a - b + test(2);
        }

        static void Print(List<string> list)
        {
            Console.WriteLine(string.Join(", ", list));
        }
    }

    public class Car
    {
        public string Name { get; set; }
        public int Power { get; set; }
        public string Manufacturer { get; set; }

        public Car(string name, int power, string manufacturer)
        {
            Name = name;
            Power = power;
            Manufacturer = manufacturer;
        }
    }
}
