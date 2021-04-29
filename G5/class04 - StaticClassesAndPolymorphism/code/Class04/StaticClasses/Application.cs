using System;
using System.Collections.Generic;
using System.Text;

namespace StaticClasses
{
    public class Application
    {
        public void Run() 
        {
            Console.WriteLine(Calculator.PI);
            var result = Calculator.Divide(10, 2);
        }
    }
}
