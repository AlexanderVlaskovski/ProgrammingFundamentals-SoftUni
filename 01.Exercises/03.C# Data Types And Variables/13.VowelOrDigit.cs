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
            char A = char.Parse(Console.ReadLine());

            for (char i = '0'; i <= '9'; i++)
            {
                if (A == i)
                {
                    Console.WriteLine("digit");
                    return;

                }
            }
            if (A == 'a' || A == 'o' || A == 'u' || A == 'e' || A == 'i')
                Console.WriteLine("vowel");
            else Console.WriteLine("other");

        }
    }
}
