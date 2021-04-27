using System;
using System.Collections.Generic;
using System.Text;

namespace SEDC.CSharpAdv.Class03.Polymorphisam
{
    public class Example : IExample
    {
        public int TestMethod()
        {
            return 3;
        }

        public void TestMethod(int a)
        {
            Console.WriteLine(a);
        }

        public string TestMethod(long a)
        {
            return a.ToString();
        }

        public bool TestMethod(int a, long b)
        {
            return a < b;
        }
    }

    public interface IExample
    {
        int TestMethod();
        void TestMethod(int a);
        string TestMethod(long a);
        bool TestMethod(int a, long b);
    }
}
