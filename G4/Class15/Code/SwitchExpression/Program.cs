﻿using System;

namespace SwitchExpression
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
        static void Main(string[] args)
        {
            try
            {
                PrintMessage(MessageType.Info, "You have the numbers 2 and 9. Enter the operation for calculating: (+, -, * or /)");
                string operation = Console.ReadLine();
                //int result;

                //// old switch statement
                //switch (operation)
                //{
                //    case "+":
                //        result = 2 + 9;
                //        break;
                //    case "-":
                //        result = 2 - 9;
                //        break;
                //    case "*":
                //        result = 2 * 9;
                //        break;
                //    case "/":
                //        result = 2 / 9;
                //        break;
                //    default:
                //        throw new ArgumentException("Invalid operation");
                //        break;
                //}

                // new switch expression
                int result = operation switch
                {
                    "+" => 2 + 9,
                    "-" => 2 - 9,
                    "*" => 2 * 9,
                    "/" => 2 / 9,
                    _ => throw new ArgumentException("Invalid operation")
                };
                PrintMessage(MessageType.Success, $"The result is {result}");
                Console.ReadLine();
            }
            catch (Exception ex)
            {
                PrintMessage(MessageType.Error, ex.Message);
            }
            Console.ReadLine();
        }

        public static void PrintMessage(MessageType type, string message)
        {
            ConsoleColor consoleColor = type switch
            {
                MessageType.Warning => ConsoleColor.Yellow,
                MessageType.Error => ConsoleColor.Red,
                MessageType.Info => ConsoleColor.Blue,
                MessageType.Success => ConsoleColor.Green,
                _ => throw new ArgumentException("No such message type")
            };
            Console.ForegroundColor = consoleColor;
            Console.WriteLine(message);
            Console.ResetColor();
        }
    }
}
