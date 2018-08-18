using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07MultiplyBigNumber
{
    class Program
    {
        static void Main()
        {
            string num1 = Console.ReadLine();
            int num2 = int.Parse(Console.ReadLine());
            if (num2 == 0)
            {
                Console.WriteLine("0");
                return;
            }
            int multiplier = 0;
            int remainder = 0;
            int num = 0;
            StringBuilder sb = new StringBuilder();

            for (int i = num1.Length-1; i >= 0; i--)
            {
                multiplier = (num1[i] - 48) * num2 + remainder;
                num = multiplier % 10;
                if (multiplier>9)
                {
                    remainder = multiplier / 10;
                }
                else
                {
                    remainder = 0;
                }
                sb.Append(num);

            }
            if (remainder>0)
            {
                sb.Append(remainder);
            }
            Console.WriteLine(sb.ToString().TrimEnd('0').ToCharArray().Reverse().ToArray());
        }
    }
}
