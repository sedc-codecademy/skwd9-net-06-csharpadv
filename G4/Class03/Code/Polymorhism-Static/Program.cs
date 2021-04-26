using System;

namespace Polymorhism_Static
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("--- Polymorphism AdHoc or Static ---");
            PrintData p = new PrintData();
            p.Print(100);
            p.Print(100.0);
            p.Print("Sto");
            p.Print((int)100, (double)100);
            p.Print(100, 100.0);
            p.Print(100.05M, 100);
            p.Print(100.02F, 100L);
            Console.ReadLine();
        }
    }
}
