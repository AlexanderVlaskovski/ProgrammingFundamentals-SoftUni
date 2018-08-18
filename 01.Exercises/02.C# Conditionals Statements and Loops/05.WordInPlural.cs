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
            string inputWord = Console.ReadLine();

            if (inputWord[inputWord.Length - 1] == 'y')
            {
                inputWord = inputWord.Remove(inputWord.Length - 1);
                inputWord = inputWord + "ies";
            }
            else if (inputWord[inputWord.Length - 1] == 'o' || inputWord[inputWord.Length - 1] == 's' || inputWord[inputWord.Length - 1] == 'x' || inputWord[inputWord.Length - 1] == 'z')
            {
               
                inputWord = inputWord + "es";
            }
            else if (inputWord[inputWord.Length - 2] == 'c' && inputWord[inputWord.Length - 1] == 'h')
            {
            
                inputWord = inputWord + "es";
            }
            else if (inputWord[inputWord.Length - 2] == 's' && inputWord[inputWord.Length - 1] == 'h')
            {

                inputWord = inputWord + "es";
            }
            else inputWord = inputWord + 's';
            Console.WriteLine(inputWord);
        }
    }
}
