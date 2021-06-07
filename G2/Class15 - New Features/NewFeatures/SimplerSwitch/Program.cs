using System;

namespace SimplerSwitch
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter an operation for the numbers 5 and 3 (+, -, /, *) :");
            string operation = Console.ReadLine();
            double result = 0;
            try
            {
                result = operation switch
                {
                    "+" => 5 + 3,
                    "-" => 5 - 3,
                    "/" => 5 / 3,
                    "*" => 5 * 3,
                    _ => throw new ArgumentException("Invalid operation")
                };
            }
            catch(Exception e)
            {
                PrintMessage(MessageType.Error, e.Message);
            }
            PrintMessage(MessageType.Success, $"The result is {result}");

            Console.ReadLine();
        }
        public static void PrintMessage(MessageType messageType, string message)
        {
            ConsoleColor consoleColor = messageType switch
            {
                MessageType.Success => ConsoleColor.Green,
                MessageType.Error => ConsoleColor.Red,
                MessageType.Info => ConsoleColor.Yellow,
                _ => throw new ArgumentException("Invalid message type")
            };
            Console.ForegroundColor = consoleColor;
            Console.WriteLine(message);
            Console.ResetColor();
        }
    }
}
