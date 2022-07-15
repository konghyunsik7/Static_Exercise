using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Static_Exercise
{
    public static class TempConvertor
    {
        //subtract 32 and multiply by . 5556 (or 5/9).
        public static double FahrenheitToCelsius(double temp) 
        {
            return (temp - 32) / 1.8;
        }
        //multiply by 1.8 (or 9/5) and add 32.
        public static double CelsiusToFahrenheit(double temp)
        {
            return (temp * 1.8) + 32;
        }
    }
}
