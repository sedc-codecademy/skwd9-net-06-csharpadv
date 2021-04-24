using System;
using System.Collections;
using System.Collections.Generic;

namespace SEDC.CSharpAdv.Class02.Examples
{
    class Program
    {
        static void Main(string[] args)
        {
            IInputParser parser = new InputParser();

            int selected = parser.ToInt(1, 5);
            Console.WriteLine(selected);

            Console.ReadLine();
        }
    }
}
