using System;
using System.Collections.Generic;
using System.Text;

namespace SEDC.CSharpAdv.Class02.Examples
{
    public abstract class BaseParser
    {
        public string GetInputFromScreen(string message)
        {
            Console.WriteLine(message);
            string input = Console.ReadLine();
            return input;
        }
    }
}
