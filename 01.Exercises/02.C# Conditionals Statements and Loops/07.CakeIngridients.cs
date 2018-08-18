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
            int ingredients = 0;
            for (int i = 0; ; i++)
            {
                string input = Console.ReadLine();
                if (input == "Bake!")
                {
                    break;
                }
                ingredients++;
                Console.WriteLine($"Adding ingredient {input}.");
            }
            Console.WriteLine($"Preparing cake with {ingredients} ingredients.");
        }
    }
}
