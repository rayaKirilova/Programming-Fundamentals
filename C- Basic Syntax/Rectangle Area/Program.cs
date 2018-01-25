using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rectangle_Area
{
    class Program
    {
        static void Main(string[] args)
        {
            double width = Double.Parse(Console.ReadLine());
            double height = Double.Parse(Console.ReadLine());

            double area = width * height ;

            Console.WriteLine("{0:F2}", area);
        }
    }
}
