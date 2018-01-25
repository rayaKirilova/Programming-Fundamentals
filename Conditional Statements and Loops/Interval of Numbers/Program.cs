using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interval_of_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            var number1 = int.Parse(Console.ReadLine());
            var number2 = int.Parse(Console.ReadLine());

            if (number1 < number2)
            {
                for (int i = number1; i <= number2; i++)
                {
                    Console.WriteLine(i);
                }
            }
            else if (number1 > number2)
            {
                for (int k = number2; k <= number1; k++)
                {
                    Console.WriteLine(k);
                }
            }
        }
    }
}
