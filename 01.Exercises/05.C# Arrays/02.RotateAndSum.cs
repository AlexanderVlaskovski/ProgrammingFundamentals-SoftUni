using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _19RotateAndSum
{
    class Program
    {
        static void Main()
        {
            int[] inputArray = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int[] sumArray = new int[inputArray.Length];
            int[] rotatedArray = new int[inputArray.Length];
            int[] tempArray = new int[inputArray.Length -1];
            
            int rotations = int.Parse(Console.ReadLine());

            for (int r = 0; r < rotations; r++)
            {
                for (int i = 0; i < tempArray.Length; i++)
                {
                    tempArray[i] = inputArray[i];
                }
                rotatedArray[0] = inputArray[inputArray.Length - 1];

                for (int i = 0; i < tempArray.Length; i++)
                {
                    rotatedArray[i + 1] = tempArray[i];
                }

                inputArray = rotatedArray;

                for (int i = 0; i < inputArray.Length; i++)
                {
                    sumArray[i] += rotatedArray[i];
                }
                
            }
            Console.WriteLine(string.Join(" ", sumArray));

        }
    }
}
