using SEDC.CSharpAdv.Class15.PatternMatching.Models;
using System;

namespace SEDC.CSharpAdv.Class15.PatternMatching
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Square sq = new Square(5);
                Console.WriteLine($"Area of square with side 5 is: {ComputeArea(sq)}");

                RandomShape rs = new RandomShape(1, 2, 3, 4);
                Console.WriteLine($"Area of RandomShape with sides 1, 2, 3, 4 is: {ComputeArea(rs)}");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            Console.ReadLine();

            try
            {
                Triangle triangle = new Triangle(5, 6);
                Console.WriteLine($"Area of triangle with base 5, height 6 is: {ComputeAreaNew(triangle)}");

                RandomShape randomShape = new RandomShape(1, 2, 3, 4);
                Console.WriteLine($"Area of RandomShape with sides 1, 2, 3, 4 is: {ComputeAreaNew(randomShape)}");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            Console.ReadLine();
        }

        public static double ComputeArea(object shape)
        {
            if (shape is Square)
            {
                Square s = (Square)shape;
                return s.Side * s.Side;
            } 
            else if (shape is Circle)
            {
                Circle c = (Circle)shape;
                return c.Radius * c.Radius + Math.PI;
            }
            else if (shape is Triangle)
            {
                Triangle t = (Triangle)shape;
                return (t.Height * t.Base) / 2;
            }
            throw new ArgumentException("shape is not a recignized shape", nameof(shape));
        }

        public static double ComputeAreaNew(object shape)
        {
            if (shape is Square s)
            {
                return s.Side * s.Side;
            }
            else if (shape is Circle c)
            {
                return c.Radius * c.Radius + Math.PI;
            }
            else if (shape is Triangle t)
            {
                return (t.Height * t.Base) / 2;
            }
            throw new ArgumentException("shape is not a recignized shape", nameof(shape));
        }
    }
}
