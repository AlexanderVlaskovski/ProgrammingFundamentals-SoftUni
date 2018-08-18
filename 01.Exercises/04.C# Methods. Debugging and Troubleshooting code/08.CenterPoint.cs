using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08CenterPoint
{
    class Program
    {
        static void Main(string[] args)
        {
            double x1 = double.Parse(Console.ReadLine());
            double y1 = double.Parse(Console.ReadLine());
            double x2 = double.Parse(Console.ReadLine());
            double y2= double.Parse(Console.ReadLine());

            PrintCloserPoint(x1, y1, x2, y2);

        }
        static void PrintCloserPoint(double x1, double y1, double x2, double y2)
        {
            double firstDiagonal = Math.Sqrt(x1*x1 + y1*y1);
            double secondtDiagonal = Math.Sqrt(x2*x2 + y2* y2);

            if (firstDiagonal < secondtDiagonal)
            {
                Console.WriteLine($"({x1}, {y1})");
            }
            else Console.WriteLine($"({x2}, {y2})");
        }
    }
}
