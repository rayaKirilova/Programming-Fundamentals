using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Phonebook
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, string> phonebook = new Dictionary<string, string>();

            string text = Console.ReadLine();

            while (text != "END")
            {
                string[] data = text.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

                if (data[0] == "A")
                {
                    string key = data[1];
                    string value = data[2];
                    phonebook[key] = value;

                }
                else if (data[0] == "S")
                {
                    string key = data[1];

                    if (phonebook.ContainsKey(key))
                    {
                        Console.WriteLine($"{key} -> {phonebook[key]}");
                    }
                    else
                    {
                        Console.WriteLine($"Contact {key} does not exist.");
                    }
                }
                text = Console.ReadLine();
            }
        }
    }
}
