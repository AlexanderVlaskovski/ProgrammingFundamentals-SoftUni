using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace ExamPrep3
{
    class Program
    {
        static void Main()
        {
            int ordersCount = int.Parse(Console.ReadLine());
            int counter = 1;
            decimal totalPrice = 0M;
            while (counter <= ordersCount)
            {
                decimal pricePerCapsule = decimal.Parse(Console.ReadLine());
                string date = Console.ReadLine();
                string[] tokens = date.Split('/');
                int year = int.Parse(tokens[2]);
                int month = int.Parse(tokens[1]);
                int days = DateTime.DaysInMonth(year, month);
                int capsulesCount = int.Parse(Console.ReadLine());
                decimal price = days * pricePerCapsule * capsulesCount;
                totalPrice += price;
                Console.WriteLine($"The price for the coffee is: ${price:f2}");
                counter++;
            }
            Console.WriteLine($"Total: ${totalPrice:f2}");
        }
    }
}
