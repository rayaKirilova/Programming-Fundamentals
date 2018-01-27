﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Odd_Filter
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine()
               .Split()
               .Select(int.Parse)
               .Where(x => x % 2 == 0)
               .ToList();

            var average = numbers.Average();

            numbers = numbers.Select(x => x = x > average ? ++x : --x)
            .ToList();

            Console.WriteLine(string.Join(" ", numbers));

        }
    }
}
