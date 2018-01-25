using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Water_Overflow
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int capacity = 255;
            int start = capacity;

            for (int i = 0; i < n; i++)
            {
                int current = int.Parse(Console.ReadLine());

                capacity -= current;

                if (capacity < 0)
                {
                    capacity += current;
                    Console.WriteLine("Insufficient capacity!");
                }
            }
            Console.WriteLine(start - capacity);
        }
    }
}
