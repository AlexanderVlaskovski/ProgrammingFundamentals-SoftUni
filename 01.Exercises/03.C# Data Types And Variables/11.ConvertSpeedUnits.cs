using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03
{
    class Program
    {
        static void Main(string[] args)
        {
            int Distance = int.Parse(Console.ReadLine());
            int Hours = int.Parse(Console.ReadLine());
            int Minutes = int.Parse(Console.ReadLine());
            int seconds = int.Parse(Console.ReadLine());

            int Sumseconds = (Hours * 60) * 60;
            Sumseconds += Minutes * 60;
            Sumseconds += seconds;
            double speedM = (double)Distance / Sumseconds;
            Console.WriteLine($"{speedM:f6}");

            double sumMinutes = (double)(seconds / 60.0);
            sumMinutes += Minutes;
            double sumHours = (double)(sumMinutes / 60.0);
            sumHours += Hours;
            double DistanceKm = (double)Distance / 1000.0;
            double speedKm = DistanceKm / sumHours;
            Console.WriteLine($"{speedKm:f6}");

            double DistanceMiles = (double)Distance / 1609.0;
            double speedMi = DistanceMiles / sumHours;
            Console.WriteLine($"{speedMi:f6}");

        }
    }
}
