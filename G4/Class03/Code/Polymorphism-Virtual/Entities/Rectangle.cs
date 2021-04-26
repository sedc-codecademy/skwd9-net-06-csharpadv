using System;
using System.Collections.Generic;
using System.Text;

namespace Polymorphism_Virtual.Entities
{
    public class Rectangle : Shape
    {
        public Rectangle() : base()
        {

        }

        public Rectangle(int width, int height) : base(width, height)
        {

        }

        public override double Area()
        {
            Console.WriteLine("Reactangle class area:");
            return Width * Height;
        }
    }
}
