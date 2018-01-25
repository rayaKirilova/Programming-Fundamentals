using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int firstNumber = int.Parse(Console.ReadLine());
            int secondNumber = int.Parse(Console.ReadLine());
            int testNumber = int.Parse(Console.ReadLine());

            int counterCombinations = 0;
            int product = 0;

            for (int i = firstNumber; i >= 1; i--)
            {
                for (int k = 1; k <= secondNumber; k++)
                {
                    counterCombinations++;
                    product += 3 * (i * k);

                    if (product >= testNumber)
                    {
                        Console.WriteLine($"{counterCombinations} combinations");
                        Console.WriteLine($"Sum: {product} >= {testNumber}");
                        return;
                    }
                }
            }

            if (product < testNumber)
            {
                Console.WriteLine($"{counterCombinations} combinations");
                Console.WriteLine($"Sum: {product}");
            }
        }
    }
}
