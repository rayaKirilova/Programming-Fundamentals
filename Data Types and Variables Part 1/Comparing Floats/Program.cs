using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Comparing_Floats
{
    class Program
    {
        static void Main(string[] args)
        {
            double numberA = double.Parse(Console.ReadLine());
            double numberB = double.Parse(Console.ReadLine());

            double eps = 0.000001;
            double diff = Math.Abs(numberA - numberB);

            if (diff >= eps)
            {
                Console.WriteLine("False");
            }
            else if (diff < eps)
            {
                Console.WriteLine("True");
            }
        }
    }
}
