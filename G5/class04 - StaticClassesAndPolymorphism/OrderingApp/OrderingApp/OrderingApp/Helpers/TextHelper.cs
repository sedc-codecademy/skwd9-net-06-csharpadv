using OrderingApp.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace OrderingApp.Helpers
{
    public static class TextHelper
    {
        public static string CapitalFirstLetter(string input) 
        {
            if (input.Length == 0) 
            {
                return "Empty String";
            }

            return char.ToUpper(input[0]) + input.Substring(1);
        }

        public static int ValidateNumberInput(string input) 
        {
            bool isMenuChoiceValid = int.TryParse(input, out int choice);

            if (!isMenuChoiceValid) 
            {
                Console.WriteLine("Wrong input...");
                return -1;
            }

            return choice;
        }

        public static void GenerateStatusMessage(OrderStatus status) 
        {
            string result = "";

            switch (status)
            {
                case OrderStatus.Processing:
                    Console.ForegroundColor = ConsoleColor.Blue;
                    result = "[Processing] The order is being processed.";
                    break;
                case OrderStatus.Delivered:
                    Console.ForegroundColor = ConsoleColor.Green;
                    result = "[Delivered] The order is successfully delivered!";
                    break;
                case OrderStatus.DeliveryInProgress:
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    result = "[In Progress] The delivery is in progress...";
                    break;
                case OrderStatus.CouldNotDeliver:
                    Console.ForegroundColor = ConsoleColor.Red;
                    result = "[Not Delivered] There was a problem with the delivery";
                    break;
                default:
                    break;
            }

            Console.WriteLine(result);
            Console.ResetColor();
        }
    }
}
