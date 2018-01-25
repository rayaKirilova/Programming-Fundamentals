using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Multiplication_Table
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());

            int result = 1;

            for (int i = 1; i <= 10; i++)
            {
                result = number * i;
                Console.WriteLine($"{number} X {i} = {result}");
            }
        }
    }
}
