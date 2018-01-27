using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace Factorial_Trailing_Zeroez
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());

            BigInteger factorial = 1;

            for (int i = 1; i <= number; i++)
            {
                factorial *= i;
            }


            Console.WriteLine(CalculateTrailingZeroes(factorial));
        }


        public static int CalculateTrailingZeroes(BigInteger number)
        {
            int zeroesCounter = 0;

            while (number % 10 == 0)
            {
                zeroesCounter++;
                number /= 10;
            }

            return zeroesCounter;
        }
    }
}
    