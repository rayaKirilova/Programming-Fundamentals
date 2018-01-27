using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Count_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> listWithNumbers = Console.ReadLine().Split(' ').Select(int.Parse).ToList();

            listWithNumbers.Sort();

            var position = 0;

            while (position < listWithNumbers.Count)
            {
                int number = listWithNumbers[position];
                int count = 1;

                while (position + count < listWithNumbers.Count &&
                       listWithNumbers[position + count] == number)

                    count++;

                position = position + count;

                Console.WriteLine($"{number} -> {count}");
            }
        }
    }
}
