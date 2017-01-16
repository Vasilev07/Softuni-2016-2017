using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pr06.StopNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            var toN = int.Parse(Console.ReadLine());
            var fromM = int.Parse(Console.ReadLine());
            var stopNumber = int.Parse(Console.ReadLine());

            for (int i = fromM; i > toN; i--)
            {
                if (i % 2 == 0 && i % 3 == 0)
                {
                    if (i == stopNumber)
                    {
                        break;
                    }
                    Console.Write(i + " ");
                   
                   
                }
                
            }
            Console.WriteLine();
        }
    }
}
