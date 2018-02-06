using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Text_filter
{
    class Program
    {
        static void Main(string[] args)
        {
            var badWords = Console.ReadLine().Split(',', ' ')
                .Where(w => w.Length > 0).ToArray();

            var text = Console.ReadLine();

            foreach (var banWord in badWords)
            {
                if (text.Contains(banWord))
                {
                    text = text.Replace(banWord,
                      new string('*', banWord.Length));
                }
            }

            Console.WriteLine(text);
        }
    }
}
