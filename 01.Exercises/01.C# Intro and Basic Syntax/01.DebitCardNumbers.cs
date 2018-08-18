using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            int First = int.Parse(Console.ReadLine());
            int Second = int.Parse(Console.ReadLine());
            int Third = int.Parse(Console.ReadLine());
            int Fourth = int.Parse(Console.ReadLine());

            Console.WriteLine($"{First:D4} {Second:D4} {Third:D4} {Fourth:D4}");

        }
    }
}
