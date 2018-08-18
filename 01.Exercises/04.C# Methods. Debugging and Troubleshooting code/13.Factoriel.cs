using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace _13Factoriel
{
    class Program
    {
        static void Main(string[] args)
        {
            BigInteger number = BigInteger.Parse(Console.ReadLine());
            BigInteger i = CalculateFactoriel(number);

            Console.WriteLine(i);
        }
        static BigInteger CalculateFactoriel(BigInteger number)
        {
            BigInteger factoriel = 1;

            for (BigInteger i = 1; i <= number; i++)
            {
                factoriel *= i;
            }
            return factoriel;
        }
    }
}
