using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reverse_String
{
    class Program
    {
        static void Main(string[] args)
        {
            char[] word = Console.ReadLine().ToArray();

            var reversed = word.Reverse();

            Console.WriteLine(string.Join("", reversed));
        }
    }
}
