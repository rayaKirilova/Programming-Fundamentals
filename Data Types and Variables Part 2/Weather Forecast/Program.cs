using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Weather_Forecast
{
    class Program
    {
        static void Main(string[] args)
        {
            double numberToCheck = double.Parse(Console.ReadLine());

            if (numberToCheck % 1 == 0)
            {
                if (numberToCheck >= sbyte.MinValue && numberToCheck <= sbyte.MaxValue)
                {
                    Console.WriteLine("Sunny");
                }
                else if (numberToCheck >= int.MinValue && numberToCheck <= int.MaxValue)
                {
                    Console.WriteLine("Cloudy");
                }
                else if (numberToCheck >= long.MinValue && numberToCheck <= long.MaxValue)
                {
                    Console.WriteLine("Windy");
                }
            }
            else
            {
                Console.WriteLine("Rainy");
            }
        }
    }
}
