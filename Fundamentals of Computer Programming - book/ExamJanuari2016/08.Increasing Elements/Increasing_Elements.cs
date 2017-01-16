using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08.Increasing_Elements
{
    class Increasing_Elements
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int counter = 0;
            int maxElem = 0;
            int start = 0;
            for (int i = 0; i < n; i++)
            {
                int currentNum = int.Parse(Console.ReadLine());
              
                if (currentNum > start)
                {
                    counter++;
                }
                else
                {
                    counter = 1;
                }
                if (counter > maxElem)
                {
                    maxElem = counter;
                }
                start = currentNum;
            }
            Console.WriteLine(maxElem);
        }
    }
}
