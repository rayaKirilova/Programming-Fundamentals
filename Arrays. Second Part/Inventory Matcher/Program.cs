using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inventory_Matcher
{
    class Program
    {
        static void Main(string[] args)
        {
            var products = Console.ReadLine()
                .Split(' ')
                .ToList();
            var quantities = Console.ReadLine()
                .Split(' ')
                .Select(long.Parse)
                .ToList();
            var prices = Console.ReadLine()
                .Split(' ')
                .Select(decimal.Parse)
                .ToList();
            var command = Console.ReadLine();

            while (command != "done")
            {
                int index = products.IndexOf(command);
                Console.WriteLine(
                    $"{products[index]} costs: {prices[index]}; Available quantity: {quantities[index]}"
                    );
                command = Console.ReadLine();
            }
        }
    }
}
