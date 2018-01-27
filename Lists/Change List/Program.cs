using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Change_List
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToList();

            List<string> commandLine = Console.ReadLine()
                .Split(' ').ToList();

            while (commandLine[0] != "Odd" && commandLine[0] != "Even")
            {
                if (commandLine[0] == "Delete")
                {
                    int number = int.Parse(commandLine[1]);
                    numbers.RemoveAll(i => i == number);
                }
                else if (commandLine[0] == "Insert")
                {
                    int element = int.Parse(commandLine[1]);
                    int position = int.Parse(commandLine[2]);
                    numbers.Insert(position, element);
                }

                commandLine = Console.ReadLine()
                .Split(' ').ToList();
            }

            if (commandLine[0] == "Odd")
            {
                foreach (var odd in numbers)
                {
                    if (odd % 2 == 1)
                    {
                        Console.Write($"{odd} ");
                    }
                }
            }
            else
            {
                foreach (var even in numbers)
                {
                    if (even % 2 == 0)
                    {
                        Console.Write($"{even} ");
                    }
                }
            }
        }
    }
}
