using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sum_Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array1 = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToArray();

            int[] array2 = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToArray();

            int maxLenght = Math.Max(array1.Length, array2.Length);
            int[] result = new int[maxLenght];

            for (int i = 0; i < maxLenght; i++)
            {
                result[i] = array1[i % array1.Length] + array2[i % array2.Length];
            }

            Console.WriteLine(string.Join(" ", result));
        }
    }
}
