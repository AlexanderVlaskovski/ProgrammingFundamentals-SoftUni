using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _24MaxSequenceOfIncreasingNumbers
{
    class Program
    {
        static void Main()
        {
            long[] inputArray = Console.ReadLine().Split(' ').Select(long.Parse).ToArray();
            int len = 1;
          
            long current = inputArray[0];
            long bestLength = 0;
            long bestStart = inputArray[0];

            for (int i = 1; i < inputArray.Length; i++)
            {

                if (inputArray[i] - current >= 1)
                {
                    len++;
                    if (len > bestLength)
                    {
                        bestLength = len;
                        bestStart = i - (len - 1);
                    }
                }
                else
                {

                    len = 1;
                }
                current = inputArray[i];

            }
            for (long i = bestStart; i < bestLength+bestStart; i++)
            {
                Console.Write(inputArray[i] + " ");
            }
            Console.WriteLine();

        }
    }
}
