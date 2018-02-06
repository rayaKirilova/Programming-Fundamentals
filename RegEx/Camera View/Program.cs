using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions; 

namespace Camera_View
{
    class Program
    {
        static void Main(string[] args)
        {
            var elements = Console.ReadLine()
            .Split()
            .Select(int.Parse)
            .ToArray();

            var m = elements[0]; //m is the elements, which have to skip
            var n = elements[1]; //n is the elements, which have to take

            var input = Console.ReadLine();

            var cameraPattern = @"[|<]{2}\w+"; // @"\|\<\w+"   @"\|{1}\<{1}\w+"
            var matches = Regex.Matches(input, cameraPattern);

            var takenViews = new List<string>();

            foreach (Match match in matches)
            {
                var currentView = new String(match.Value
                    .Skip(2)
                    .Skip(m)
                    .Take(n)
                    .ToArray());

                takenViews.Add(currentView);
            }

            Console.WriteLine(string.Join(", ", takenViews));
        }
    }
}
