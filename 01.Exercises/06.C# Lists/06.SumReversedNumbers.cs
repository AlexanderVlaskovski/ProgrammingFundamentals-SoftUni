using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06ReversedSum
{
    class Program
    {
        static void Main()
        {
            
            List<string> inputList = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).ToList();
            int result = 0;

            for (int i = 0; i < inputList.Count; i++)
            {
                string currentNumber = inputList[i];
                string reversedNumber = "";
                for (int j = currentNumber.Length - 1; j >= 0; j--)
                {
                    reversedNumber += currentNumber[j];
                }
                result += int.Parse(reversedNumber);
            }
            
            
            Console.WriteLine(result);
        }
      
    }
}


