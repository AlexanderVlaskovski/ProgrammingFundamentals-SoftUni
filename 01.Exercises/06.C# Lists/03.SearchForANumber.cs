using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03SearchForANumber
{
    class Program
    {
        static void Main()
        {
            List<int> numbers = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToList();
            int[] manipulations = Console.ReadLine().Split().Select(int.Parse).ToArray();
            
            numbers.RemoveRange(manipulations[0], numbers.Count - manipulations[0]);
            numbers.RemoveRange(0, manipulations[1]);
            bool isThere = numbers.Contains(manipulations[2]);
            if (isThere)
            {
                Console.WriteLine("YES!");
            }
            else Console.WriteLine("NO!");
        }
    }
}
