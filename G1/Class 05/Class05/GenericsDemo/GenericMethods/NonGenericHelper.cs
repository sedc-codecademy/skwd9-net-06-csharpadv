using System;
using System.Collections.Generic;
using System.Text;

namespace GenericsDemo.GenericMethods
{
    public static class NonGenericHelper
    {
        public static void SwapInt(ref int a, ref int b)
        {
            int temp = a;
            a = b;
            b = temp;
        }

        public static void SwapString(ref string a, ref string b)
        {
            string temp = a;
            a = b;
            b = temp;
        }
    }
}
