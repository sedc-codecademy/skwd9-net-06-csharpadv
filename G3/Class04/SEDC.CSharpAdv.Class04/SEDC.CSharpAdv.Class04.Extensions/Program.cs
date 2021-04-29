using SEDC.CSharpAdv.Class04.Extensions.Entites;
using SEDC.CSharpAdv.Class04.Extensions.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;

namespace SEDC.CSharpAdv.Class04.Extensions
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> strings = new List<string> { "Trajan", "Nikola", "Bob", "Jill" };
            List<int> ints = new List<int> { 1, 2, 3, 4, 5, 6, 7 };
            List<double> doubles = new List<double> { 1.1, 1.2, 1.3, 2.1, 2.2, 2.3 };

            //strings.GoThrough<string>();
            //ints.GoThrough<int>();

            //strings.GetInfo<string>().GoThrough<string>();
            //doubles.GetInfo().GoThrough();

            //string text = "C# Advanced is an awesome subject with great demos and activities!";
            //Console.WriteLine(text.QuoteString());
            //string str = text.Shorten(6);
            //Console.WriteLine(str);

            //string str1 = text.Shorten(6).QuoteString();
            //Console.WriteLine(str1);

            Product product = new Product() { Id = 3 };
            product.PrintProductId();

            strings.GetInfoPiggybacking();
            strings[0].QuoteStringPiggybacking();

            Console.ReadLine();
        }
    }
}
