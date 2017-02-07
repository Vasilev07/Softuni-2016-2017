using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09.LongerLine
{
    class Program
    {

        static void Main(string[] args)
        {
            var x1 = double.Parse(Console.ReadLine());
            var y1 = double.Parse(Console.ReadLine());
            var x2 = double.Parse(Console.ReadLine());
            var y2 = double.Parse(Console.ReadLine());
            var x3 = double.Parse(Console.ReadLine());
            var y3 = double.Parse(Console.ReadLine());
            var x4 = double.Parse(Console.ReadLine());
            var y4 = double.Parse(Console.ReadLine());

            ClosestPointToTheCenter(x1, y1, x2, y2, x3, y3, x4, y4);
        }
        static void ClosestPointToTheCenter(double x1, double y1, double x2, double y2, double x3, double y3, double x4, double y4)
        {

            double firstPoint = Math.Abs(x1) + Math.Abs(y1) + Math.Abs(x2) + Math.Abs(y2);
            double secondPoint = Math.Abs(x3) + Math.Abs(y3) + Math.Abs(x4) + Math.Abs(y4);
            if (firstPoint >= secondPoint)                              
            {
                var ss = Math.Abs(x1) + Math.Abs(y1);
                var sss = Math.Abs(x2) + Math.Abs(y2);
                if (ss <= sss)
                {
                    Console.WriteLine($"({x1}, {y1})({x2}, {y2})");
                }
                else
                {
                    Console.WriteLine($"({x2}, {y2})({x1}, {y1})");
                }
                
            }
            else
            {
                var cc = Math.Abs(x3) + Math.Abs(y3);
                var ccc = Math.Abs(x4) + Math.Abs(y4);
                if (cc <= ccc)
                {
                    Console.WriteLine($"({x3}, {y3})({x4}, {y4})");
                }
                else
                {
                    Console.WriteLine($"({x4}, {y4})({x3}, {y3})");
                }
               
            }
        }
    }
}