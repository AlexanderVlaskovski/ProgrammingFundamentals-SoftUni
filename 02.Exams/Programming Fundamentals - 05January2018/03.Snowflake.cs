using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _03SnowFlake
{
    class Program
    {
        static void Main()
        {
            Regex surface = new Regex(@"^[^A-Za-z0-9]+$");
            Regex mantle = new Regex(@"^[0-9+_]+$");
            Regex middle = new Regex(@"^[^A-Za-z0-9]+[0-9_]+([A-Za-z]+)[0-9_]+[^A-Za-z0-9]+$");
             int length = 0;
            for (int i = 0; i < 5; i++)
            {
                string line = Console.ReadLine();
                if (i == 0 || i == 4)
                {
                    Validate(surface, line);
                }
                else if (i == 1 || i == 3)
                {
                    Validate(mantle, line);
                }
                else
                {
                    Validate(middle, line);

                    Match match = middle.Match(line);
                    length = match.Groups[1].Value.Length;
                }

                
            }

            Console.WriteLine("Valid");
            Console.WriteLine($"{length}");

        }

        private static void Validate(Regex pattern, string line)
        {
            if (Regex.IsMatch(line, pattern.ToString()) == false)
            {
                Console.WriteLine("Invalid");
                Environment.Exit(0);
            }

        }
    }
}
