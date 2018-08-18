using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _18LargestCommonEnd
{
    class Program
    {
        static void Main()
        {
            string[] FirstArray = Console.ReadLine().Split(' ').ToArray();
            string[] SecondArray = Console.ReadLine().Split(' ').ToArray();
            int ShorterArray = 0;
            int LongerArray = 0;
            bool ifFirstLonger = true;
            if (FirstArray.Length >= SecondArray.Length)
            {
                 ShorterArray = SecondArray.Length - 1;
                 LongerArray = FirstArray.Length - 1;
            }
            else if (FirstArray.Length < SecondArray.Length)
            {
                ifFirstLonger = false;
                 ShorterArray = FirstArray.Length - 1;
                 LongerArray = SecondArray.Length - 1;
            }
            int LongestCommonPartLeft = 0;
            for (int i = 0; i <= ShorterArray; i++)
            {
                if (FirstArray[i] == SecondArray[i])
                {
                    LongestCommonPartLeft++;
                }
                else break;
            }
            int LongestCommonPartRight = 0;
           
            for (int i = ShorterArray; i >= 0; i--)
            {
                if (ifFirstLonger)
                {
                    if (FirstArray[LongerArray] == SecondArray[i])
                    {
                        LongestCommonPartRight++;
                        LongerArray--;
                    }
                    else break;
                }
                else
                {
                    if (FirstArray[i] == SecondArray[LongerArray])
                    {
                        LongestCommonPartRight++;
                        LongerArray--;
                    }
                    else break;
                }
            }
            if(LongestCommonPartLeft>=LongestCommonPartRight)
            {
                Console.WriteLine(LongestCommonPartLeft);
            }
            else if (LongestCommonPartLeft < LongestCommonPartRight)
            {
                Console.WriteLine(LongestCommonPartRight);
            }
            else Console.WriteLine(0);
        }
    }
}
