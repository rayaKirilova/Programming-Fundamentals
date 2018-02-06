using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions; 

namespace Match_Phone_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            string pattern = @"(\+359 2 \d{3} \d{4}\b)|(\+359-2-\d{3}-\d{4}\b)";
            string phoneNumbers = Console.ReadLine();

            MatchCollection phones = Regex.Matches(phoneNumbers, pattern);

            var phonesToPrint = phones.Cast<Match>().Select(a => a.Value.Trim()).ToArray();

            Console.WriteLine(string.Join(", ", phonesToPrint));
        }
    }
}
