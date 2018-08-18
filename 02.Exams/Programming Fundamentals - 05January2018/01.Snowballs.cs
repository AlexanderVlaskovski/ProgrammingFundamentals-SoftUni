using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace ExamPracticeJanuary
{
    class Program
    {
        static void Main()
        {
            int numberOfSnowBalls = int.Parse(Console.ReadLine());
            List<BigInteger> maxValues = new List<BigInteger>();
            maxValues.Add(0);
            maxValues.Add(0);
            maxValues.Add(0);
            maxValues.Add(0);

            for (int i = 0; i < numberOfSnowBalls; i++)
            {
                int snowballSnow = int.Parse(Console.ReadLine());
                int snowballTime = int.Parse(Console.ReadLine());
                int snowballQuality = int.Parse(Console.ReadLine());
                BigInteger snowballValue = BigInteger.Pow((snowballSnow / snowballTime), snowballQuality);
                if (snowballValue>maxValues[0])
                {
                    maxValues[0] = snowballValue;
                    maxValues[1] = snowballSnow;
                    maxValues[2] = snowballTime;
                    maxValues[3] = snowballQuality;
                }
            }
            Console.WriteLine($"{maxValues[1]} : {maxValues[2]} = {maxValues[0]} ({maxValues[3]})");
        }
    }
}
