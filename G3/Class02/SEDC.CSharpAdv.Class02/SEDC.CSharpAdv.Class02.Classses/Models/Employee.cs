using System;
using System.Collections.Generic;
using System.Text;

namespace SEDC.CSharpAdv.Class02.Classses.Models
{
    public class Employee
    {
        public string FullName { get; set; }
        private int Salary { get; set; }

        public Employee(string name, int salary)
        {
            FullName = name;
            Salary = salary;
        }

        public virtual int GetSalary()
        {
            return Salary;
        }
    }
}
