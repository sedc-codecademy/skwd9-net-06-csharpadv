using System;

namespace DelegatesDemo
{
    class Program
    {
        public delegate string SayDelegate(string something);

        public delegate int OperationDelegate(int a, int b);

        static void Main(string[] args)
        {
            SayDelegate del1 = new SayDelegate(SayHello);

            //Console.WriteLine(SayHello("Radmila"));
            Console.WriteLine(del1("Radmila"));

            //SayDelegate bye = new SayDelegate(SayBye);
            SayDelegate bye = SayBye;
            Console.WriteLine(bye("Radmila"));

            SayDelegate wow = new SayDelegate(x => $"Wow {x}!");
            Console.WriteLine(wow("Radmila"));


            ChatBotSays("Risto", SayHello);
            ChatBotSays("Risto", SayBye);
            //ChatBotSays("Risto", wow);
            ChatBotSays("Risto", x => $"Wow {x}!");
            ChatBotSays("Risto", x =>
            {
                return $"You have selected something ...";
            });

            Calculate(3, 5, (x, y) => x + y);
            Calculate(3, 5, (x, y) => x - y);
            Calculate(3, 5, (x, y) => x * y);
            Calculate(3, 5, (x, y) =>
            {
                if (y == 0)
                {
                    throw new DivideByZeroException();
                }

                return x / y;
            });
        }

        public static void ChatBotSays(string whatever, SayDelegate sayDelegate)
        {
            Console.WriteLine("Chatbot says:");
            string result = sayDelegate(whatever);
            Console.WriteLine(result);
        }

        public static string SayHello(string name)
        {
            return $"Hello {name}!";
        }

        public static string SayBye(string name)
        {
            return $"Bye {name}!";
        }

        public static void Calculate(int a, int b, OperationDelegate calculate)
        {
            int result = calculate(a, b);
            Console.WriteLine($"The result is: {result}");
        }
    }
}
