using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calories_Counter
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int sum = 0;

            for (int i = 1; i <= n; i++)
            {
                string ingredient = Console.ReadLine().ToLower();

                if (ingredient == "cheese")
                {
                    sum += 500;
                }
                else if (ingredient == "tomato sauce")
                {
                    sum += 150;
                }
                else if (ingredient == "salami")
                {
                    sum += 600;
                }
                else if (ingredient == "pepper")
                {
                    sum += 50;
                }
            }
            Console.WriteLine("Total calories: {0}", sum);
        }
    }
}
