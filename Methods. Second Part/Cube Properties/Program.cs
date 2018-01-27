using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cube_Properties
{
    class Program
    {
        static void Main(string[] args)
        {
            double side = double.Parse(Console.ReadLine());
            string parameter = Console.ReadLine();

            // face, space, volume or area

            if (parameter == "face")
            {
                CalculateFaceDiagonal(side);
            }
            else if (parameter == "space")
            {
                CalculateSpaceDiagonal(side);
            }
            else if (parameter == "volume")
            {
                CalculateVolume(side);
            }
            else if (parameter == "area")
            {
                CalculateSurfaceArea(side);
            }
        }

        static void CalculateFaceDiagonal(double side)
        {
            double faceDiagonal = Math.Sqrt(2 * side * side);
            Console.WriteLine($"{faceDiagonal:F2}");
        }

        static void CalculateSpaceDiagonal(double side)
        {
            double spaceDiagonal = Math.Sqrt(3 * side * side);
            Console.WriteLine($"{spaceDiagonal:F2}");
        }

        static void CalculateVolume(double side)
        {
            double volume = Math.Pow(side, 3);
            Console.WriteLine($"{volume:F2}");
        }

        static void CalculateSurfaceArea(double side)
        {
            double surfaceArea = 6 * side * side;
            Console.WriteLine($"{surfaceArea:F2}");
        }
    }
}

