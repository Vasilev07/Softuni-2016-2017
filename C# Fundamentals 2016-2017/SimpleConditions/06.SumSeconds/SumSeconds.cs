using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.SumSeconds
{
    class Program
    {
        static void Main(string[] args)
        {
            int firstCompetitor = int.Parse(Console.ReadLine());
            int secondCompetitor = int.Parse(Console.ReadLine());
            int thirdCOmpetitor = int.Parse(Console.ReadLine());
            int minutes = (firstCompetitor + secondCompetitor + thirdCOmpetitor) / 60;
            int seconds = (firstCompetitor + secondCompetitor + thirdCOmpetitor) % 60;
            Console.WriteLine("{0}:{1}", minutes, seconds);

        }
    }
}
