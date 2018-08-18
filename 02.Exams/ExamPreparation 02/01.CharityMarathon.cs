using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace ExamPrep2
{
    class CharityMarathon
    {
        static void Main()
        {
            int days = int.Parse(Console.ReadLine());
            long runnersCount = long.Parse(Console.ReadLine());
            int laps = int.Parse(Console.ReadLine());
            long lengthOfTheTrack = long.Parse(Console.ReadLine());
            int trackCapacity = int.Parse(Console.ReadLine());
            decimal moneyPerKilometer = decimal.Parse(Console.ReadLine());

            long maxRunners = days * trackCapacity;
            if(maxRunners < runnersCount)
            {
                runnersCount = maxRunners;
            }
            BigInteger totalMeters = runnersCount * laps * lengthOfTheTrack;
            decimal kilometers = (decimal)totalMeters / 1000;
            decimal moneyRaised = kilometers * moneyPerKilometer;
            Console.WriteLine($"Money raised: {moneyRaised:f2}");
        }
    }
}
