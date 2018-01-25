using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Multiplication_Table_2._0
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            int secondNumber = int.Parse(Console.ReadLine());

            int result = 1;

            for (int i = secondNumber; i <= 10; i++)
            {
                result = number * i;
                Console.WriteLine($"{number} X {i} = {result}");
            }

            if (secondNumber > 10)
            {
                int result1 = number * secondNumber;
                Console.WriteLine($"{number} X {secondNumber} = {result1}");
            }
        }
    }
}
