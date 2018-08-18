using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02LadyBugKenov
{
    class Program
    {
        static void Main()
        {
            int length = int.Parse(Console.ReadLine());
            int[] field = new int[length];

            var ladyBugIndexes = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).Where(i => i >= 0 && i < length).ToList();

            foreach (var index in ladyBugIndexes)
            {
                field[index] = 1;  //ladybug here
            }
             
            while(true)
            {
                string line = Console.ReadLine();

                if (line == "end")
                {
                    break;
                }

                string[] commandParts = line.Split(' ');

                var currentLadyBugIndex = int.Parse(commandParts[0]);
                var direction = commandParts[1];
                var flyLength = int.Parse(commandParts[2]);

                if (direction == "left")
                {
                    flyLength *= -1;
                }
                if (currentLadyBugIndex < 0 || currentLadyBugIndex >= length)
                {
                    continue;
                }

                if (field[currentLadyBugIndex] == 0)
                {
                    continue;
                }


                field[currentLadyBugIndex] = 0; //fly away
                var nextIndexToLand = currentLadyBugIndex;

                while (true)

                {
                    nextIndexToLand += flyLength;

                    if (nextIndexToLand < 0 || nextIndexToLand >= length)
                    {
                        break;
                    }

                    if(field[nextIndexToLand] == 1)
                    {
                        continue;
                    }

                    field[nextIndexToLand] = 1; // just landed
                    break;

                }
            }
            Console.WriteLine(string.Join(" ", field));
        }
        
    }
}
