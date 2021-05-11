using System;

namespace Delegates
{
    class Program
    {
        public delegate void GreetDelegate(string message);
        public delegate int NumberDelegate(int num1, int num2);
        static void Main(string[] args)
        {
            GreetDelegate helloDelegate = new GreetDelegate(SayHello);
            GreetDelegate byeDelegate = new GreetDelegate(SayGoodbye);
            GreetDelegate hiDelegate = new GreetDelegate(x => Console.WriteLine($"Hi {x}"));

            helloDelegate("SEDC");
            byeDelegate("Freddy");
            hiDelegate("Ana");

            SayWhatever("Paul", SayHello);
            SayWhatever("Bill", SayGoodbye);
            SayWhatever("Ana", x =>
            {
                Console.WriteLine($"Hello from SEDC {x}");
                Console.WriteLine($"Goodbye from SEDC {x}");

            });

            NumbersOperation(2, 3, (x, y) => x + y);
            NumbersOperation(2, 3, (x, y) => x - y);
            NumbersOperation(2, 3, (x, y) => {
                if (x > y)
                    return x;
                return y;
            
            });

            Console.ReadLine();
        }

        public static void SayHello(string message)
        {
            Console.WriteLine($"Hello, {message}");
        }

        public static void SayGoodbye(string person)
        {
            Console.WriteLine($"Bye bye {person}");
        }

        public static void SayWhatever(string message, GreetDelegate greetDelegate)
        {
            Console.WriteLine("Inside SayWhatever:");
            greetDelegate(message);
        }

        public static void NumbersOperation(int n1, int n2, NumberDelegate numberDelegate)
        {
            Console.WriteLine($"Result is: {numberDelegate(n1, n2)}");
        }
    }
}
