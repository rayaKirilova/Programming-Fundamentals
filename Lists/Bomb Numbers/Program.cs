using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bomb_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split(' ')
                .Select(int.Parse)
                .ToList();

            int[] specialNumbers = Console.ReadLine().Split(' ')
                .Select(int.Parse)
                .ToArray();

            for (int i = 0; i < numbers.Count; i++)
            {
                if (numbers[i] == specialNumbers[0])
                {
                    for (int j = 1; j <= specialNumbers[1]; j++)
                    {
                        if (i - j < 0)
                        {
                            break;
                        }
                        else
                        {
                            numbers[i - j] = 0;
                        }
                    }

                    for (int j = 1; j <= specialNumbers[1]; j++)
                    {
                        if (i + j > numbers.Count - 1)
                        {
                            break;
                        }
                        else
                        {
                            numbers[i + j] = 0;
                        }
                    }

                    numbers[i] = 0;
                }
            }
            int sum = numbers.Sum();

            Console.WriteLine(sum);
        }
    }
}

