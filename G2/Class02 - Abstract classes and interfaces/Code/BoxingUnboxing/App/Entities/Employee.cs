using System;
using System.Collections.Generic;
using System.Text;

namespace App.Entities
{
    public class Employee
    {
        public string FullName { get; set; }
        public string Company { get; set; }

        public string GetInfo()
        {
            return $"{FullName} works in {Company}";
        }
    }
}
