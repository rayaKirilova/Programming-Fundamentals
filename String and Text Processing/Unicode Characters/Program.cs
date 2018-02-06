using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Unicode_Characters
{
    class Program
    {
        static void Main(string[] args)
        {
            char[] chars = Console.ReadLine().ToCharArray();

            foreach (char item in chars)
            {
                Console.Write("\\u{0:x4}", Convert.ToUInt16(item));           
            }
        }
    }
}
