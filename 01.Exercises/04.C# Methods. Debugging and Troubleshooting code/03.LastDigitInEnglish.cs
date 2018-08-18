using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03EnglishNameOfTheLastDigit
{
    class Program
    {
        static void Main(string[] args)
        {
            string inputNumber = Console.ReadLine();
            PrintLastDigit(inputNumber);
        }

        static void PrintLastDigit(string inputNumber)
        {
            if(inputNumber[inputNumber.Length-1] == '0')
                Console.WriteLine("zero");
            else if (inputNumber[inputNumber.Length - 1] == '1')
                Console.WriteLine("one");
            else if (inputNumber[inputNumber.Length-1] == '2')
                Console.WriteLine("two");
            else if (inputNumber[inputNumber.Length-1] == '3')
                Console.WriteLine("three");
            else if (inputNumber[inputNumber.Length-1] == '4')
                Console.WriteLine("four");
            else if (inputNumber[inputNumber.Length-1] == '5')
                Console.WriteLine("five" );
            else if (inputNumber[inputNumber.Length-1] == '6')
                Console.WriteLine("six");
            else if (inputNumber[inputNumber.Length-1] == '7')
                Console.WriteLine("seven");
            else if (inputNumber[inputNumber.Length-1] == '8')
                Console.WriteLine("eight");
          else  if (inputNumber[inputNumber.Length-1] == '9')
                Console.WriteLine("nine");
        }
    }
}
