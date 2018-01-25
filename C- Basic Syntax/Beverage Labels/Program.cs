using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Beverage_Labels
{
    class Program
    {
        static void Main(string[] args)
        {
            string product = Console.ReadLine();
            double volume = double.Parse(Console.ReadLine());
            double energyContent = double.Parse(Console.ReadLine());
            double sugarContent = double.Parse(Console.ReadLine());

            double volumePerMl = volume / 100;
            double productKcal = energyContent * volumePerMl;
            double productSugars = sugarContent * volumePerMl;

            Console.WriteLine(volume + "ml " + product + ":");
            Console.WriteLine("{0}kcal, {1}g sugars", productKcal, productSugars);
        }
    }
}
