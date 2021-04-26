using Static.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace Static
{
    //static class -> only static members
    public static class TextHelper
    {
        public static int NumOfMessagesGenerated { get; set; } = 0;
        public static void GenerateStatusMessage(OrderStatus status)
        {
            string result = "";
            switch (status)
            {
                case OrderStatus.Processed:
                    Console.ForegroundColor = ConsoleColor.Blue;
                    result = "[Processing] Your order is processed";
                    break;
                case OrderStatus.Delivered:
                    Console.ForegroundColor = ConsoleColor.Green;
                    result = "[Delivered] Your order is delivered";
                    break;
                case OrderStatus.CouldNotDeliver:
                    Console.ForegroundColor = ConsoleColor.Red;
                    result = "[Could not be delivered] Your order is not delivered";
                    break;
                default:
                    break;
            }
            Console.WriteLine(result);
            Console.ResetColor();
            NumOfMessagesGenerated++;
        }

        public static int ValidateInput(string input)
        {
            bool success = int.TryParse(input, out int choice);
            if (success)
            {
                return choice;
            }
            return -1;
        }
    }
}
