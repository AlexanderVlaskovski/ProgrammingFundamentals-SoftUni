using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20RotateAndSum
{
    class Program
    {
        static void Main()
        {
            
            int[] array = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            

            int[] firstRow = new int[array.Length/2];
            int[] secondRow = new int[array.Length / 2];
            int[] sumArray = new int[array.Length / 2];
            int k = array.Length / 4 - 1;
            for (int i = 0; i < array.Length/4; i++)
            {
                
                firstRow[i] = array[k];
                k--;
            }
            int last = array.Length - firstRow.Length/2;
            for (int i = firstRow.Length-1; i >= array.Length/4; i--)
            {
                
                firstRow[i] = array[last];
                last++;
            }
            for (int i = 0; i < secondRow.Length; i++)
            {
                secondRow[i] = array[array.Length / 4 + i];
            }
            for (int i = 0; i < sumArray.Length; i++)
            {
                sumArray[i] = firstRow[i] + secondRow[i];
            }
            Console.WriteLine(string.Join(" ",sumArray));
            

        }
    }
}
