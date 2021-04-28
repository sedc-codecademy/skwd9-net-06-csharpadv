using System;

namespace StaticDemo
{
    public static class TextHelper
    {
        public static string Text { get; set; }

        static TextHelper()
        {
            Text = "Simple text";
        }

        public static int ConvertStringToInt(string text)
        {
            bool success = int.TryParse(text, out int number);

            if(!success)
            {
                throw new Exception("Invalid number");
            }

            return number;
        }
    }
}
