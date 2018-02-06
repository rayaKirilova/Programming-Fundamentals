using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Distance_Between_Points
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] firstPoints = Console.ReadLine()
                .Split(' ')
                .Select(double.Parse)
                .ToArray();

            double[] secondPoints = Console.ReadLine()
                .Split(' ')
                .Select(double.Parse)
                .ToArray();

            double x1 = firstPoints[0];
            double y1 = firstPoints[1];
            double x2 = secondPoints[0];
            double y2 = secondPoints[1];

            double sideA = Math.Abs(x1 - x2);
            double sideB = Math.Abs(y1 - y2);

            double distance = Math.Sqrt(sideA * sideA + sideB * sideB);

            Console.WriteLine("{0:F3}", distance);
        }
    }
}
