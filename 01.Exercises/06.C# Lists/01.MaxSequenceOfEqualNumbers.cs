using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _29EqualSum
{
    class EqualSum
    {
        static void Main()
        {
            int leftSum = 0;
            int rightSum = 0;
            int[] inputArray = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            for (int i = 0; i <inputArray.Length; i++)
            {
                if (i != 0)
                    for (int j = i - 1; j < i && j >= 0; j--)
                    {
                        leftSum += inputArray[j];
                    }
                else leftSum = 0;
                if (i == inputArray.Length - 2)
                {
                    rightSum = inputArray[inputArray.Length - 1];
                }
                else if (i != inputArray.Length - 1)
                    for (int j = i + 1; j < inputArray.Length; j++)
                    {
                        rightSum += inputArray[j];
                    }
                else if (i == inputArray.Length - 1)
                    rightSum = 0;
                if (leftSum == rightSum)
                {
                    Console.WriteLine(i);
                    return;
                }
                else
                {
                    leftSum = 0;
                    rightSum = 0;
                }
            }
            Console.WriteLine("no");
        }
    }
}
