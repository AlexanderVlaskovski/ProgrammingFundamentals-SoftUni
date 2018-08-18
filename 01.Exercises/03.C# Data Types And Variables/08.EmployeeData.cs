using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04
{
    class Program
    {
        static void Main(string[] args)
        {
            string firstName = Console.ReadLine();  
            string lastName = Console.ReadLine();
            string Age = Console.ReadLine();
            char Gender = char.Parse(Console.ReadLine());
            string personalID = Console.ReadLine();
            string uniqueNumber = Console.ReadLine();
            Console.WriteLine($"First name: {firstName}");
            Console.WriteLine($"Last name: {lastName}");
            Console.WriteLine($"Age: {Age}");
            Console.WriteLine($"Gender: {Gender}");
            Console.WriteLine($"Personal ID: {personalID}");
            Console.WriteLine($"Unique Employee number: {uniqueNumber}");


        }
    }
}
