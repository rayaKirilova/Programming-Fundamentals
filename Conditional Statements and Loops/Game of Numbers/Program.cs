using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game_of_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int firstNumber = int.Parse(Console.ReadLine());
            int secondNumber = int.Parse(Console.ReadLine());
            int magicNumber = int.Parse(Console.ReadLine());

            int counter = 0;
            bool itsMagic = false;
            string magic = "";

            for (int i = firstNumber; i <= secondNumber; i++)
            {
                for (int k = firstNumber; k <= secondNumber; k++)
                {
                    counter++;

                    if ((i + k) == magicNumber)
                    {
                        magic = $"Number found! {i} + {k} = {magicNumber}";
                        itsMagic = true;
                    }
                }
            }
            if (itsMagic)
            {
                Console.WriteLine(magic);
            }
            else
            {
                Console.WriteLine($"{counter} combinations - neither equals {magicNumber}");
            }
        }
    }
}

