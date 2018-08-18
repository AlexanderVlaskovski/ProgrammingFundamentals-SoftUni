using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _02ExtractSentences
{
    class Program
    {
        static void Main()
        {
            string word = Console.ReadLine();
            string input = Console.ReadLine();
            string pattern = $@"\b{word}\b";
            string[] sentences = input.Split(new char[] { '.', '!', '?' }, StringSplitOptions.RemoveEmptyEntries).ToArray();

            foreach (var sentence in sentences)
            {
                if (Regex.IsMatch(sentence, pattern))
                {
                    Console.WriteLine(sentence.Trim());
                }

            }      
        }
    }
}
