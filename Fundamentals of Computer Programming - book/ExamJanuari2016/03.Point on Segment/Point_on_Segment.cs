using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Point_on_Segment
{
    class Point_on_Segment
    {
        static void Main(string[] args)
        {
            int first = int.Parse(Console.ReadLine());
            int second = int.Parse(Console.ReadLine());
            int point = int.Parse(Console.ReadLine());
            int realSecond = Math.Max(first, second);
            int realFirst = Math.Min(first, second);
            int closerPoint = Math.Min(Math.Abs(realSecond - point), Math.Abs(realFirst - point));
            if (realFirst <= point && realSecond >= point)
            {
                Console.WriteLine("in {0}", Math.Abs(closerPoint));
            }
            else
            {
                Console.WriteLine("out {0}", Math.Abs(closerPoint));
            }

            
        }
    }
}
