using System;
using System.Collections.Generic;
using System.Text;

namespace SEDC.CSharpAdv.Class14.GettersSetters
{
    public class UsingDelegates
    {
        public delegate string ToUpper(string name);

        public string SetUpperLetters(string value)
        {
            return value.ToUpper();
        }

        public string DoSomethingWithDelegate(string name, ToUpper toUpper)
        {
            return toUpper(name);
        }

        public string DoSomethingWithFunc(string name, Func<string, string> toUpper)
        {
            return toUpper(name);
        }

        public void Main()
        {
            string str = DoSomethingWithDelegate("Trajan", SetUpperLetters);
            string str1 = DoSomethingWithFunc("Trajan", SetUpperLetters);
        }
    }
}
