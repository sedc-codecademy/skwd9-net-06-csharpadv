using System;
using System.Threading;

namespace SEDC.Delegates
{
    class Program
    {
        // Declaring delegates
        public delegate void SayDelegate(string message);

        public delegate int NumberDelegate(int num1, int num2);

        // Custom generic delegate 
        public delegate bool Filter<T>(T item);


        public delegate void PrintInfo(string message);


        static void Main(string[] args)
        {
            #region Anonymous function with delegate

            PrintInfo print = delegate(string x)
            {
                Console.WriteLine(x);
            };

            // Remove the delegate key word and the type of the input parameter and add arrow sign =>
            PrintInfo printInfo = x =>
            {
                Console.WriteLine(x);
            };

            #endregion


            #region Instantiating a delegate with methods

            SayDelegate hello = new SayDelegate(SayHello);
            SayDelegate bye = new SayDelegate(SayGoodBye);

            //Using a delegates ( Points to methods )
            hello("Martin");
            bye("Petre");
            #endregion

            Console.WriteLine("==============================");
            Thread.Sleep(2000);

            #region Passing method to an input parameter of type delegate parameter

            SayWhatever("Eva", SayHello);
            SayWhatever("Petre", SayGoodBye);
            SayWhatever("Martin", hello);

            //Send method as input parameter to other method by using lambda expression with own scope (as anonymous method)
            SayWhatever("Ann", x => Console.WriteLine(x));


            //Send method as input parameter to other method by using lambda expression with own scope (as anonymous method)
            SayWhatever("John", x =>
            {
                if (x == "John")
                {
                    Console.WriteLine($"Ohh { x }, it's you!");
                }
                else
                {
                    Console.WriteLine($"Something else!");
                }
            });
            #endregion

            Console.WriteLine("=================================]");
            Thread.Sleep(2000);

            #region Making a higher order functions

            //NumberMaster(10, 20, Sum);
            // The same call from line 60 but with using lambda expression (anonymous function)
            NumberMaster(10, 20, (x, y) => x + y);
            NumberMaster(100, 72, (x, y) => x - y);
            NumberMaster(101, 102, (x, y) => x * y);
            #endregion


            #region Custom generic delegate

            //Filter<int> filter = new Filter<int>(IsGreaterThenTen);
            Filter<int> filter = x => x > 10;

            Func<int, bool> filterFunc = x => x > 10;


            Console.WriteLine(filter(6));
            Console.WriteLine(filter(10));
            Console.WriteLine(filter(12));
            #endregion


            Console.ReadLine();
        }

        public static void SayHello(string person)
        {
            Console.WriteLine($"Hello there { person }");
        }

        public static void SayGoodBye(string person)
        {
            Console.WriteLine($"Good bye { person }. Have a nice day!");
        }

        public static void SayWhatever(string whateverMessage, SayDelegate sayDel)
        {
            Console.WriteLine("This message comes from chat bot:");
            sayDel(whateverMessage);
        }

        public static void NumberMaster(int num1, int num2, NumberDelegate numberDel)
        {
            Console.WriteLine($"The result is { numberDel(num1, num2) }");
        }

        public static int Sum(int num1, int num2)
        {
            return num1 + num2;
        }

        //Method for demo purpose for instantiating the generic delegate
        public static bool IsGreaterThenTen(int number)
        {
            return number > 10;
        }
    }
}
