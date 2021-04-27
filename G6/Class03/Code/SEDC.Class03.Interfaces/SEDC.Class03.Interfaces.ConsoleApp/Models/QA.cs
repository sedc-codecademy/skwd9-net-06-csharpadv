using SEDC.Class03.Interfaces.ConsoleApp.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace SEDC.Class03.Interfaces.ConsoleApp.Models
{
    public class QA : Human, ITesterable, IDevelop
    {
        public QA(string firstName, string lastName, int age) : base(firstName, lastName,age)
        {

        }

        public int BugsFound { get; set ; }

        public override void CelebrateBirthday()
        {
            Console.WriteLine($"{this.FirstName} {this.LastName} celebrates his/birthday and has {this.Age}");
        }

        public void Code()
        {
            Console.WriteLine("coding.....");
            Console.WriteLine("Checking stack overfolw...");
            Console.WriteLine("Coding...");
        }

        public void TestCode()
        {
            Console.WriteLine("The qa is testing the code");
        }
    }
}
