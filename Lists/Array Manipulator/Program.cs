using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array_Manipulator
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToList();

            string commands = Console.ReadLine();

            while (commands != "print")
            {
                var commandArgs = commands.Split(' ').ToList();

                if (commandArgs[0] == "add")
                {
                    numbers.Insert(int.Parse(commandArgs[1]), int.Parse(commandArgs[2]));
                }
                else if (commandArgs[0] == "addMany")
                {
                    numbers.InsertRange(int.Parse(commandArgs[1]), commandArgs.Skip(2).Select(int.Parse).ToList());
                }
                else if (commandArgs[0] == "contains")
                {
                    if (numbers.Contains(int.Parse(commandArgs[1])))
                    {
                        Console.WriteLine(numbers.IndexOf(int.Parse(commandArgs[1])));
                        // методът IndexOf връща -1, когато не намери търсеният индекс
                    }
                    else
                    {
                        Console.WriteLine(-1);
                    }
                }
                else if (commandArgs[0] == "remove")
                {
                    numbers.RemoveAt(int.Parse(commandArgs[1]));
                }
                else if (commandArgs[0] == "shift")
                {
                    int number = int.Parse(commandArgs[1]);
                    number = number % numbers.Count;
                    var remainder = numbers.Take(number).ToList();
                    numbers.RemoveRange(0, number);
                    numbers.AddRange(remainder);
                }
                else if (commandArgs[0] == "sumPairs")
                {
                    for (int i = 0; i < numbers.Count - 1; i++)
                    {
                        var sum = numbers[i] + numbers[i + 1];
                        numbers[i] = sum;
                        numbers.RemoveAt(i + 1);
                    }
                }
                commands = Console.ReadLine();
            }

            Console.WriteLine("[" + string.Join(", ", numbers) + "]");
        }
    }
}
