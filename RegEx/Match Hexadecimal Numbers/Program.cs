using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions; 

namespace Match_Hexadecimal_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            string pattern = @"\b(?:0x)?[0-9A-F]+\b";
            string input = Console.ReadLine();

            MatchCollection hexademicals = Regex.Matches(input, pattern);

            var hexNums = hexademicals.Cast<Match>().Select(a => a.Value).ToArray();

            Console.WriteLine(string.Join(" ", hexNums));
        }
    }
}
