using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractClassAndInterface.Entities
{
    public class Tester : Human
    {
        public int BugsFound { get; set; }

        public Tester()
        {

        }
        public Tester(string fullName, int age, long phone, int bugs)
            : base(fullName, age, phone)
        {
            BugsFound = bugs;
        }

        public void TestFeature(string feature)
        {
            Console.WriteLine($"{feature} is being tested...");
            Console.WriteLine("Testing complete!");
        }
        public override string GetInfo()
        {
            return $"{FullName} ({Age}) - found {BugsFound} bugs in your code :)";
        }
    }
}
