using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataTypesVariables
{
    class Program
    {
        static void Main(string[] args)
        {
            int counter = 0;
            try
            {
                while (true)
                {
                    int number = int.Parse(Console.ReadLine());
                    counter++;

                }
            }
            catch 
            {

                Console.WriteLine(counter);
            }
        }
    }
}
