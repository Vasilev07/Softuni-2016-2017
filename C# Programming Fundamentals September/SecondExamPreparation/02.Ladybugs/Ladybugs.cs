using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Ladybugs
{
    public class Ladybugs
    {
        public static void Main()
        {
            var fieldSize = int.Parse(Console.ReadLine());
            var ladybugIndexes = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .Where(x => x >= 0 && x < fieldSize)
                .ToArray();

            var ladybugs = new int[fieldSize];

            for (int i = 0; i < ladybugIndexes.Length; i++)
            {
                var currentLadybugIndex = ladybugIndexes[i];
                ladybugs[currentLadybugIndex] = 1;
            }


            while (true)
            {
                var line = Console.ReadLine();
                if (line == "end")
                {
                    break;
                }
                var commands = line.Split();
                var ladybugIndex = int.Parse(commands[0]);
                var direction = commands[1];
                var flyLength = int.Parse(commands[2]);
                
                if (ladybugIndex >= 0 && ladybugIndex < ladybugs.Length)
                {
                    if (direction == "right")
                    {
                        ladybugs[ladybugIndex] = 0;
                        ladybugIndex += flyLength;
                    }
                    else
                    {
                        ladybugs[ladybugIndex] = 0;
                        ladybugIndex -= flyLength;
                    }
                    if (ladybugIndex >= 0 && ladybugIndex < ladybugs.Length)
                    {
                        if (ladybugs[ladybugIndex] == 0)
                        {
                            ladybugs[ladybugIndex] = 1;

                        }
                        if (ladybugs[ladybugIndex] == 1)
                        {
                            continue;
                        }
                    }
                    else
                    {
                        
                    }
                }
                else
                {
                    break;
                }

            }
            Console.WriteLine(string.Join(" ", ladybugs));
        }
    }
}
