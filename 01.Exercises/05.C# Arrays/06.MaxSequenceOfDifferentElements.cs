using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _23LonegstEqualSequence
{
    class Program
    {
        static void Main()
        {
            int[] inputArray = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int len = 1;
            int start = inputArray[0];
            int bestLength = 0;
            int bestStart = inputArray[0];

            for (int i = 1; i < inputArray.Length; i++)
            {
               
                if (start == inputArray[i])
                {
                    len++;
                    if (len > bestLength)
                    {
                        bestLength = len;
                        bestStart = start;
                    }
                }
                else
                {
                    
                    len = 1;
                }
                start = inputArray[i];

            }
            for (int i = 0; i < Math.Max(len, bestLength); i++)
            {
                Console.Write(bestStart + " ");
            }
            Console.WriteLine();
        }
    }
}