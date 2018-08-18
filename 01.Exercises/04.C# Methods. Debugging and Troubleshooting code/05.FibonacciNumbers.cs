using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05FibonacciNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            PrintNFibonacci(n);
        }

        private static void PrintNFibonacci(int n)
        {
            if (n== 0 || n== 1)
            {
                Console.WriteLine(1);
                return;
            }
            long firstFibonacci = 1;
            long secondFibonacci = 1;
            long currentFibonacci = 0;
            

            for (int i = 2; i <= n; i++)
            {
                currentFibonacci = firstFibonacci + secondFibonacci;
                long newSecondFibonacci = secondFibonacci;
                secondFibonacci = currentFibonacci;
                firstFibonacci = currentFibonacci - firstFibonacci;
                

            }
            Console.WriteLine(currentFibonacci);
        }
    }
}
