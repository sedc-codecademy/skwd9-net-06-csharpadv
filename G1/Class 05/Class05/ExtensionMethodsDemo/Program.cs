using System;
using ExtensionMethodsDemo.Helpers;

namespace ExtensionMethodsDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime d1 = new DateTime(1989, 7, 20);
            //int years = DateHelper.CalculateYears(d1);

            Console.WriteLine(DateHelper.CalculateYears(d1, "Risto"));
            Console.WriteLine(d1.CalculateYears("Risto"));

            string test = "Something else....";
            Console.WriteLine(test.ReplaceWithEmpty('e'));
        }
    }
}
