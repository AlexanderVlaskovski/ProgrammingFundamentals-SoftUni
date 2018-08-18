using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04Files
{
    class Program
    {
        static void Main()
        {
            int inputCount = int.Parse(Console.ReadLine());
            int count = 1;
            Dictionary<string, Dictionary<string, long>> files = new Dictionary<string, Dictionary<string, long>>();

            while (count <= inputCount)
            {
                string input = Console.ReadLine();
                string[] tokens = input.Split('\\');
                string root = tokens[0];
                string fileAndSize = "";
                for (int i = 1; i < tokens.Length; i++)
                {
                    if (tokens[i].Contains(";"))
                    {
                        fileAndSize = tokens[i];
                    }
                }
                string[] tokens2 = fileAndSize.Split(';');
                string currentName = tokens2[0];
                long size = long.Parse(tokens2[1]);
                Dictionary<string, long> currentTokens = new Dictionary<string, long>();
                if (files.ContainsKey(root) == false)
                {
                currentTokens.Add(currentName, size);

                    files.Add(root, currentTokens);
                }
                else if (files[root].ContainsKey(currentName))
                {
                    files[root][currentName] = size;
                }
                else
                {
                    files[root].Add(currentName, size);
                }
                count++;
            }

            string[] commands = Console.ReadLine().Split();
            string searchedRoot = commands[2];
            string currentFileName = "."+commands[0];
            bool ifContains = false;
            foreach (var roots in files)
            {
                if (roots.Key == searchedRoot)
                {
                    foreach (var file in files[searchedRoot].OrderByDescending(x=>x.Value).ThenBy(x=>x.Key))
                    {
                        if (file.Key.Contains(currentFileName))
                        {
                            string currentName = file.Key;
                            long currentSize = file.Value;
                            Console.WriteLine($"{currentName} - {currentSize} KB");
                            ifContains = true;
                        }
                    }
                }
            }
            if (!ifContains)
            {
                Console.WriteLine("No");
            }

        }
    }
}
