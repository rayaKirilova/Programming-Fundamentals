using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fix_Emails
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, string> emailsList = new Dictionary<string, string>();

            while (true)
            {
                string input = Console.ReadLine();

                if (input == "stop")
                {
                    break;
                }

                string email = Console.ReadLine();

                if (email.Contains(".uk") || email.Contains(".us"))
                {
                }
                else
                {
                    emailsList.Add(input, email);
                }
            }

            foreach (var person in emailsList)
            {
                Console.WriteLine("{0} -> {1}", person.Key, person.Value);
            }
        }
    }
}
   