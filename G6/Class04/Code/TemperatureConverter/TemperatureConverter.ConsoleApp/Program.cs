using System;

namespace TemperatureConverter.ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter celsius");
            string celsius = Console.ReadLine();
            Console.WriteLine("Please enter fehrenheights");
            string fehrenhieht = Console.ReadLine();
            double ferenhightResult = TemperatureConverter.ConvertCelsiusToFerenhight(celsius);
            double celsiusResult = TemperatureConverter.ConvertFerenheightsToCelsius(fehrenhieht);
            Console.WriteLine($"{celsius}C are {ferenhightResult} ferenhights");
            Console.WriteLine($"{fehrenhieht}C are {celsiusResult} celsius");
            //This  will not function. We can not create an instace of a static class.
            //TemperatureConverter tc = new TemperatureConverter();
            int counter = TemperatureConverter.Counter;
            Console.WriteLine(counter);
            Console.ReadLine();
        }
    }
}
