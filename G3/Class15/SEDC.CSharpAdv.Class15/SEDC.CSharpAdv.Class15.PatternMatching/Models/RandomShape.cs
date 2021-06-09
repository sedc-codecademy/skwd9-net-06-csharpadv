using System;
using System.Collections.Generic;
using System.Text;

namespace SEDC.CSharpAdv.Class15.PatternMatching.Models
{
    public class RandomShape
    {
        public double SideA { get; set; }
        public double SideB { get; set; }
        public double SideC { get; set; }
        public double SideD { get; set; }

        public RandomShape(double sideA, double sideB, double sideC, double sideD)
        {
            SideA = sideA;
            SideB = sideB;
            SideC = sideC;
            SideD = sideD;
        }
    }
}
