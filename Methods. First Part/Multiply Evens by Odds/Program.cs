using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Multiply_Evens_by_Odds
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int positiveNumber = (int)Math.Sqrt(Math.Pow(n, 2));

            int productOfEvenAndOdd = GetMultiplyEvenByOdds(positiveNumber);

            Console.WriteLine(productOfEvenAndOdd);

        }

        private static int GetMultiplyEvenByOdds(int positiveNumber)
        {
            int sumEven = GetSumOfEvenDigits(positiveNumber);
            int sumOdds = GetSumOfOddDigits(positiveNumber);
            return sumEven * sumOdds;
        }

        private static int GetSumOfOddDigits(int positiveNumber)
        {
            int sumOdd = 0;

            while (positiveNumber > 0)
            {
                int lastDigit = positiveNumber % 10;

                if (lastDigit % 2 != 0)
                {
                    sumOdd += lastDigit;
                }
                positiveNumber /= 10;
            }
            return sumOdd;
        }

        private static int GetSumOfEvenDigits(int positiveNumber)
        {
            int sumEven = 0;

            while (positiveNumber > 0)
            {
                int lastDigit = positiveNumber % 10;
                if (lastDigit % 2 == 0)
                {
                    sumEven += lastDigit;
                }

                positiveNumber /= 10;
            }
            return sumEven;
        }
    }
}
