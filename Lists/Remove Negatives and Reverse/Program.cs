using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Remove_Negatives_and_Reverse
{
    class Program
    {
        static void Main(string[] args)
        {
            var numbers = Console.ReadLine()
                         .Split(' ')
                         .Select(int.Parse)
                         .ToList();

            List<int> allNumbers = new List<int>();

            numbers.Reverse();

            numbers.RemoveAll(i => i < 0);

            if (numbers.Count > 0)
            {
                Console.WriteLine(string.Join(" ", numbers));
            }
            else
            {
                Console.WriteLine("empty");
            }
        }
    }
}
