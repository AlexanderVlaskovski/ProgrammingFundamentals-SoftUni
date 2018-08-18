using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _03AnonymousVox
{
    class Program
    {
        static void Main()
        {
            string pattern = @"((?!_|\^|')[A-aZ-z]+)(.+)(\1)(?<!_|\^|')";
            string input = Console.ReadLine();
            string[] values = Console.ReadLine().Split(new char[] { '{', '}' }, StringSplitOptions.RemoveEmptyEntries);

            MatchCollection myMatches = Regex.Matches(input, pattern);
            int counter = 0;
            foreach (Match match in myMatches)
            {
                string placeholder = match.Groups[2].Value;
                if (counter < values.Length)
                {
                    int index = input.IndexOf(placeholder);
                    input = input.Remove(index, placeholder.Length);
                    input = input.Insert(index, values[counter]);
                    counter++;
                }
                else
                {
                    break;
                }
            }
            Console.WriteLine(input);
        }
    }
}
