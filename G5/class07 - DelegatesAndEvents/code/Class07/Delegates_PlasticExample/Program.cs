using System;

namespace Delegates_PlasticExample
{
    class Program
    {
        public delegate void GreetingsFunctionDelegate(string message);

        static void Main(string[] args)
        {
            // Delegate is a type safe function pointer. Delegates holds a reference (pointer) to a function.
            // The signature of the delegate must match the signature of the function that delegates points to.

            GreetingsFunctionDelegate delegate1 = new GreetingsFunctionDelegate(Greetings);
            GreetingsFunctionDelegate delegate2 = new GreetingsFunctionDelegate(Bye);

            GreetingsFunctionDelegate delegate3 = new GreetingsFunctionDelegate(name => Console.WriteLine($"Hello {name} from the anonymous function."));

            delegate1("Viktor");
            delegate2("Angela");
            delegate3("Greg");

            Console.ReadLine();
        }

        public static void Greetings(string name) 
        {
            Console.WriteLine($"Hello {name}.");
        }

        public static void Bye(string name)
        {
            Console.WriteLine($"Bye {name}.");
        }
    }
}
