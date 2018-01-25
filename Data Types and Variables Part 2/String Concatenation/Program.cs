using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace String_Concatenation
{
    class Program
    {
        static void Main(string[] args)
        {
            char delimiter = char.Parse(Console.ReadLine());
            string evenOrOdd = Console.ReadLine();
            int n = int.Parse(Console.ReadLine());

            string onEvens = "";
            string onOdds = "";

            int i = 1;

            for (i = 1; i <= n; i++)
            {
                string data = Console.ReadLine();

                if (i % 2 == 0)
                {
                    onEvens += data + delimiter;
                }
                else if (i % 2 != 0)
                {
                    onOdds += data + delimiter;
                }
            }
            if (evenOrOdd == "even")
            {
                Console.WriteLine(onEvens.Remove(onEvens.Length - 1, 1));
            }
            else if (evenOrOdd == "odd")
            {
                Console.WriteLine(onOdds.Remove(onOdds.Length - 1, 1));
            }
        }
    }
}
