using System;
using System.Collections.Generic;
using System.Text;

namespace HandsOnDay5
{
    internal class temeperatureConvert
    {
        static void Main()
        {
            double fahrenheit = 98;  
            double output = FahrenheitToCelsius(fahrenheit);

            Console.WriteLine("Output = " + output);
        }

        static double FahrenheitToCelsius(double f)
        {
            if (f < 0)
                return -1;

            double celsius = (f - 32) * 5 / 9;
            return celsius;
        }
    }
}
