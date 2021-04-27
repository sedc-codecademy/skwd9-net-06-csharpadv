using SEDC.Class03.Interfaces.ConsoleApp.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace SEDC.Class03.Interfaces.ConsoleApp.Models
{
    public class Developer : Human, IDevelop
    {

        public Developer(string firstName, string lastName, int age) : base(firstName,lastName,age)
        {
                
        }
        public override void CelebrateBirthday()
        {
            Console.WriteLine($"{this.FirstName} {this.LastName} celebrates his/birthday");
        }

        public void Code()
        {
            Console.WriteLine($"The developer {this.FirstName} codes his application");
        }

        public void FindTheProject(ITesterable tester)
        {
            Console.WriteLine(tester.BugsFound);
        }
    }
}
