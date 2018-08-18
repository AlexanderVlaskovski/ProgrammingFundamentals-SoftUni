using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03
{
    class Program
    {
        static void Main(string[] args)
        {
            double firstNumber = double.Parse(Console.ReadLine());
            double secondNumber = double.Parse(Console.ReadLine());
            
            if (Math.Abs(firstNumber - secondNumber) <= 0.000001)
            {
                
                Console.WriteLine("True");
            }
            else Console.WriteLine("False");

        }

        
    }
}
