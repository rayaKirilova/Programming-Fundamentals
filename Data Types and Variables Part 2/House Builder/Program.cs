using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace House_Builder
{
    class Program
    {
        static void Main(string[] args)
        {
            long firstNumber = long.Parse(Console.ReadLine());
            long secondNumber = long.Parse(Console.ReadLine());

            long sbyteMaterials = 0;
            long intMaterials = 0;

            if (firstNumber >= sbyte.MinValue && firstNumber <= sbyte.MaxValue)
            {
                sbyteMaterials = firstNumber * 4;
                intMaterials = secondNumber * 10;
            }
            else
            {
                sbyteMaterials = secondNumber * 4;
                intMaterials = firstNumber * 10;
            }

            Console.WriteLine(sbyteMaterials + intMaterials);
        }
    }
}
