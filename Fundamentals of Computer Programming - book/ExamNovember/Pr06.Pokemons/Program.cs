using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pr06.Pokemons
{
    class Program
    {
        static void Main(string[] args)
        {
            int firstPlayer = int.Parse(Console.ReadLine());
            int secondPlayer = int.Parse(Console.ReadLine());
            int maxBattles = int.Parse(Console.ReadLine());
            int counter = 0;
            for (int i = 1; i <= firstPlayer; i++)
            {
                for (int j = 1; j <= secondPlayer; j++)
                {
                    if (counter == maxBattles)
                    {
                        break;
                    }
                    else
                    {
                        Console.Write("({0} <-> {1}) ", i, j);
                    }

                    counter++;
                }
            }
        }
    }
}
