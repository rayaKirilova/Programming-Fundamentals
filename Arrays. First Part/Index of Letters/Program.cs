using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Index_of_Letters
{
    class Program
    {
        static void Main(string[] args)
        {
            char[] alphabetLetters = Console.ReadLine().ToCharArray();

            for (int i = 0; i < alphabetLetters.Length; i++)
            {
                Console.WriteLine("{0} -> {1}", alphabetLetters[i], alphabetLetters[i] - 'a');
            }
        }
    }
}
