using System;
using System.Collections.Generic;
using System.Text;

namespace SEDC.CSharpAdv.Class02.AbstractClassesAndInterfaces.Entities
{
    public class QAEngineer : Human
    {
        public List<string> TestingFrameworks { get; set; }

        public QAEngineer(string fullname, int age, long phone, List<string> frameworks)
            : base(fullname, age, phone)
        {
            TestingFrameworks = frameworks;
        }

        public override string GetInfo()
        {
            return $"{FullName} ({Age}) - Knows {(TestingFrameworks.Count != 0 ? TestingFrameworks[0] : "unknown")} frameworks!";
        }
    }
}
