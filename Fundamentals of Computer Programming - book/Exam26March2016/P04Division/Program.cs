using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P04Division
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            double p1 = 0;
            double p2 = 0;
            double p3 = 0;
            
            double pp1 = 0;
            double pp2 = 0;
            double pp3 = 0;
           
            for (int i = 0; i < n; i++)
            {
                int currentNum = int.Parse(Console.ReadLine());

                if (currentNum % 2 == 0)
                {
                    pp1 += 1;
                    p1 = (pp1 / n) * 100;

                }
                if (currentNum % 3 == 0)
                {
                    pp2 += 1;
                    p2 = (pp2 / n) * 100;
                }
                if (currentNum % 4 == 0)
                {
                    pp3 += 1;
                    p3 = (pp3 / n) * 100;
                }
               
            }
            Console.WriteLine("{0:F2}%", p1);
            Console.WriteLine("{0:F2}%", p2);
            Console.WriteLine("{0:F2}%", p3);
        }
    }
}
