using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Manipulate_Array
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> words = Console.ReadLine()
               .Split()
               .ToList();

            int numberOfCommands = int.Parse(Console.ReadLine());

            for (int i = 0; i < numberOfCommands; i++)
            {
                List<string> commands = Console.ReadLine().Split(' ').ToList();

                if (commands[0] == "Reverse")
                {
                    words.Reverse();
                    continue;
                }
                if (commands[0] == "Distinct")
                {

                    words = words.Distinct().ToList();
                    continue;
                }
                if (commands[0] == "Replace")
                {
                    int index = int.Parse(commands[1]);
                    string forReplace = commands[2];

                    words[index] = forReplace;
                }
            }

            Console.WriteLine(string.Join(", ", words));
        }
    }
}

