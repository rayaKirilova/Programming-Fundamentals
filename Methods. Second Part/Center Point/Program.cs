using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Center_Point
{
    class Program
    {
        static void Main(string[] args)
        {

            double x1 = double.Parse(Console.ReadLine());
            double y1 = double.Parse(Console.ReadLine());
            double x2 = double.Parse(Console.ReadLine());
            double y2 = double.Parse(Console.ReadLine());

            double point1 = PointCloserToTheCenter(x1, y1);
            double point2 = PointCloserToTheCenter(x2, y2);

            var list = new List<double>();

            if (point1 >= point2)
            {
                list.Add(x2);
                list.Add(y2);
            }
            else
            {
                list.Add(x1);
                list.Add(y1);
            }

            Console.Write("(");
            Console.Write(String.Join(", ", list));
            Console.WriteLine(")");

        }
        public static double PointCloserToTheCenter(double x, double y)
        {
            double distance = Math.Sqrt(Math.Pow(x, 2) + Math.Pow(y, 2));
            return distance;
        }
    }
}
