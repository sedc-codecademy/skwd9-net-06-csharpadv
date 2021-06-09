using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace SEDC.CSharpAdv.Class14.GettersSetters
{
    static class UsingLinq
    {
        //public IEnumerable<T> Where<T>(IEnumerable<T> list, Func<T, bool> predicate)
        //{
        //    var filteredList = new List<T>();
        //    foreach (var item in list)
        //    {
        //        if (predicate(item))
        //        {
        //            filteredList.Add(item);
        //        }
        //    }
        //    return filteredList;
        //}

        public static IEnumerable<T> Where<T>(this IEnumerable<T> list, Func<T, bool> predicate)
        {
            var filteredList = new List<T>();
            foreach (var item in list)
            {
                if (predicate(item))
                {
                    filteredList.Add(item);
                }
            }
            return filteredList;
        }

        public static void SomeMethod()
        {
            var list = new List<string>();
            // use of our where method
            list = list.Where(x => x.StartsWith("a")).ToList();
        }
    }
}
