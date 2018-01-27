using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Largest_Common_End
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] firstRow = Console.ReadLine()
                .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

            string[] secondRow = Console.ReadLine()
                .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

            int counterLeftSide = 0;

            int length = Math.Min(firstRow.Length, secondRow.Length);

            for (int i = 0; i < length; i++)
            {
                if (firstRow[i] == secondRow[i])
                {
                    counterLeftSide++;
                }
                else
                {
                    break;
                }
            }

            Array.Reverse(firstRow);
            secondRow = secondRow.Reverse().ToArray();

            int counterRightSide = 0;
            for (int i = 0; i < length; i++)
            {
                if (firstRow[i] == secondRow[i])
                {
                    counterRightSide++;
                }
                else
                {
                    break;
                }
            }
            Console.WriteLine($"{Math.Max(counterLeftSide, counterRightSide)}");
        }
    }
}