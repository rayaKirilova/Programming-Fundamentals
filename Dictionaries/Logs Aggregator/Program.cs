using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logs_Aggregator
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            SortedDictionary<string, SortedDictionary<string, int>> userLogs =
                new SortedDictionary<string, SortedDictionary<string, int>>();

            for (int i = 0; i < n; i++)
            {
                string[] data = Console.ReadLine().Split(' ');

                string ip = data[0];
                string name = data[1];
                var duration = int.Parse(data[2]);

                if (!userLogs.ContainsKey(name))
                {
                    userLogs[name] = new SortedDictionary<string, int>();

                }
                if (!userLogs[name].ContainsKey(ip))
                {
                    userLogs[name][ip] = 0;
                }

                userLogs[name][ip] += duration;
            }

            foreach (var user in userLogs)
            {
                Console.Write($"{user.Key}: {user.Value.Values.Sum()}");

                string toPrint = " [";

                foreach (var item in user.Value)
                {
                    string currIp = item.Key;
                    toPrint += currIp + ", ";
                }

                toPrint = toPrint.Substring(0, toPrint.Length - 2);
                toPrint += "]";
                Console.WriteLine(toPrint);
            }
        }
    }
}