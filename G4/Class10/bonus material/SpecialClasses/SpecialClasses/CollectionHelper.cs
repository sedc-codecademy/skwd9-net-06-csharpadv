using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpecialClasses
{
    // static class that we can access from everywhere
    public static class CollectionHelper
    {
        // This will be the same value from everywhere, no matter from where do we change it
        public static int NumberOfUses = 0;
        public static void CycleThroughStrings(List<string> list)
        {
            foreach (string item in list)
            {
                Console.WriteLine(item);
            }
            NumberOfUses++;
        }
        public static void CycleThroughIntegers(List<int> list)
        {
            foreach (int item in list)
            {
                Console.WriteLine(item);
            }
            NumberOfUses++;
        }
    }
}
