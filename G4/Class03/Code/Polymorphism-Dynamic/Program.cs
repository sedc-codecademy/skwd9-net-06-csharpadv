using Polymorphism_Dynamic.Entities;
using System;
using System.Collections.Generic;

namespace Polymorphism_Dynamic
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("--------- Polymorphism Dynamic -----------");
            List<ICar> cars = new List<ICar>()
            {
                new NormalCar("W23592352HJ45"),
                new HybridCar("VW79879HGSDS"),
                new ElectricCar("T767HBGKJ43543")
            };

            cars[0].Refuel();
            cars[1].Refuel();
            cars[2].Refuel();

            Console.ReadLine();
        }
    }
}
