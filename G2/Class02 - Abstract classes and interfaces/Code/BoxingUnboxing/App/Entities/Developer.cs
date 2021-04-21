using System;
using System.Collections.Generic;
using System.Text;

namespace App.Entities
{
    public class Developer : Employee
    {
        public string Project { get; set; }
        public void Code()
        {
            Console.WriteLine("Coding...");
        }
    }
}
