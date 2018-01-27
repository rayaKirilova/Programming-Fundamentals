using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fibonacci_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {

            int n = int.Parse(Console.ReadLine());
            int fibNumber = Fibonacci(n);

            Console.WriteLine(fibNumber);
        }

        private static int Fibonacci(int n)
        {
            int fibNumber = 1;
            int fib1 = 0;
            int fib2 = 1;

            for (int i = 0; i < n; i++)
            {
                fibNumber = fib1 + fib2;
                fib1 = fib2;
                fib2 = fibNumber;
            }
            return fibNumber;
        }
    }
}
    