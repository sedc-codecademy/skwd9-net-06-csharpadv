using System;
using System.Collections.Generic;
using System.Text;

namespace GenericsDemo.GenericMethods
{
    public static class GenericListHelper
    {
        public static string GetElementsOfTheList<T>(this List<T> list)
        {
            string info = string.Empty;

            //Possible way to check if an object is of specific type, 
            //with this we are breaking the generic approach of the function and we are creating specific things
            //if (list is List<Human>)

            for (int i = 0; i < list.Count; i++)
            {
                info += $"{i + 1}. {list[i]}\n";
            }

            return info;
        }

        public static string GetSequenceElementsOfTheList<T>(this List<T> list)
        {
            return string.Join("; ", list);
        }
    }
}
