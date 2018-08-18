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
            string Beverage = Console.ReadLine();

            double Volume = double.Parse(Console.ReadLine());
            double EnergyContent = double.Parse(Console.ReadLine());
            double SugarContent = double.Parse(Console.ReadLine());

            double EnergyContentPer100Ml = EnergyContent * Volume / 100;
            double SugarContent100Ml = SugarContent * Volume / 100;

            Console.WriteLine($"{Volume}ml {Beverage}:");
            Console.WriteLine($"{EnergyContentPer100Ml}kcal, {SugarContent100Ml}g sugars");  




        }
    }
}
