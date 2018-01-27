using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Safe_Manipulation
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> words = Console.ReadLine()
           .Split()
           .ToList();

            List<string> commands = Console.ReadLine().Split(' ').ToList();

            while (commands[0] != "END")
            {

                if (commands[0] == "Reverse")
                {
                    words.Reverse();
                }
                else if (commands[0] == "Distinct")
                {
                    words = words.Distinct().ToList();
                }
                else if (commands[0] == "Replace")
                {
                    int index = int.Parse(commands[1]);
                    string forReplace = commands[2];

                    if (index >= 0 && index < words.Count)
                    {
                        words[index] = forReplace;
                    }
                    else
                    {
                        Console.WriteLine("Invalid input!");
                    }
                }
                else
                {
                    Console.WriteLine("Invalid input!");
                }
                commands = Console.ReadLine().Split(' ').ToList();
            }
            Console.WriteLine(string.Join(", ", words));
        }
    }
}
    