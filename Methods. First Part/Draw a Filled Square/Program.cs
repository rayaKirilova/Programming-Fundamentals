using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Draw_a_Filled_Square
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            Console.WriteLine(new string('-', 2 * n));

            PrintMiddleRow(n);

            Console.WriteLine(new string('-', 2 * n));
        }

        private static void PrintMiddleRow(int n)
        {
            for (int k = 0; k < n - 2; k++)
            {
                Console.Write("-");

                for (int j = 1; j < n; j++)
                {
                    Console.Write("\\/");
                }
                Console.WriteLine("-");
            }
        }
    }
}