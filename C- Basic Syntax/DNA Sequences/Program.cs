using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DNA_Sequences
{
    class Program
    {
        static void Main(string[] args)
        {
            int inputSum = int.Parse(Console.ReadLine());

            // A ->> 1, C ->> 2, G ->> 3, T ->> 4

            for (int first = 1; first <= 4; first++)
            {
                for (int second = 1; second <= 4; second++)
                {
                    for (int third = 1; third <= 4; third++)
                    {

                        if (first + second + third >= inputSum)
                        {
                            Console.Write("O");
                            if (first == 1) { Console.Write("A"); }
                            else if (first == 2) { Console.Write("C"); }
                            else if (first == 3) { Console.Write("G"); }
                            else if (first == 4) { Console.Write("T"); }

                            int secondLetter = second;
                            if (secondLetter == 1) { Console.Write("A"); }
                            else if (secondLetter == 2) { Console.Write("C"); }
                            else if (secondLetter == 3) { Console.Write("G"); }
                            else if (secondLetter == 4) { Console.Write("T"); }

                            int thirdLetter = third;
                            if (thirdLetter == 1) { Console.Write("A"); }
                            else if (thirdLetter == 2) { Console.Write("C"); }
                            else if (thirdLetter == 3) { Console.Write("G"); }
                            else if (thirdLetter == 4) { Console.Write("T"); }

                            Console.Write("O");
                            Console.Write(" ");
                        }
                        else if (first + second + third < inputSum)
                        {

                            Console.Write("X");
                            if (first == 1) { Console.Write("A"); }
                            else if (first == 2) { Console.Write("C"); }
                            else if (first == 3) { Console.Write("G"); }
                            else if (first == 4) { Console.Write("T"); }

                            int secondLetter = second;
                            if (secondLetter == 1) { Console.Write("A"); }
                            else if (secondLetter == 2) { Console.Write("C"); }
                            else if (secondLetter == 3) { Console.Write("G"); }
                            else if (secondLetter == 4) { Console.Write("T"); }

                            int thirdLetter = third;
                            if (thirdLetter == 1) { Console.Write("A"); }
                            else if (thirdLetter == 2) { Console.Write("C"); }
                            else if (thirdLetter == 3) { Console.Write("G"); }
                            else if (thirdLetter == 4) { Console.Write("T"); }

                            Console.Write("X");
                            Console.Write(" ");
                        }
                    }
                    Console.WriteLine();
                }
            }
        }
    }
}