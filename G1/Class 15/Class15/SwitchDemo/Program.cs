using System;

namespace SwitchDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            PrintMassage("This is an info", MessageType.Info);
            PrintMassage("Error happened", MessageType.Error);
        }

        //static void PrintMassage(string message, MessageType type)
        //{
        //    ConsoleColor color;

        //    switch (type)
        //    {
        //        case MessageType.Info:
        //            color = ConsoleColor.Blue;
        //            break;
        //        case MessageType.Warning:
        //            color = ConsoleColor.Yellow;
        //            break;
        //        case MessageType.Success:
        //            color = ConsoleColor.Green;
        //            break;
        //        case MessageType.Error:
        //            color = ConsoleColor.Red;
        //            break;
        //        default:
        //            throw new ArgumentException("Invalid message type");
        //    }

        //    Console.ForegroundColor = color;
        //    Console.WriteLine(message);
        //    Console.ResetColor();
        //}

        static void PrintMassage(string message, MessageType type)
        {
            ConsoleColor color = type switch
            {
                MessageType.Info => ConsoleColor.Blue,
                MessageType.Warning => ConsoleColor.Yellow,
                MessageType.Success => ConsoleColor.Green,
                MessageType.Error => ConsoleColor.Red,
                _ => throw new ArgumentException("Invalid message type")
            };

            Console.ForegroundColor = color;
            Console.WriteLine(message);
            Console.ResetColor();
        }
    }
}
