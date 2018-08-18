using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03RageQuit
{
    class Program
    {
        static void Main()
        {
            string input = Console.ReadLine().ToUpper();
            List<char> specialSymbols = new List<char>();
            StringBuilder output = new StringBuilder();
            string currentString = "";
            int currentCount = 0;
            string count = "";


            for (int i = 0; i < input.Length; i++)
            {
                if (!char.IsDigit(input[i]))
                {
                    if(specialSymbols.Contains(input[i])==false)
                    {
                        specialSymbols.Add(input[i]);
                    }
                }
                if(!char.IsDigit(input[i]))
                {
                    if(count.Length > 0)
                    {
                        currentCount = int.Parse(count);
                        for (int j = 0; j < currentCount; j++)
                        {
                            output.Append(currentString);
                        }
                        currentString = "";
                        currentCount = 0;
                        count = "";
                    }
                    currentString += input[i];
                }
                else
                {
                    count += input[i].ToString();

                    if (i == input.Length - 1)
                    {
                        if (count.Length > 0)
                        {
                            currentCount = int.Parse(count);
                            for (int j = 0; j < currentCount; j++)
                            {
                                output.Append(currentString);
                            }
                            currentString = "";
                            currentCount = 0;
                            count = "";
                        }
                    }
                }
                

            }
            
            Console.WriteLine($"Unique symbols used: {specialSymbols.Distinct().Count()}");
            Console.WriteLine(output);
        }
    }
}
