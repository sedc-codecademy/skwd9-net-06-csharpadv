using System.Collections.Generic;

namespace GenericsDemo.GenericMethods
{
    public static class NonGenericListHelper
    {
        public static string GetElementsOfTheStringList(List<string> list)
        {
            string info = string.Empty;

            for(int i = 0; i < list.Count; i++)
            {
                info += $"{i + 1}. {list[i]}\n";
            }

            return info;
        }

        public static string GetSequenceElementsOfTheStringList(List<string> list)
        {
            return string.Join("; ", list);
        }

        public static string GetElementsOfTheIntList(List<int> list)
        {
            string info = string.Empty;

            for (int i = 0; i < list.Count; i++)
            {
                info += $"{i + 1}. {list[i]}\n";
            }

            return info;
        }

        public static string GetSequenceElementsOfTheIntList(List<int> list)
        {
            return string.Join("; ", list);
        }
    }
}
