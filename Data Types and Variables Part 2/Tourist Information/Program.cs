using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tourist_Information
{
    class Program
    {
        static void Main(string[] args)
        {
            string unit = Console.ReadLine();
            double value = double.Parse(Console.ReadLine());

            double convertValue = 0;

            if (unit == "miles")
            {
                convertValue = value * 1.6;
                Console.WriteLine($"{value} {unit} = {convertValue:F2} kilometers");
            }
            else if (unit == "inches")
            {
                convertValue = value * 2.54;
                Console.WriteLine($"{value} {unit} = {convertValue:F2} centimeters");
            }
            else if (unit == "feet")
            {
                convertValue = value * 30;
                Console.WriteLine($"{value} {unit} = {convertValue:F2} centimeters");
            }
            else if (unit == "yards")
            {
                convertValue = value * 0.91;
                Console.WriteLine($"{value} {unit} = {convertValue:F2} meters");
            }
            else if (unit == "gallons")
            {
                convertValue = value * 3.8;
                Console.WriteLine($"{value} {unit} = {convertValue:F2} liters");
            }
        }
    }
}
    