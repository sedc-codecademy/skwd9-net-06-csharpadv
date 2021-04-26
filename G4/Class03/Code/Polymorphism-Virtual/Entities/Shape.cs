using System;
using System.Collections.Generic;
using System.Text;

namespace Polymorphism_Virtual.Entities
{
    public class Shape
    {
        protected int Width = 2; // default value
        protected int Height = 2; // default value

        public Shape()
        {

        }
        public Shape(int width, int height)
        {
            Width = width;
            Height = height;
        }

        public virtual double Area()
        {
            Console.WriteLine("Parent Class area:");
            return Width * Height;
        }
    }
}
