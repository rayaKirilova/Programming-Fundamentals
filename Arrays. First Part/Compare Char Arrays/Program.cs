using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Compare_Char_Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            char[] firstArray = Console.ReadLine()
                .Split()
                .Select(char.Parse)
                .ToArray();

            char[] secondArray = Console.ReadLine()
                .Split()
                .Select(char.Parse)
                .ToArray();

            int minLength = Math.Min(firstArray.Length, secondArray.Length);
            bool isFirst = false;

            for (int i = 0; i < minLength; i++)
            {
                int index1 = (int)firstArray[i];
                int index2 = (int)secondArray[i];

                if (index1 <= index2)
                {
                    isFirst = true;
                }
                else
                {
                    break;
                }
            }

            if (isFirst == true && minLength == firstArray.Length)
            {
                Console.WriteLine(string.Join("", firstArray));
                Console.WriteLine(string.Join("", secondArray));
            }
            else
            {
                Console.WriteLine(string.Join("", secondArray));
                Console.WriteLine(string.Join("", firstArray));
            }
        }
    }
}
