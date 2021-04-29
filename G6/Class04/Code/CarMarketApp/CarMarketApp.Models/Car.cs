using System;
using System.Collections.Generic;
using System.Linq;

namespace CarMarketApp.Models
{
    public class Car
    {
        public Car(int kmPassed, CarMake make, DateTime dateOfProduction, bool isRegistered, FuelType fuelType)
        {
            Id = _id++;
            KilometersPassed = kmPassed;
            CarMake = make;
            YearOfProduction = dateOfProduction;
            IsRegistered = isRegistered;
            FuelType = fuelType;
            CarMakeWithModels = GetCarMakeAndModelsByCarMake(make);
        }

        private static int _id = 1;
        private int Id { get; set; }
        public int KilometersPassed { get; set; }
        public CarMake CarMake { get; set; }
        public Dictionary<CarMake,List<string>> CarMakeWithModels { get; set; }
        public DateTime YearOfProduction { get; set; }
        public bool IsRegistered { get; set; }
        public FuelType FuelType { get; set; }
        public string Temperature { get; set; }

        private Dictionary<CarMake,List<string>> GetCarMakeAndModelsByCarMake(CarMake make)
        {
            Dictionary<CarMake, List<string>> result = new Dictionary<CarMake, List<string>>();
            switch (make)
            {
                case CarMake.Alfa:
                    result.Add(this.CarMake, new List<string>() { "157","Mito","Julieta" });
                    break;
                case CarMake.Audi:
                    result.Add(this.CarMake, new List<string>() { "A3", "A4", "A5" });
                    break;
                case CarMake.BWM:
                    result.Add(this.CarMake, new List<string>() { "318", "320", "520" });
                    break;
                case CarMake.Benz:
                    result.Add(this.CarMake, new List<string>() { "A class", "B class", "C class","S500" });
                    break;
                case CarMake.Citroen:
                    result.Add(this.CarMake, new List<string>() { "C1", "C2", "Cactus" });
                    break;
                case CarMake.Dacia:
                    result.Add(this.CarMake, new List<string>() { "Sandero", "Duster" });
                    break;
                case CarMake.Fiat:
                    result.Add(this.CarMake, new List<string>() { "Punto", "Grande punto" });
                    break;
                default:
                    break;
            }
            return result;
        }

        public static void PrintCarInfo(Car car)
        {
            Console.WriteLine($"The car {car.CarMake} has the following models available:");
            foreach (var item in car.CarMakeWithModels.Values.First())
            {
                Console.WriteLine(item);
            }
            Console.WriteLine($"The car {car.CarMake} runs on {car.FuelType}");
        }

        public int GetId()
        {
            return this.Id;
        }
    }
}
