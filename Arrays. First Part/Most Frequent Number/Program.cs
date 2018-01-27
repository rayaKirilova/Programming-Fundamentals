using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Most_Frequent_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            int counter = 0;
            int longestOccurance = 0;
            int mostFrequentNumber = 0;

            for (int i = 0; i < numbers.Length; i++)
            {
                counter = 0;

                for (int j = 0; j < numbers.Length; j++)
                {
                    if (numbers[j] == numbers[i])
                    {
                        counter++;
                    }
                }

                if (counter > longestOccurance)
                {
                    longestOccurance = counter;
                    mostFrequentNumber = numbers[i];
                }
            }

            Console.WriteLine(mostFrequentNumber);
        }
    }
}
