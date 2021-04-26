using System;
using System.Collections.Generic;
using System.Text;

namespace Polymorphism_Virtual.Entities
{
    public class Triangle : Shape
    {
        public Triangle() : base()
        {

        }

        public Triangle(int width, int height) : base(width, height)
        {

        }

        public override double Area()
        {
            Console.WriteLine("Triangle area: ");
            return (Width * Height / 2);
        }
    }
}
