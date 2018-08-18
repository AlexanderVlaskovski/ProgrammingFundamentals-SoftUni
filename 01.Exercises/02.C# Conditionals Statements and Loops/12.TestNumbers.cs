using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataTypesVariables
{
    class Program
    {
        static void Main(string[] args)
        {
                      int A = int.Parse(Console.ReadLine());
                    int B = int.Parse(Console.ReadLine());
                  int C = int.Parse(Console.ReadLine());

            int sum = 0;
            int specialOperations = 0;
            int combinations = 0;

            for (int i = A; i >= 1; i--)
            {
                for (int j = 1; j <= B; j++)
                {
                    combinations++;
                    specialOperations = (i * j) * 3;
                    sum += specialOperations;
                    if (sum >= C)
                    {
                        Console.WriteLine($"{combinations} combinations");
                        Console.WriteLine($"Sum: {sum} >= {C}");
                        return;
                    }
                }
            }
            Console.WriteLine($"{combinations} combinations");
            Console.WriteLine($"Sum: {sum}");




        }
    }
}
