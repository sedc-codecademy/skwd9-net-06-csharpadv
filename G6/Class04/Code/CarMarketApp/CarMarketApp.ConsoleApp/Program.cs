using CarMarketApp.Models;
using System;

namespace CarMarketApp.ConsoleApp
{
    class Program
    {
        //static method overloading.
        // Static method polymorphysm
        // We can not have methods with same name and same parameters orders
        //The return type does not play any role.
        //We use theese methods because they return the same kind of data but depending on the 
        // parameters they return more specific data or less specific data.
        //string.Format() has 8 overloads. Every method formats the string but depending
        //on the parameters it formats it in a different way
        static void PrintCarInfo(Car car, string owner)
        {

        }

        static void PrintCarInfo(Car car)
        {
            Console.WriteLine("The car is of model " + car.CarMake);
        }

        static void PrintCarInfo(string owner, Car car)
        {
            Console.WriteLine("The owner of the car is " + owner + " car is " + car.CarMake);
        }
        //This throws an exception
        //static string PrintCarInfo(Car car)
        //{
        //    return string.Empty;
        //}
        static void Main(string[] args)
        {
            Car bmw = new Car(100000, CarMake.BWM, new DateTime(2008, 01, 01), true, FuelType.Diesel);
            Car citroen = new Car(70000, CarMake.Citroen, new DateTime(2010, 05, 05), false, FuelType.Petrol);
            Car.PrintCarInfo(citroen);
            Console.WriteLine($"The bmw car has an id of {bmw.GetId()}");
            Console.WriteLine($"The citroen car has an id of {citroen.GetId()}");
            Console.WriteLine("Please enter car temperature in farenhights");
            string userInput = Console.ReadLine();
            bool isRealDouble = double.TryParse(userInput, out double ferenhights);
            if (isRealDouble)
            {
                double celsius = TemperatureConverter.ConvertFromFarenhietToCelsius(ferenhights);
                Console.WriteLine("The car has a temperature of " + celsius + " degrees");
            }
            Console.ReadLine();
        }
    }
}
