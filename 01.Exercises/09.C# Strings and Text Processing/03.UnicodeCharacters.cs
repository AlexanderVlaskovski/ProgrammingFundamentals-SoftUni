using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03UnicodeCharacters
{
    class Program
    {
        static void Main()
        {
            string input = Console.ReadLine();

            foreach (var symbol in input)
            {
                Console.Write("\\u{0:x4}", (int)symbol);

            }
            Console.WriteLine();
        }
    }
}
