using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Heists
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] prices = Console.ReadLine().Split().Select(int.Parse).ToArray();
            long priceJewels = prices[0];
            long priceGold = prices[1];

            string commands = Console.ReadLine();

            long moneyEarned = 0;
            long moneyExpenses = 0;


            while (commands != "Jail Time")
            {
                List<string> commandsArgs = commands.Split(' ').ToList();

                long expenses = long.Parse(commandsArgs[1]);

                long jewelQuantity = commandsArgs[0].Where(x => x == '%').Count();
                long goldQuantity = commandsArgs[0].Where(x => x == '$').Count();

                moneyEarned += priceJewels * jewelQuantity + priceGold * goldQuantity;

                commands = Console.ReadLine();

                moneyExpenses += expenses;
            }

            if (moneyEarned >= moneyExpenses)
            {
                Console.WriteLine($"Heists will continue. Total earnings: {moneyEarned - moneyExpenses}.");
            }
            else
            {
                Console.WriteLine($"Have to find another job. Lost: {moneyExpenses - moneyEarned}.");
            }
        }
    }
}
    