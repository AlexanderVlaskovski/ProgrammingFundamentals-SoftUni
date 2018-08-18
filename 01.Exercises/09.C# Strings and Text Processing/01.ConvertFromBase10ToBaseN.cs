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

            BigInteger number  = BigInteger.Parse(input[1]);
            StringBuilder convert = new StringBuilder();
            BigInteger rem = 0;


            while (number > 0)
            {
                rem = number % n;
                convert.Insert(0, rem);
                number /= n;
            }
            Console.WriteLine(convert);

        }
    }
}
