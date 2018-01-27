using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Max_Sequence_of_Increasing_Elements
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int arrayLength = numbers.Length;

            IncreasingElements(numbers, arrayLength);
        }

        static void IncreasingElements(int[] numbers, int arrayLength)
        {
            int countCurrentSequence = 0;
            int start = 0;
            int countMaxSequence = 0;
            int startMaxSequence = 0;

            for (int i = 1; i < arrayLength; i++)
            {
                if (numbers[i] - numbers[i - 1] >= 1)
                {
                    countCurrentSequence++;
                    start = i - countCurrentSequence;

                    if (countCurrentSequence > countMaxSequence)
                    {
                        countMaxSequence = countCurrentSequence;
                        startMaxSequence = start;
                    }
                }
                else
                {
                    countCurrentSequence = 0;
                }
            }
            for (int j = startMaxSequence; j <= (startMaxSequence + countMaxSequence); j++)
            {
                Console.Write(numbers[j] + " ");
            }
            Console.WriteLine();
        }
    }
}
