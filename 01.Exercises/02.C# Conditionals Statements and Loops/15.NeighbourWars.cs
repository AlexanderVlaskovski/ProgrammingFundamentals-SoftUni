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
            int peshoDamage = int.Parse(Console.ReadLine());
            int goshoDamage = int.Parse(Console.ReadLine());


            int goshoHealth = 100;
            int peshoHealth = 100;
            bool winner = true;
            int roundCount = 0;

            for (int i = 1; ; i++)
            {
                roundCount++;
                if (i % 2 == 1)
                {
                    goshoHealth -= peshoDamage;

                }
               else peshoHealth -= goshoDamage;
                
                
                    if (goshoHealth<=0)
                {
                    winner = false;
                    break;
                }
                if (peshoHealth <= 0)
                {
                    break;
                }
                
                if (i % 2 == 1)
                {
                    
                    Console.WriteLine($"Pesho used Roundhouse kick and reduced Gosho to {goshoHealth} health.");
                }
                else Console.WriteLine($"Gosho used Thunderous fist and reduced Pesho to {peshoHealth} health.");
                if (i % 3 == 0)
                {
                    goshoHealth += 10;
                    peshoHealth += 10;
                }

            }
       if (winner)
            {
                Console.WriteLine($"Gosho won in {roundCount}th round.");
            }
            else Console.WriteLine($"Pesho won in {roundCount}th round.");
        }
    }
}
