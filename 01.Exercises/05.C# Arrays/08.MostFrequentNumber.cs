using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _26MostFrequentNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            long[] inputArray = Console.ReadLine().Split(' ').Select(long.Parse).ToArray();
            int counter = 1;
            int counterMax = 0;
            int number = 0;

            for (int i = 0; i < inputArray.Length; i++)
            {
                for (int j =0 ; j < inputArray.Length; j++)
                {
                    if (inputArray[i] == inputArray[j])
                    {
                        if (counter > counterMax)
                        {
                            counterMax = counter;
                            number = (int)inputArray[j];
                        }
                        counter++;
                    }
                    else counter = 1;
                    


                }
            }
            Console.WriteLine(number);
        }
    }
}
