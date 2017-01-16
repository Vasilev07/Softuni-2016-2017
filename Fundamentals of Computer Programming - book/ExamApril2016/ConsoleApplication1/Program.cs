using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            int volume = int.Parse(Console.ReadLine());
            double widthOfTile = double.Parse(Console.ReadLine());
            double lenghtOfTile = double.Parse(Console.ReadLine());
            int widthOfSeat = int.Parse(Console.ReadLine());
            int lenghtOfSeat = int.Parse(Console.ReadLine());
            double totalVolume = volume* volume;
            double seatVolume = widthOfSeat * lenghtOfSeat;
            double totalCover = totalVolume - seatVolume;
            double volumeTiles = widthOfTile * lenghtOfTile;
            double tilesNeeded = totalCover / volumeTiles;
            Console.WriteLine(tilesNeeded);
            Console.WriteLine(tilesNeeded*0.2D);


        }
    }
}
