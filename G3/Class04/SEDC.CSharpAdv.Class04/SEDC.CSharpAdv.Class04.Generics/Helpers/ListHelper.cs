using SEDC.CSharpAdv.Class04.Generics.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace SEDC.CSharpAdv.Class04.Generics.Helpers
{
    public class ListHelper
    {
        public void GoThrough<T>(List<T> list)
        {
            foreach(T item in list)
            {
                Console.WriteLine(item);
            }
        }

        public void GetInfo<T>(List<T> list)
        {
            T first = list[0];
            Console.WriteLine($"This lisst has {list.Count} members of typr {first.GetType().Name}");
        }

        public void Print<T>(List<T> list)
            where T : BaseEntity
        {
            foreach(T item in list)
            {
                Console.WriteLine(item.GetInfo());
            }
        }

        public void GoThroughStrings(List<string> list)
        {
            foreach(string item in list)
            {
                Console.WriteLine(item);
            }
        }

        public void GetInfoForString(List<string> list)
        {
            string first = list[0];
            Console.WriteLine($"This lisst has {list.Count} members of typr {first.GetType().Name}");
        }

        public void GoThroughIntegers(List<int> list)
        {
            foreach(int item in list)
            {
                Console.WriteLine(item);
            }
        }

        public void GetInfoForInteger(List<int> list)
        {
            int first = list[0];
            Console.WriteLine($"This lisst has {list.Count} members of typr {first.GetType().Name}");
        }
    }
}
