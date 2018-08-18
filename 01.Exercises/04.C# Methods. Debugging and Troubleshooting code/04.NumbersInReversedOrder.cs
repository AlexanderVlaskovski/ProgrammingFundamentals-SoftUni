using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversedNumberOrder
{
    class Program
    {
        static void Main(string[] args)
        {
            string toReverse = Console.ReadLine();

            
            string reversedString = ReverseString(toReverse);
            Console.WriteLine(reversedString);
        }

       static string ReverseString(string toReverse)
        {
            char[] arr = toReverse.ToCharArray();
            Array.Reverse(arr);
            return new string(arr);
        }
    }
}
