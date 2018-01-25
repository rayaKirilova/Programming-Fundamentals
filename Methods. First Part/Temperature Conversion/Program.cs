using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Temperature_Conversion
{
    class Program
    {
        static void Main(string[] args)
        {
            double temperatureFahrenheit = double.Parse(Console.ReadLine());
            double celsius = FahrenheitToCelsius(temperatureFahrenheit);

            Console.WriteLine("{0:F2}", celsius);
        }

        static double FahrenheitToCelsius(double fahrenheit)
        {
            return (fahrenheit - 32) * 5 / 9;
        }
    }
}
