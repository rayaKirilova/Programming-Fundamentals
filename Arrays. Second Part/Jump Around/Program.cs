using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jump_Around
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();

            int i = 0; // позициите на елементите 
            int sum = 0;

            while (i >= 0)
            {
                if (i < numbers.Length) // проверка дали се вмества в масива 
                {
                    sum += numbers[i];
                    i = i + numbers[i] < numbers.Length ?
                        i + numbers[i] :
                        i - numbers[i];
                }
            }

            Console.WriteLine(sum);
        }
    }
}
