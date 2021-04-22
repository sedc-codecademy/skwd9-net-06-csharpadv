using System;
using System.Collections.Generic;
using System.Text;

namespace SEDC.CSharpAdv.Class02.Classses.Models
{
    public class SalesPerson : Employee
    {
        public int Revenue { get; set; }

        public SalesPerson(string name, int salary)
            : base(name, salary)
        {
            Revenue = 0;
        }

        public void AddRevenue(int sold)
        {
            Revenue += sold;
        }

        public override int GetSalary()
        {
            if(Revenue > 100)
            {
                return base.GetSalary() + 1000;
            }
            return base.GetSalary();
        }
    }
}
