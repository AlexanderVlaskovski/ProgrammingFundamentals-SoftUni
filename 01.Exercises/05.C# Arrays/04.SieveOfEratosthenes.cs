using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _21SieveOfErathostene
{
    class Program
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            bool[] sieveOfErathostene = new bool[n + 1];

            for (int i = 0; i<=n; i++)
            {
                sieveOfErathostene[i] = true;
            }
            sieveOfErathostene[0] = false; sieveOfErathostene[1] = false;

            for (int i = 0; i < sieveOfErathostene.Length; i++)
            {
                if (sieveOfErathostene[i] == true)
                {
                    for (int a = 2; a*i <= n ; a++)
                    {
                        sieveOfErathostene[a * i] = false;
                    }
                }
            }
            for (int j = 0; j <= n; j++)
            {
                if(sieveOfErathostene[j] == true)
                {
                    Console.Write(j +" ");
                }
                
            }
            Console.WriteLine();

        }
    }
}
