using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.RectangleOfNxNStars
{
    class RectangleOfNxNStars
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            char star = '*';
            for (int row = 0; row < n; row++)
            {
                Console.WriteLine(new string(star, n));
            }
        }
    }
}
