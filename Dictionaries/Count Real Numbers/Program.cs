using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Count_Real_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] numbers = Console.ReadLine()
                .Split(' ')
                .Select(double.Parse)
                .ToArray();

            var counts = new SortedDictionary<double, int>();

            foreach (var n in numbers)
            {
                if (counts.ContainsKey(n))
                {
                    counts[n]++;
                }
                else
                {
                    counts[n] = 1;
                }
            }

            foreach (var n in counts.Keys)
            {
                Console.WriteLine($"{n} -> {counts[n]}");
            }
        }
    }
}
