using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01
{
    class Program
    {
        static void Main(string[] args)
        {
            string Proffesion = Console.ReadLine();
            int Quantity = int.Parse(Console.ReadLine());
            double Price = 0;
            if (Proffesion == "Athlete")
            {
               
                Price = Quantity * 0.70;
            }
            else if (Proffesion == "Businessman" || Proffesion == "Businesswoman")
            {
                
                Price = Quantity * 1.00;
            }
            else if (Proffesion == "SoftUni Student")
            {
                
                Price = Quantity * 1.70;
            }

            else
            {
                
                Price = Quantity * 1.20;
            }

            Console.WriteLine($"The {Proffesion} has to pay {Price:f02}.");
        }
    }
}
