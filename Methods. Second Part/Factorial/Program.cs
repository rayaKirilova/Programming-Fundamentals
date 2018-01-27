using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics; 


namespace Factorial
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());

            BigInteger factorial = 1;

            do
            {
                factorial *= number;
                number--;
            }
            while (number > 0);
            {
                Console.WriteLine(factorial);
            }

        }
    }
}
