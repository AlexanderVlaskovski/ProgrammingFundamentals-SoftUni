using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
          

            for (int i = 2; i <= n; i++)
            {
                bool isPrime = true;
                for (int j = 2; j <= Math.Sqrt(i); j++)
                {


                    if (i % j == 0)
                    {
                        isPrime = false;
                        break;
                    }
                   
                }
                Console.WriteLine($"{i} -> {isPrime}");

            }

        }
    }
}
