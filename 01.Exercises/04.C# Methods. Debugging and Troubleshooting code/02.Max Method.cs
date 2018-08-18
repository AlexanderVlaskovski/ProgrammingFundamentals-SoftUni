using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methods0102
{
    class Program
    {
        static void Main()
        {
            int firstNumber = int.Parse(Console.ReadLine());
            int secondNumber = int.Parse(Console.ReadLine());
            int thirdNumber = int.Parse(Console.ReadLine());

           
            int maxNumber = GetMaxNumber(firstNumber, secondNumber, thirdNumber);
            Console.WriteLine(maxNumber);
        }

        static int GetMaxNumber(int firstNumber, int secondNumber, int thirdNumber)
        {
           
            int currentMax = Math.Max(firstNumber, secondNumber);
            currentMax = Math.Max(currentMax, thirdNumber);
            return currentMax;
                
        }
    }
}
