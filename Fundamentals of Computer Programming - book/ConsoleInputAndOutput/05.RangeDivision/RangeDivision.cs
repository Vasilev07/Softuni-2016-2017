using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.RangeDivision
{
    class RangeDivision
    {
        static void Main(string[] args)
        {
            int beggining = int.Parse(Console.ReadLine());
            int end = int.Parse(Console.ReadLine());
            int counter = 0;
            for (int i = beggining; i <= end; i++)
            {
                
                if (i % 5 == 0)
                {
                    ++counter;
                }

            }
            Console.WriteLine(counter);

        }
    }
}
