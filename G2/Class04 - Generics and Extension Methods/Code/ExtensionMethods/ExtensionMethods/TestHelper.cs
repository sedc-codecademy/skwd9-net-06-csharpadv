
using System;
using System.Collections.Generic;
using System.Text;

namespace ExtensionMethods.Entities
{
    public static class TestHelper
    {
        public static void PrintMessage(this Test test)
        {
            Console.WriteLine("We are in the Test extension method");
        }
    }
}
