using System;
using System.Collections.Generic;
using System.Text;

namespace CarMarketApp.Models
{
    public static class TemperatureConverter
    {
        public static double ConvertFromFarenhietToCelsius(double farenhight)
        {
            return farenhight - 32 / 1.8;
        }
    }
}
