using System;
using System.Collections.Generic;
using System.Text;

// namespace SEDC.CSharpAdv.Class04.Extensions.Piggybacking
namespace System
{
    public static class Helpers
    {
        public static string QuoteStringPiggybacking(this string text)
        {
            return '"' + text + '"';
        }

        public static List<T> GetInfoPiggybacking<T>(this List<T> list)
        {
            T first = list[0];
            Console.WriteLine($"This lisst has {list.Count} members of typr {first.GetType().Name}");
            return list;
        }
    }
}
