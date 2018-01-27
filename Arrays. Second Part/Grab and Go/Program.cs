using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grab_and_Go
{
    class Program
    {
        static void Main(string[] args)
        {
            List<long> listOfNumbers = Console.ReadLine().Split().Select(long.Parse).ToList();

            long number = long.Parse(Console.ReadLine());

            if (listOfNumbers.Contains(number))
            {
                int index = 0;

                for (int i = 0; i < listOfNumbers.Count; i++)
                {
                    if (listOfNumbers[i] == number)
                    {
                        index = i;
                    }
                }
                Console.WriteLine(listOfNumbers.Take(index).Sum());
            }
            else
            {
                Console.WriteLine("No occurrences were found!");
            }
        }
    }
}
    