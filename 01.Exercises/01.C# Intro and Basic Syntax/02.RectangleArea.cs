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
            double width = double.Parse(Console.ReadLine());
            double heigth = double.Parse(Console.ReadLine());

            double AreaOfTheRectangle = width * heigth;

            Console.WriteLine($"{AreaOfTheRectangle:f2}");

            


        }
    }
}
