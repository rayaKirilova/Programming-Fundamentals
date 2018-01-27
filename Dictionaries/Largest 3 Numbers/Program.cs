using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Largest_3_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> nums = Console.ReadLine()
               .Split()
               .Select(int.Parse)
               .ToList();

            nums = nums.OrderByDescending(num => num).Take(3).ToList();

            Console.WriteLine(String.Join(", ", nums));
        }
    }
}
