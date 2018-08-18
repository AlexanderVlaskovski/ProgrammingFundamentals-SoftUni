using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02AnonymousThread
{
    class Program
    {
        static void Main()
        {
            List<string> input = Console.ReadLine().Split().ToList();
            string currentInput;

            while ((currentInput = Console.ReadLine()) != "3:1")
            {
                string[] tokens = currentInput.Split();
                if (tokens[0] =="merge")
                {
                    int indexOne = int.Parse(tokens[1]);
                    int indexTwo = int.Parse(tokens[2]);

                    if (input.Count - 1 <indexTwo )
                    {
                        indexTwo = input.Count - 1;
                    }
                    if(input.Count - 1 < indexOne)
                    {
                        continue;
                    }
                    if(indexOne < 0)
                    {
                        indexOne = 0;
                    }
                    if(indexTwo<0)
                    {
                        continue;
                    }
                    string toAdd = string.Empty;

                    for (int i = indexOne; i <= indexTwo; i++)
                    {
                        toAdd+= input[i];
                    }

                    int count = indexTwo - indexOne;
                    input.Insert(indexOne, toAdd);
                    input.RemoveRange(indexOne + 1, count+1);
                }

                else if(tokens[0] == "divide")
                {
                    int indexToDivide = int.Parse(tokens[1]);
                    int parts = int.Parse(tokens[2]);
                    
                    int lengthOfTheIndex = input[indexToDivide].Length;
                    if (parts > lengthOfTheIndex)
                    {
                        continue;
                    }
                    int numberOfChars = lengthOfTheIndex / parts;
                    int lastCharNumber = numberOfChars + (lengthOfTheIndex % parts);

                    List<char> toDivide = input[indexToDivide].ToList();
                    List<string> toAdd = new List<string>();
                    for (int i = 0; i < parts; i++)
                    {
                        if(i!=parts-1)
                        {
                            var chars = toDivide.Take(numberOfChars);
                            string charsToString = string.Empty;
                            foreach (var item in chars)
                            {
                                charsToString += item;
                            }
                            toAdd.Add(charsToString);
                            toDivide.RemoveRange(0, numberOfChars);
                        }
                        else
                        {
                            var chars = toDivide.Take(lastCharNumber);
                            string charsToString = string.Empty;
                            foreach (var item in chars)
                            {
                                charsToString += item;
                            }
                            toAdd.Add(charsToString);
                        }
                    }
                    input.RemoveAt(indexToDivide);
                    input.InsertRange(indexToDivide, toAdd);
                }
            }
            Console.WriteLine(string.Join(" ", input));
        }
    }
}
