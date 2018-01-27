﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays_Statistics
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();

            Console.WriteLine("Min = " + numbers.Min());
            Console.WriteLine("Max = " + numbers.Max());
            Console.WriteLine("Sum = " + numbers.Sum());
            Console.WriteLine("Average = " + numbers.Average());
        }
    }
}
