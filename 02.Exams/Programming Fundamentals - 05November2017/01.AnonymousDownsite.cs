using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace ExamPreparation2
{
    class Program
    {
        static void Main()
        {
            
            int numberOfDownSites = int.Parse(Console.ReadLine());
            int securityKey = int.Parse(Console.ReadLine());
            int count = 0;
            decimal totalLoss = 0M;
            while (count < numberOfDownSites)
            {
                string[] inputData = Console.ReadLine().Split();

                string name = inputData[0];
                long siteVisits = long.Parse(inputData[1]);
                decimal price = decimal.Parse(inputData[2]);
                totalLoss += siteVisits * price;
                Console.WriteLine($"{name}");


                count++;
            }
            Console.WriteLine($"Total Loss: {totalLoss:f20}");
            BigInteger securityToken = BigInteger.Pow(securityKey, numberOfDownSites);
            Console.WriteLine($"Security Token: {securityToken}");
        }
    }
}
