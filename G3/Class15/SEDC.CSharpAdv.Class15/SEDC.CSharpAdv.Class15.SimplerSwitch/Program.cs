using System;

namespace SEDC.CSharpAdv.Class15.SimplerSwitch
{
    class Program
    {
        public enum MessageType
        {
            Warning,
            Error,
            Info,
            Success
        }

        public static void PrintMessage(MessageType type, string message)
        {
            ConsoleColor color = ConsoleColor.White;
            switch (type)
            {
                case MessageType.Warning:
                    color = ConsoleColor.Yellow;
                    break;
                case MessageType.Error:
                    color = ConsoleColor.Red;
                    break;
                case MessageType.Info:
                    color = ConsoleColor.Blue;
                    break;
                case MessageType.Success:
                    color = ConsoleColor.Green;
                    break;
                default:
                    throw new ArgumentException("Invalid enum value");
            }
            Console.ForegroundColor = color;
            Console.WriteLine(message);
            Console.ResetColor();
        }

        public static void PrintMessage(string message, MessageType type)
        {
            ConsoleColor color = type switch
            {
                MessageType.Warning => ConsoleColor.Yellow,
                MessageType.Error => ConsoleColor.Red,
                MessageType.Info => ConsoleColor.Blue,
                MessageType.Success => ConsoleColor.Green,
                _ => throw new ArgumentException("Invalid enum type")
            };
            Console.ForegroundColor = color;
            Console.WriteLine(message);
            Console.ResetColor();
        }

        static void Main(string[] args)
        {
            PrintMessage(MessageType.Error, "This is old way for switch");
            PrintMessage("This is the new way", MessageType.Success);

            Console.WriteLine("You have the numbers 8 and 2. Enter operation for calculating: (-, +, /, *)");
            string operation = Console.ReadLine();
            int result = operation switch
            {
                "+" => 8 + 2,
                "-" => 8 - 2,
                "*" => 8 * 2,
                "/" => 8 / 2,
                _ => throw new Exception("Invalid operator")
            };

            PrintMessage($"The result is {result}", MessageType.Info);

            Console.ReadLine();
        }
    }
}
