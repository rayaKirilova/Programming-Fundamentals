﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculate_Triangle_Area
{
    class Program
    {
        static void Main(string[] args)
        {
            double width = double.Parse(Console.ReadLine());
            double height = double.Parse(Console.ReadLine());

            double triangleArea = TriangleArea(width, height);

            Console.WriteLine(triangleArea);
        }

        static double TriangleArea(double width, double height)
        {
            return width * height / 2;
        }
    }
}
