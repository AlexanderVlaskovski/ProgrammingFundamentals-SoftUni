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
            char firstLetter = char.Parse(Console.ReadLine());
            char secondLetter = char.Parse(Console.ReadLine());
            char magicLetter = char.Parse(Console.ReadLine());

            for (int i = (int)firstLetter; i <= (int)secondLetter; i++)
            {
                for (int j = (int)firstLetter; j <= secondLetter; j++)
                {
                    for (int c = (int)firstLetter; c <= secondLetter; c++)
                    {
                        if (i == (int)magicLetter || j == (int)magicLetter || c == (int)magicLetter)
                        {
                            continue;
                        }
                        else Console.Write($"{(char)i}{(char)j}{(char)c} ");
                    }
                }
            }
        }
    }
}
