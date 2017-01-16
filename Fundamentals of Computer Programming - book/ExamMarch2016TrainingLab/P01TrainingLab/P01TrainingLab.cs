using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P01TrainingLab
{
    class Program
    {
        static void Main(string[] args)
        {
            double desksOnRow = double.Parse(Console.ReadLine());
            double row = double.Parse(Console.ReadLine());
            row = (int)(((row*100)-100)/70);
            desksOnRow = (int)((desksOnRow*100)/120);
            int result = (int)(row * desksOnRow) - 3;
            Console.WriteLine(result);
        }
    }
}
