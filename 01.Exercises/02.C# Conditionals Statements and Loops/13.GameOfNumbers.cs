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

            int combinations = 0;
            int currentA = 0;
            int currentB = 0;
            for (int i = A; i <= B; i++)
            {
                for (int j = A; j <=B ; j++)
                {
                    combinations++;
                    if (i + j == C)
                    {
                        currentA = i;
                        currentB = j;
                    }

                }
            }
            if (currentA == 0)
            {
                Console.WriteLine($"{combinations} combinations - neither equals {C}");
            }
            else Console.WriteLine($"Number found! {currentA} + {currentB} = {C}");

        }
    }
}
