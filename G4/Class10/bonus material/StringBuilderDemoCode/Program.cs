using System;
using System.Text;

namespace StringBuilderDemoCode
{
    class Program
    {
        static void Main(string[] args)
        {
            String word = "hi";
            StringBuilder newString = new StringBuilder("Hello");

            newString.Append(" G4");
            newString.Append('!', 3);
            newString.AppendLine();
            newString.Append("We are learning StringBuilder today!");
            //newString.Remove(0, 6);
            //newString.Replace("We are learning StringBuilder today!", "Lets go home");
            newString.Insert(0, "Testing... Testing...   ");

            Console.WriteLine(newString);

            Console.ReadLine();
        }
    }
}
