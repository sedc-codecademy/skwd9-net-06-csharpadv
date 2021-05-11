using System;
using System.Collections.Generic;
using System.Text;

namespace SEDC.CSharpAdv.Class07.Delegates
{
    public class Example
    {
        public void WelcomeMessage()
        {
            Console.WriteLine("Welcome to events and delegates");
        }

        public void PrintMessage(string message, string name)
        {
            Console.WriteLine($"{message} | {name}");
        }

        public int SumOfTwoNumbers(int num, int num1)
        {
            return num + num1;
        }
    }
}
