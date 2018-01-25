using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Neighbour_Wars
{
    class Program
    {
        static void Main(string[] args)
        {
            int peshoDamage = int.Parse(Console.ReadLine());
            int goshoDamage = int.Parse(Console.ReadLine());

            int goshoHealth = 100;
            int peshoHealth = 100;
            int countTurns = 0;

            while (peshoHealth > 0 && goshoHealth > 0)
            {
                countTurns++;

                if (countTurns % 2 == 0)
                {
                    peshoHealth -= goshoDamage;
                    if (peshoHealth < 1)
                    {
                        Console.WriteLine($"Gosho won in {countTurns}th round.");
                        break;
                    }
                    Console.WriteLine("Gosho used Thunderous fist and reduced Pesho to {0} health.", peshoHealth);
                }
                else
                {
                    goshoHealth -= peshoDamage;
                    if (goshoHealth < 1)
                    {
                        Console.WriteLine($"Pesho won in {countTurns}th round.");
                        break;
                    }
                    Console.WriteLine("Pesho used Roundhouse kick and reduced Gosho to {0} health.", goshoHealth);
                }

                if (countTurns % 3 == 0)
                {
                    peshoHealth += 10;
                    goshoHealth += 10;
                }
            }
        }
    }
}
