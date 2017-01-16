using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.MinAndMax
{
    class MinAndMax
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int minValue = int.MaxValue;
            int maxValue = int.MinValue;
            for (int i = 0; i < n; i++)
            {
                int currentNum = int.Parse(Console.ReadLine());
                if (currentNum > maxValue)
                {
                    maxValue = currentNum;
                    
                }

                if (currentNum < minValue)
                {
                    minValue = currentNum;

                }


            }
          
            Console.WriteLine(maxValue);
            Console.WriteLine(minValue);
        }
    }
}
