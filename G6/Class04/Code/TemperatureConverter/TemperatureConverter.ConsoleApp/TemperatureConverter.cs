namespace TemperatureConverter.ConsoleApp
{
    public static class TemperatureConverter
    {
        //We can't declare instance members in static class.
        // We must use the word static!
        //This throws compiletime error
        //public string ConverterType { get; set; }
        //This method too will throw an error
        //public double ConvertCelsiusToFerenhight(string userInput)
        //{
        //    return 3.2;
        //}
        //In static class we can have only static constructors.
        //The static constructor is called only once.
        static TemperatureConverter()
        {
            System.Console.WriteLine("Constructor called");
        }

        public static int Counter { get; set; } = 1;

        public static double ConvertCelsiusToFerenhight(string userInput)
        {
            Counter++;
            bool realCelsiusDegrees = double.TryParse(userInput, out double celsius);
            if (!realCelsiusDegrees)
            {
                throw new System.Exception("Can not conver the input to double");
            }
            double ferenheigts = celsius * 1.8 + 32;
            return ferenheigts;
        }

        public static double ConvertFerenheightsToCelsius(string userInput)
        {
            Counter++;
            bool realCelsiusDegrees = double.TryParse(userInput, out double ferenheights);
            if (!realCelsiusDegrees)
            {
                throw new System.Exception("Can not conver the input to double");
            }
            double celsius = (ferenheights - 32) / 1.8;
            return celsius;
        }
    }
}
