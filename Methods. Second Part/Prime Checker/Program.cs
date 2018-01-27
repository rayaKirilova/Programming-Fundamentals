using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prime_Checker
{
    class Program
    {
        static void Main(string[] args)
        {
            long number = long.Parse(Console.ReadLine());

            Console.WriteLine(IsNumberPrime(number));
        }

        static bool IsNumberPrime(long number)
        {
            int sqrtNumber = (int)Math.Sqrt(number);

            if (number <= 1)
            {
                return false;
            }
            else
            {
                for (int divisor = 2; divisor <= sqrtNumber; divisor++)
                {
                    if (number % divisor == 0)
                    {
                        return false;
                        break;
                    }
                }
            }
            return true;
        }
    }
}
    