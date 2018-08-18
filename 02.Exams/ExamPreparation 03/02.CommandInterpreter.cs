using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02CommandInterpeter
{
    class Program
    {
        static void Main()
        {
            List<string> inputData = Console.ReadLine().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).ToList();

            string input;

            while ((input = Console.ReadLine()) != "end")
            {
                string[] tokens = input.Split();
                if (tokens.Length == 5)
                {
                    int startIndex = int.Parse(tokens[2]);
                    int count = int.Parse(tokens[4]);
                    if (startIndex > inputData.Count - 1 || count < 0 || startIndex+count > inputData.Count  || startIndex< 0)
                    {
                        Console.WriteLine("Invalid input parameters.");
                        continue;
                    }

                    string command = tokens[0];
                    if (command == "reverse")
                    {
                        List<string> currentList = inputData.Skip(startIndex).Take(count).Reverse().ToList();
                        inputData.RemoveRange(startIndex, count);
                        inputData.InsertRange(startIndex, currentList);
                    }
                    else if (command == "sort")
                    {
                        List<string> currentList = inputData.Skip(startIndex).Take(count).ToList();
                        currentList.Sort();
                        inputData.RemoveRange(startIndex, count);
                        inputData.InsertRange(startIndex, currentList);
                    }
                }
                else
                {
                    string command = tokens[0];
                    long count = long.Parse(tokens[1]);
                    if(count < 0)
                    {
                        Console.WriteLine("Invalid input parameters.");
                        continue;
                    }
                    count %= inputData.Count;

                    if (command == "rollLeft")
                    {
                        for (int i = 0; i < count; i++)
                        {
                            inputData.Add(inputData[0]);
                            inputData.RemoveAt(0);
                        }

                    }
                    else if(command == "rollRight")
                    {
                        for (int i = 0; i < count; i++)
                        {
                            inputData.Insert(0, inputData[inputData.Count - 1]);
                            inputData.RemoveAt(inputData.Count-1);
                        }

                    }
                }

            }
            Console.WriteLine($"[{string.Join(", ", inputData)}]");

        }
    }
}
