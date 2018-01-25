using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Miles_to_Kilometers
{
    class Program
    {
        static void Main(string[] args)
        {
            double km = double.Parse(Console.ReadLine());

            double miles = km * 1.60934;

            Console.WriteLine($"{miles:F2}");
        }
    }
}
