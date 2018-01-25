using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Greater_of_Two_Values
{
    class Program
    {
        static void Main(string[] args)
        {
            string type = Console.ReadLine();

            if (type == "int")
            {
                int firstNumber = int.Parse(Console.ReadLine());
                int secondNumber = int.Parse(Console.ReadLine());

                int numberToPrint = GetMax(firstNumber, secondNumber);
                Console.WriteLine(numberToPrint);
            }
            else if (type == "char")
            {
                char firstLetter = char.Parse(Console.ReadLine());
                char secondLetter = char.Parse(Console.ReadLine());

                char letterToPrint = GetMax(firstLetter, secondLetter);

                Console.WriteLine(letterToPrint);
            }
            else if (type == "string")
            {
                string first = Console.ReadLine();
                string second = Console.ReadLine();

                Console.WriteLine(GetMax(first, second));
            }
        }

        static int GetMax(int firstNumber, int secondNumber)
        {
            if (firstNumber >= secondNumber)
            {
                return firstNumber;
            }
            else
            {
                return secondNumber;
            }
        }

        static char GetMax(char firstLetter, char secondLetter)
        {
            if (firstLetter >= secondLetter)
            {
                return firstLetter;
            }
            else
            {
                return secondLetter;
            }
        }

        static string GetMax(string first, string second)
        {
            if (first.CompareTo(second) >= 0)
            {
                return first;
            }
            else
            {
                return second;
            }
        }
    }
}
    