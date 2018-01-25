using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel
{
    class Program
    {
        static void Main(string[] args)
        {
            string month = Console.ReadLine();
            double nightsCount = double.Parse(Console.ReadLine());

            double priceStudio = 0;
            double priceDouble = 0;
            double priceSuite = 0;

            if (month == "May")
            {
                priceDouble = nightsCount * 65;
                priceSuite = nightsCount * 75;
                priceStudio = nightsCount * 50;

                if (nightsCount > 7)
                {
                    priceStudio = nightsCount * 50 * 0.95;
                }
            }

            if (month == "October")
            {
                priceDouble = nightsCount * 65;
                priceSuite = nightsCount * 75;
                priceStudio = nightsCount * 50;

                if (nightsCount > 7)
                {
                    priceStudio = (nightsCount - 1) * 50 * 0.95;
                }
            }
            else if (month == "June")
            {
                priceStudio = nightsCount * 60;
                priceSuite = nightsCount * 82;
                priceDouble = nightsCount * 72;

                if (nightsCount > 14)
                {
                    priceDouble = nightsCount * 72 * 0.90;
                }
            }
            else if (month == "September")
            {
                priceStudio = nightsCount * 60;
                priceSuite = nightsCount * 82;
                priceDouble = nightsCount * 72;

                if (nightsCount > 14)
                {
                    priceDouble = nightsCount * 72 * 0.90;
                }
                else if (nightsCount > 7)
                {
                    priceStudio = (nightsCount - 1) * 60;
                }
            }
            else if (month == "July")
            {
                priceStudio = nightsCount * 68;
                priceSuite = nightsCount * 89;
                priceDouble = nightsCount * 77;

                if (nightsCount > 14)
                {
                    priceSuite = nightsCount * 89 * 0.85;
                }
            }
            else if (month == "August")
            {
                priceStudio = nightsCount * 68;
                priceSuite = nightsCount * 89;
                priceDouble = nightsCount * 77;

                if (nightsCount > 14)
                {
                    priceSuite = nightsCount * 89 * 0.85;
                }
            }
            else if (month == "December")
            {
                priceStudio = nightsCount * 68;
                priceSuite = nightsCount * 89;
                priceDouble = nightsCount * 77;

                if (nightsCount > 14)
                {
                    priceSuite = nightsCount * 89 * 0.85;
                }
            }

            Console.WriteLine("Studio: {0:F2} lv.", priceStudio);
            Console.WriteLine("Double: {0:F2} lv.", priceDouble);
            Console.WriteLine("Suite: {0:F2} lv.", priceSuite);
        }
    }
}
