using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _16.ClassRoom
{
    class ClassRoom
    {
        static void Main(string[] args)
        {
            float h = float.Parse(Console.ReadLine());
            float w = float.Parse(Console.ReadLine());
            int row = (int)(h * 100 / 120);
            int col = (int)(((w * 100) - 100) / 70);
            int seats = (row * col) - 3;
            Console.WriteLine(seats);
        }
    }
}
