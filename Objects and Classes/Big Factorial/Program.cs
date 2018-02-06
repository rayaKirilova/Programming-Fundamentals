using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace Big_Factorial
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            BigInteger factorial = n;

            for (int i = n - 1; i >= 1; i--)
            {
                factorial = factorial * i;
            }

            Console.WriteLine(factorial);
        }
    }
}
