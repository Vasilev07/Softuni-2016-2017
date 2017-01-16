using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08.OddEvenSum
{
    class OddEvenSum
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int sumEven = 0;
            int sumOdd = 0;
            for (int i = 0; i < n; i++)
            {

                int currentNumber = int.Parse(Console.ReadLine());
                if (i % 2 == 0)
                {
                    sumEven += currentNumber;
                }
                else if(i % 2 != 0)
                {
                    sumOdd += currentNumber;
                }
            }
            if ((sumEven - sumOdd) == 0)
            {
                Console.WriteLine("Yes sum {0}", sumOdd);
            }
            else
            {
                Console.WriteLine("No diff {0}", Math.Abs(sumOdd - sumEven));
            }
        }
    }
}
