using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sum_Reversed_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> listOfNumbers = Console.ReadLine()
            .Split(' ')
            .Select(int.Parse)
            .ToList();

            int sum = 0;

            for (int i = 0; i < listOfNumbers.Count; i++)
            {
                int reversed = 0;

                int temp = listOfNumbers[i];

                while (temp != 0)
                {
                    reversed = reversed * 10;
                    reversed = reversed + temp % 10;
                    temp = temp / 10;
                }

                sum = sum + reversed;
            }
            Console.WriteLine(sum);

        }
    }
}

