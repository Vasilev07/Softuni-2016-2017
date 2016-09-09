using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _17.RepairOfTiles
{
    class RepairOfTiles
    {
        static void Main(string[] args)
        {
            int widthOfGround = int.Parse(Console.ReadLine());
            double widthOfTile = double.Parse(Console.ReadLine());
            double lenghtOfTile = double.Parse(Console.ReadLine());
            double widthOfBench = double.Parse(Console.ReadLine());
            double lenghtOfBench = double.Parse(Console.ReadLine());
            double benchSize = widthOfBench * lenghtOfBench;
            double groundSize = (widthOfGround * widthOfGround) - benchSize;
            double tileSieze = widthOfTile * lenghtOfTile;
            double neededTiles = groundSize / tileSieze;
            double timeToComplete = neededTiles * 0.2D;
            Console.WriteLine(neededTiles);
            Console.WriteLine(timeToComplete);
         }
    }
}
