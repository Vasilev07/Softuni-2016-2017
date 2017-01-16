using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pr05.Transport
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            var car = 0;
            var microbus = 0;
            var minibus = 0;
            var bigbus = 0;
            var train = 0;
            int total = 0;
            for (int i = 1; i <= n; i++)
            {
                int studentsCount = int.Parse(Console.ReadLine());
                if (studentsCount <= 5)
                {
                    car+=studentsCount;
                }
                else if (studentsCount >= 6 && studentsCount <=12)
                {
                    microbus+=studentsCount;
                }
                else if (studentsCount >= 13 && studentsCount <= 25)
                {
                    minibus+=studentsCount;
                }
                else if (studentsCount >= 26 && studentsCount <= 40)
                {
                    bigbus+=studentsCount;
                }
                else if (studentsCount >= 41)
                {
                    train+=studentsCount;
                }
                total += studentsCount;
            }
            var p1Percentage = car * 100.0 / total;
            var p2Percentage = microbus * 100.0 / total;
            var p3Percentage = minibus * 100.0 / total;
            var p4Percentage = bigbus * 100.0 / total;
            var p5Percentage = train * 100.0 / total;

            Console.WriteLine("{0:f2}%", p1Percentage);
            Console.WriteLine("{0:f2}%", p2Percentage);
            Console.WriteLine("{0:f2}%", p3Percentage);
            Console.WriteLine("{0:f2}%", p4Percentage);
            Console.WriteLine("{0:f2}%", p5Percentage);
        }
    }
}
