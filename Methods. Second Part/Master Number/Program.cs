using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Master_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());

            for (int i = 1; i <= number; i++)
            {

                if (EvenDigitAndDivisibleBy7(i) && IsNumberPalindorme(i))
                {
                    Console.WriteLine(i);
                }
            }
        }

        static bool IsNumberPalindorme(int number)
        {
            int temp = number;
            int reverse = 0;
            int remainder = 0;

            while (number > 0)
            {
                remainder = number % 10;
                reverse = reverse * 10 + remainder;
                number /= 10;
            }
            if (temp == reverse)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        static bool EvenDigitAndDivisibleBy7(int number)
        {
            int digit = 0;
            int sum = 0;
            bool divisible = false;
            bool evenDigit = false;
            int len = number.ToString().Length;
            for (int i = 0; i < len; i++)
            {
                digit = number % 10;
                if (digit % 2 == 0)
                {
                    evenDigit = true;
                }
                number /= 10;
                sum += digit;
            }
            if (sum % 7 == 0)
            {
                divisible = true;
            }
            if (divisible && evenDigit)
            {
                return true;
            }

            return false;
        }
    }
}

