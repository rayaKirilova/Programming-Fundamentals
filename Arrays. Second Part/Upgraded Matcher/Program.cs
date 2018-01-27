using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Upgraded_Matcher
{
    class Program
    {
        static void Main(string[] args)
        {
            var products = Console.ReadLine().Split(' ').ToList(); // списък с продукти 
            var quantities = Console.ReadLine().Split(' ').Select(double.Parse).ToList(); // налични количества / масивите не са равни!
            var prices = Console.ReadLine().Split(' ').Select(double.Parse).ToList(); // цена на продуктите

            var command = Console.ReadLine();

            while (command != "done")
            {
                var orderedProductsAndQuantities = command.Split(); // сплитваме масив от команди

                string orderProduct = orderedProductsAndQuantities[0]; // получаваме името на поръчания продукт
                double quantityOfOrderProduct = double.Parse(orderedProductsAndQuantities[1]); // количество от желания продукт

                int index = products.IndexOf(orderProduct); // индекс на продукта от списъка с наличните 

                double goodsStock =
                    index < quantities.Count ?
                    quantities[index] :
                    0;

                if (goodsStock >= quantityOfOrderProduct)
                {
                    double allPrice = quantityOfOrderProduct * prices[index];

                    Console.WriteLine(
                    $"{products[index]} x {quantityOfOrderProduct} costs {allPrice:F2} ");

                    quantities[index] -= quantityOfOrderProduct;
                }
                else
                {
                    Console.WriteLine($"We do not have enough {orderProduct}");
                }
                command = Console.ReadLine();

            }
        }
    }
}
  
