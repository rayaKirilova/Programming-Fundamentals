using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Variable_in_Hexadecimal_Format
{
    class Program
    {
        static void Main(string[] args)
        {
            string decimalNumber = Console.ReadLine();

            int convertNumber = Convert.ToInt32(decimalNumber, 16);

            Console.WriteLine(convertNumber);
        }
    }
}
