using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Integer_to_Hex_and_Binary
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());

            string hexNumber = number.ToString("X");

            Console.WriteLine(hexNumber);
            Console.WriteLine("{0}", Convert.ToString(number, 2));
    }
    }
}
