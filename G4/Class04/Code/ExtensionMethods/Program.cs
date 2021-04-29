using ExtensionMethods.Helpers;
using System;
using System.Collections.Generic;

namespace ExtensionMethods
{
    class Program
    {
        static void Main(string[] args)
        {
            #region String Extension Methods
            // long string
            string text = "C# Advanced is a great subject with great demo code and cool activities!";

            string someOtherText = "Once upon a time there was a beautiful princess...";

            // Here we are calling the extension method Shorten on the text string and saying
            // that we want to take the first 6 words from it and QuouteString() method
            // just wraps that string in quotes.
            string cutText = text.Shorten(6);
            Console.WriteLine(cutText);
            string qoutedText = someOtherText.Shorten(5).QuoteString();
            Console.WriteLine(qoutedText);
            #endregion

            #region List Extension Methods
            List<string> strings = new List<string>() { "string01", "string02", "string03" };
            List<int> integers = new List<int>() { 1, 2, 3, 4, 5 };
            List<bool> booleans = new List<bool>() { true, true, false, true, false };

            strings.GoThrough();
            strings.GetInfo();

            integers.GoThrough();
            integers.GetInfo();

            booleans.GoThrough();
            booleans.GetInfo();
            #endregion

            Console.ReadLine();
        }
    }
}
