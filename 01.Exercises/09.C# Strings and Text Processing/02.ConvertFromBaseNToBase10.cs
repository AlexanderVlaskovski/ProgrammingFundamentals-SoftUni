using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace StringExercises
{
    class Program
    {
        static void Main()
        {
            string[] input = Console.ReadLine().Split();
            int n = int.Parse(input[0]);

            StringBuilder convert = new StringBuilder();
            int count = 0;
            BigInteger sum = 0;

            for (int i = input[1].Length-1; i >= 0; i--)
            {
                
                BigInteger currentNumber = BigInteger.Parse(input[1][i].ToString());
                sum += currentNumber*(BigInteger)Math.Pow(n, count);
                count++;
                
            }
            Console.WriteLine(sum);

        }
    }
}
