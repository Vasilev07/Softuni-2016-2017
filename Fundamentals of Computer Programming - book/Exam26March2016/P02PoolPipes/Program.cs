using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P02PoolPipes
{
    class Program
    {
        static void Main(string[] args)
        {
            int v = int.Parse(Console.ReadLine());
            int p1 = int.Parse(Console.ReadLine());
            int p2 = int.Parse(Console.ReadLine());
            double hours = double.Parse(Console.ReadLine());
            double pipe1 = p1 * hours;
            double pipe2 = p2 * hours;
            double sumLiters = pipe1 + pipe2;
            double sumLitersInPercet = (sumLiters / v) * 100;
            double firstInPercent = (pipe1 / sumLiters)*100;
            double secondInPercent = (pipe2 / sumLiters) * 100;
            double overflow = v - sumLiters;

            if (sumLitersInPercet <= 100)
            {
                
                Console.WriteLine("The pool is {0}% full. Pipe 1: {1}%. Pipe 2: {2}%.",Math.Floor(sumLitersInPercet), Math.Floor(firstInPercent), Math.Floor(secondInPercent));
            }
            else if(sumLitersInPercet > 100)
            {
                
                Console.WriteLine("For {0} hours the pool overflows with {1} liters.", hours, Math.Abs(overflow));
            }
        }
    }
}
