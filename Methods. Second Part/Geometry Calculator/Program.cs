using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geometry_Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            string figure = Console.ReadLine();

            if (figure == "triangle")
            {
                double side = double.Parse(Console.ReadLine());
                double height = double.Parse(Console.ReadLine());
                TriangleArea(side, height);
            }
            else if (figure == "rectangle")
            {
                double width = double.Parse(Console.ReadLine());
                double height = double.Parse(Console.ReadLine());
                RectangleArea(width, height);
            }
            else if (figure == "square")
            {
                double side = double.Parse(Console.ReadLine());
                SquareArea(side);
            }
            else if (figure == "circle")
            {
                double radius = double.Parse(Console.ReadLine());
                CircleArea(radius);
            }
        }

        static void TriangleArea(double side, double height)
        {
            double area = side * height / 2;
            Console.WriteLine($"{area:F2}");
        }

        static void RectangleArea(double width, double height)
        {
            double area = width * height;
            Console.WriteLine($"{area:F2}");
        }

        static void SquareArea(double side)
        {
            double area = side * side;
            Console.WriteLine($"{area:F2}");
        }

        static void CircleArea(double radius)
        {
            double area = Math.PI * radius * radius;
            Console.WriteLine($"{area:F2}");
        }
    }
}
    