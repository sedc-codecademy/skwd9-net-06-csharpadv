using System;
using System.Collections.Generic;
using System.Text;

namespace Polymorphism_Dynamic.Entities
{
    public class HybridCar : ICar
    {
        public int BatteryLifeMonths { get; set; }
        public int BatteryDuration { get; set; }
        public string MotorNumber { get; set; }
        public HybridCar()
        {
            MotorNumber = MotorNumber + "-H"; // H - for hybrid
        }
        public HybridCar(string engineNumber)
        {
            MotorNumber = engineNumber + "-H";
        }
        public void Refuel()
        {
            Console.WriteLine("Hybrid refueling: Petrol or Battery");
        }
    }
}
