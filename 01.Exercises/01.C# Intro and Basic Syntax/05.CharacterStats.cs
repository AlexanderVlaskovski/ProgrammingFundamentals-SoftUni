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
            string CharacterName = Console.ReadLine();

            int CurrentHealth = int.Parse(Console.ReadLine());
            int MaximumHealth = int.Parse(Console.ReadLine());
            int CurrentEnergy = int.Parse(Console.ReadLine());
            int MaximumEnergy = int.Parse(Console.ReadLine());

            Console.WriteLine($"Name: {CharacterName}");
            Console.Write($"Health: ");
            Console.Write(new string('|', CurrentHealth + 1));
            Console.Write(new string('.', MaximumHealth - CurrentHealth));
            Console.WriteLine( new string ('|', 1));

            Console.Write($"Energy: ");
            Console.Write(new string('|', CurrentEnergy + 1));
            Console.Write(new string('.', MaximumEnergy - CurrentEnergy));
            Console.Write(new string('|', 1));
        }
    }
}
