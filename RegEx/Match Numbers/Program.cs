using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions; 

namespace Match_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            string pattern = @"(^|(?<=\s))-?\d+(\.\d+)?($|(?=\s))"; // possitive lookbehind & possitive lookahead !!

            string nums = Console.ReadLine();

            MatchCollection matchedNums = Regex.Matches(nums, pattern);

            foreach (Match item in matchedNums)
            {
                Console.Write(item.Value + " ");
            }

            Console.WriteLine();
        }
    }
}
