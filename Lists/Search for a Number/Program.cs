using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Search_for_a_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToList();

            int[] commands = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToArray();

            var numsYouHaveToTake = commands[0];
            var numsYouHaveToDelete = commands[1];
            var numThatMustBeInList = commands[2];

            var hasNumber = numbers
                .Take(numsYouHaveToTake)
                .Skip(numsYouHaveToDelete)
                .Any(x => x == numThatMustBeInList);

            Console.WriteLine(hasNumber ? "YES!" : "NO!");
        }
    }
}
