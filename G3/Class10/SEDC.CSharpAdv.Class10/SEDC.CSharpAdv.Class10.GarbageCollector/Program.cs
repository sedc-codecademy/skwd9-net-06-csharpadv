using System;
using System.Linq;

namespace SEDC.CSharpAdv.Class10.GarbageCollector
{
    class Program
    {
        static void Main(string[] args)
        {
            var data = Enumerable.Repeat("abcdefg", 80000);
            string str = string.Empty;

            foreach (var word in data)
            {
                str += word;
            }

            Console.ReadLine();
        }
    }
}
