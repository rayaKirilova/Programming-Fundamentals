using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Character_Stats
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();
            int currentHealth = int.Parse(Console.ReadLine());
            int maximumHealth = int.Parse(Console.ReadLine());
            int currentEnergy = int.Parse(Console.ReadLine());
            int maximumEnergy = int.Parse(Console.ReadLine());

            int dots1 = maximumHealth - currentHealth;
            int dots2 = maximumEnergy - currentEnergy;


            Console.WriteLine("Name: " + name);

            Console.WriteLine("Health: " + new string('|', maximumHealth - dots1 + 1) +
                    new string('.', dots1) + '|');


            Console.WriteLine("Energy: " + new string('|', maximumEnergy - dots2 + 1) +
                                new string('.', dots2) + '|');

        }
    }
}
