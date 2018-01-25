using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Choose_a_Drink_2._0
{
    class Program
    {
        static void Main(string[] args)
        {
            string profession = Console.ReadLine();
            double quantity = double.Parse(Console.ReadLine());

            double price = 0;

            if (profession == "Athlete")
            {
                price = quantity * 0.70;
                Console.WriteLine("The {0} has to pay {1:F2}.", profession, price);
            }
            else if (profession == "Businessman" || profession == "Businesswoman")
            {
                price = quantity * 1.00;
                Console.WriteLine("The {0} has to pay {1:F2}.", profession, price);
            }
        }
    }
}
