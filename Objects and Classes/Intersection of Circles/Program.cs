using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Intersection_of_Circles
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] firstValues = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int[] secondValues = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            // first Circle 
            int xPointOfFirstCircle = firstValues[0];
            int yPointOfFirstCircle = firstValues[1];
            int radiusOfFirstCircle = firstValues[2];

            // second Circle
            int xPointOfSecondCircle = secondValues[0];
            int yPointOfSecondCircle = secondValues[1];
            int radiusOfSecondCircle = secondValues[2];

            double distance = Math.Sqrt(Math.Pow((xPointOfSecondCircle - xPointOfFirstCircle), 2) +
                Math.Pow((yPointOfSecondCircle - yPointOfFirstCircle), 2));

            int sumRadiuses = radiusOfFirstCircle + radiusOfSecondCircle;

            if (distance <= sumRadiuses)
            {
                Console.WriteLine("Yes");
            }
            else
            {
                Console.WriteLine("No");
            }
        }
    }
}
