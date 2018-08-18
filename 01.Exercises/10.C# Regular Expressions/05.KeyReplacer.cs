using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _05KeyReplacer
{
    class Program
    {
        static void Main()
        {
            string pattern = @"([A-zA-Z]+)([\|\\<])(.*)[\|\\<]([A-zA-Z]+)";
            string input = Console.ReadLine();
            Match myMatch = Regex.Match(input, pattern);
            string start = myMatch.Groups[1].Value;
            string end = myMatch.Groups[4].Value;
            string input2 = Console.ReadLine();
            string pattern2 = $@"{start}(.*?){end}";
            StringBuilder builder = new StringBuilder();
            
                MatchCollection results = Regex.Matches(input2, pattern2);
            foreach (Match m in results)
            {
                builder.Append(m.Groups[1].Value);
            }

            if (builder.Length == 0)
            {
                Console.WriteLine("Empty result");
            }
            else
            Console.WriteLine(builder);




        }
    }
}
