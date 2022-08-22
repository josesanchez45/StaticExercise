using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaticExercise
{
    public static class TempConverter
    {
        public static double FarenheitToCelsius(double farenheit)
        {
            return (farenheit - 32) * 5 / 9;
        }
        public static double CelsiusToFarenheit(double celsius)
        {
            return (celsius * 1.8) + 32;
        }

    }
}
