using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Special_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            int sumOfDigits = 0;
            int lastDigit = 0;

            bool isSpecial = false;

            for (int i = 1; i <= number; i++)
            {
                lastDigit = i;

                while (i > 0)
                {
                    sumOfDigits += i % 10;
                    i = i / 10;
                }

                isSpecial = (sumOfDigits == 5) || (sumOfDigits == 7) || (sumOfDigits == 11);

                Console.WriteLine($"{lastDigit} -> {isSpecial}");

                sumOfDigits = 0;
                i = lastDigit;
            }
        }
    }
}
