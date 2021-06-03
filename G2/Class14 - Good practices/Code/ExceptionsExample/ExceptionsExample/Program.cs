using ExceptionsExample.CustomExceptions;
using System;

namespace ExceptionsExample
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Enter a");
                int a = int.Parse(Console.ReadLine());

                Console.WriteLine("Enter b");
                int b = int.Parse(Console.ReadLine());

                if (a < b)
                    throw new NumberException("a is smaller than b");

                string text = null;
                Console.WriteLine(text.Length);
            }
            catch(NumberException e)
            {
                Console.WriteLine(e.Message);
            }
            catch(FormatException e)
            {
                Console.WriteLine(e.Message);
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }



            Console.ReadLine();
        }
    }
}
