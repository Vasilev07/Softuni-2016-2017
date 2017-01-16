using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13.Histogram
{
    class Histogram
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int p1 = 0;
            int p2 = 0;
            int p3 = 0;
            int p4 = 0;
            int p5 = 0;
            int counter = 0;
            for (int i = 1; i < n; i++)
            {
              
                int currentNum = int.Parse(Console.ReadLine());
                
                if (currentNum < 200)
                {

                    counter += 1;
                    p1 = counter / (n * 100);
                   
                }
                if (currentNum >= 200 && currentNum <= 399)
                {
                    counter++;
                    p2 = counter / (n * 100);
                }
                if (currentNum >= 400 && currentNum <= 599)
                {
                    counter++;
                    p3 = counter / (n * 100);
                }
                if (currentNum >= 600 && currentNum <= 799)
                {
                    counter++;
                    p4 = counter / (n * 100);
                }
                if (currentNum >= 800)
                {
                    counter++;
                    p5 = counter / (n * 100);
                }
            }
            Console.WriteLine($"{p1:f2} %");
            Console.WriteLine($"{p2:f2} %");
            Console.WriteLine($"{p3:f2} %");
            Console.WriteLine($"{p4:f2} %");
            Console.WriteLine($"{p5:f2} %");
        }
    }
}
