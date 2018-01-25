using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cake_Ingredients
{
    class Program
    {
        static void Main(string[] args)
        {
            int sumIngredients = 0;

            for (int i = 0; i <= 20; i++)
            {
                string ingredient = Console.ReadLine();
                sumIngredients++;

                if (ingredient != "Bake!")
                {
                    Console.WriteLine("Adding ingredient {0}.", ingredient);
                }
                else if (ingredient == "Bake!")
                {
                    Console.WriteLine("Preparing cake with {0} ingredients.", sumIngredients - 1);
                    break;
                }
            }
        }
    }
}