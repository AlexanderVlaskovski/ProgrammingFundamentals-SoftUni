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
            double Miles = double.Parse(Console.ReadLine());

            double Kilometers = Miles * 1.60934;

            Console.WriteLine($"{Kilometers:F2}");
            


        }
    }
}
