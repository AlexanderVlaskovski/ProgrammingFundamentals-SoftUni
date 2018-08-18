using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _06ValidUsername
{
    class Program
    {
        static void Main()
        {
            string[] input = Console.ReadLine().Split(new char[] { '(', ')', ' ', '\\', '/' },StringSplitOptions.RemoveEmptyEntries).ToArray();
            string pattern = @"(^[A-Za-z][\w]{2,24})";
            List<string> result = new List<string>();

            foreach (var member in input)
            {
                if(Regex.IsMatch(member, pattern) && member.Length>=3 && member.Length<=25)
                {
                    result.Add(member);
                }
            }
            int max = int.MinValue;
            int currentSum = 0;
            string max1 = "";
            string max2 = "";

            for (int i = 0; i < result.Count-1; i++)
            {
                currentSum = result[i].Length + result[i + 1].Length;
                if (max<currentSum)
                {
                    max = currentSum;
                    max1 = result[i];
                    max2 = result[i+1];
                }


            }
            Console.WriteLine(max1);
            Console.WriteLine(max2);


        }
    }
}
