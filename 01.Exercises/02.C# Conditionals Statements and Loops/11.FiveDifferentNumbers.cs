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

            int firstNumber = int.Parse(Console.ReadLine());
            int secondNumber = int.Parse(Console.ReadLine());

            if (firstNumber + 4 > secondNumber)
            {
                Console.WriteLine("No");
                return;
            }

            for (int i = firstNumber; i <= secondNumber -4; i++)
            {
                for (int k = firstNumber + 1; k <= secondNumber - 3; k++)
                {
                    for (int j = firstNumber + 2; j <= secondNumber - 2; j++)
                    {
                        for (int c = firstNumber + 3; c <= secondNumber - 1; c++)
                        {
                            for (int g = firstNumber + 4; g <= secondNumber; g++)
                            { 
                                if (firstNumber <= i && i < k && k < j && j < c && c < g && g <= secondNumber)
                                Console.WriteLine($"{i} {k} {j} {c} {g}");
                            }
                        }
                    }
                }
            }

        }
    }
}
