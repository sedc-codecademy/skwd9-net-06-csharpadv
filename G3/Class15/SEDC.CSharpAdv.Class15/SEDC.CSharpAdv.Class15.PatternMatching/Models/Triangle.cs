using System;
using System.Collections.Generic;
using System.Text;

namespace SEDC.CSharpAdv.Class15.PatternMatching.Models
{
    public class Triangle
    {
        public double Base { get; set; }
        public double Height { get; set; }

        public Triangle(double baseValue, double height)
        {
            Base = baseValue;
            Height = height;
        }
    }
}
