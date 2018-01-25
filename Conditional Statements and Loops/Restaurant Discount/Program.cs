using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurant_Discount
{
    class Program
    {
        static void Main(string[] args)
        {
            int groupSize = int.Parse(Console.ReadLine());
            string package = Console.ReadLine();

            double priceHall = 0;
            double pricePackage = 0;
            string hallName = "";
            double discount = 0;

            if (groupSize <= 50 && package == "Normal")
            {
                priceHall = 2500;
                pricePackage = 500;
                hallName = "Small Hall";
                double allPrice = pricePackage + priceHall;
                discount = allPrice * 0.05;
                double pricePerPerson = (allPrice - discount) / groupSize;

                Console.WriteLine("We can offer you the {0}", hallName);
                Console.WriteLine("The price per person is {0:F2}$", pricePerPerson);
            }
            else if (groupSize <= 50 && package == "Gold")
            {
                priceHall = 2500;
                pricePackage = 750;
                hallName = "Small Hall";
                double allPrice = pricePackage + priceHall;
                discount = allPrice * 0.10;
                double pricePerPerson = (allPrice - discount) / groupSize;

                Console.WriteLine("We can offer you the {0}", hallName);
                Console.WriteLine("The price per person is {0:F2}$", pricePerPerson);

            }
            else if (groupSize <= 50 && package == "Platinum")
            {
                priceHall = 2500;
                pricePackage = 1000;
                hallName = "Small Hall";
                double allPrice = pricePackage + priceHall;
                discount = allPrice * 0.15;
                double pricePerPerson = (allPrice - discount) / groupSize;

                Console.WriteLine("We can offer you the {0}", hallName);
                Console.WriteLine("The price per person is {0:F2}$", pricePerPerson);
            }
            else if (groupSize <= 100 && package == "Normal")
            {
                priceHall = 5000;
                pricePackage = 500;
                hallName = "Terrace";
                double allPrice = pricePackage + priceHall;
                discount = allPrice * 0.05;
                double pricePerPerson = (allPrice - discount) / groupSize;

                Console.WriteLine("We can offer you the {0}", hallName);
                Console.WriteLine("The price per person is {0:F2}$", pricePerPerson);
            }
            else if (groupSize <= 100 && package == "Gold")
            {
                priceHall = 5000;
                pricePackage = 750;
                hallName = "Terrace";
                double allPrice = pricePackage + priceHall;
                discount = allPrice * 0.1;
                double pricePerPerson = (allPrice - discount) / groupSize;

                Console.WriteLine("We can offer you the {0}", hallName);
                Console.WriteLine("The price per person is {0:F2}$", pricePerPerson);
            }
            else if (groupSize <= 100 && package == "Platinum")
            {
                priceHall = 5000;
                pricePackage = 1000;
                hallName = "Terrace";
                double allPrice = pricePackage + priceHall;
                discount = allPrice * 0.15;
                double pricePerPerson = (allPrice - discount) / groupSize;

                Console.WriteLine("We can offer you the {0}", hallName);
                Console.WriteLine("The price per person is {0:F2}$", pricePerPerson);
            }
            else if (groupSize <= 120 && package == "Normal")
            {
                priceHall = 7500;
                pricePackage = 500;
                hallName = "Great Hall";
                double allPrice = pricePackage + priceHall;
                discount = allPrice * 0.05;
                double pricePerPerson = (allPrice - discount) / groupSize;

                Console.WriteLine("We can offer you the {0}", hallName);
                Console.WriteLine("The price per person is {0:F2}$", pricePerPerson);
            }
            else if (groupSize <= 120 && package == "Gold")
            {
                priceHall = 7500;
                pricePackage = 750;
                hallName = "Great Hall";
                double allPrice = pricePackage + priceHall;
                discount = allPrice * 0.1;
                double pricePerPerson = (allPrice - discount) / groupSize;

                Console.WriteLine("We can offer you the {0}", hallName);
                Console.WriteLine("The price per person is {0:F2}$", pricePerPerson);
            }
            else if (groupSize <= 120 && package == "Platinum")
            {
                priceHall = 7500;
                pricePackage = 1000;
                hallName = "Great Hall";
                double allPrice = pricePackage + priceHall;
                discount = allPrice * 0.15;
                double pricePerPerson = (allPrice - discount) / groupSize;

                Console.WriteLine("We can offer you the {0}", hallName);
                Console.WriteLine("The price per person is {0:F2}$", pricePerPerson);
            }
            else if (groupSize > 120)
            {
                Console.WriteLine("We do not have an appropriate hall.");
            }
        }
    }
}
