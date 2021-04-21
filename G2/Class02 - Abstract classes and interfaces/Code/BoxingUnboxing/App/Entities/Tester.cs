using System;
using System.Collections.Generic;
using System.Text;

namespace App.Entities
{
    public class Tester: Employee
    {
        public int NumOfFoundBugs { get; set; }
        public void Test()
        {
            Console.WriteLine("Testing..");
        }
    }
}
