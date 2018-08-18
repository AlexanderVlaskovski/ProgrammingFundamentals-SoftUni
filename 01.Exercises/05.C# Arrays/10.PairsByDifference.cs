using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _28PairsByDifference
{
    class Program
    {
        static void Main()
        {
            int[] inputArray = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int difference = int.Parse(Console.ReadLine());
            int counter = 0;

            for (int i = 0; i < inputArray.Length-1; i++)
            {
                for (int j = i+1; j < inputArray.Length; j++)
                {
                    if(Math.Abs(inputArray[i]-inputArray[j]) == difference)
                    {
                        counter++;
                    }
                    
                }
            }
            Console.WriteLine(counter);
        }
    }
}
