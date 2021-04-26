using System;
using System.Collections.Generic;
using System.Text;

namespace Polymorphism_Dynamic.Entities
{
    public class NormalCar : ICar
    {
        public string MotorNumber { get; set; }

        public NormalCar()
        {
            MotorNumber = MotorNumber + "-N"; // N is for Normal
        }
        public NormalCar(string engineNumber)
        {
            MotorNumber = engineNumber + "-N";
        }
        public void Refuel()
        {
            Console.WriteLine("Refueling with petrol.");
        }
    }
}
