using System;
using System.Collections.Generic;
using System.Text;

namespace StaticClasses.Entities
{
    // Static helper class that we can use to help us with some text stuff
    // We call there methods  without creating an instance of the class
    public static class TextHelper
    {
        // We have to use keyword static for all members in a static class
        // This value will be the same value from everywhere, no matter from where do we change it
        public static int MessagesGenerated = 0;

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
                case OrderStatus.Cancelled:
                    Console.ForegroundColor = ConsoleColor.DarkYellow;
                    result = "[Cancelled] Your order was cancelled";
                    break;
                default:
                    break;
            }
            Console.WriteLine(result);
            Console.ResetColor();
            MessagesGenerated++;
        }

        public static string CapitalFirstLetter(string word)
        {
            if(word.Length == 0)
            {
                return "Empty String";
            }
            else if (word.Length == 1)
            {
                return char.ToUpper(word[0]).ToString();
            }
            else
            {
                return char.ToUpper(word[0]) + word.Substring(1).ToLower();
            }
        }

        public static int ValidateNumberInput(string input)
        {
            int choice = 0;
            bool isMenuChoice = int.TryParse(input, out choice);
            if (!isMenuChoice)
            {
                Console.WriteLine("Wrong input...");
                return -1;
            }
            return choice;
        }
    }
}
