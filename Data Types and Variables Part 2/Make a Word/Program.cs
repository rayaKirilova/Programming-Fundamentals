using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Make_a_Word
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            string word = "";

            for (int k = 0; k < n; k++)
            {
                char letter = char.Parse(Console.ReadLine());
                word += letter;
            }

            Console.WriteLine($"The word is: {word}");
        }
    }
}
