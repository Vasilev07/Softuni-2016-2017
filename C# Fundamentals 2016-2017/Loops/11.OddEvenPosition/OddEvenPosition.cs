using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11.OddEvenPosition
{
    class OddEvenPosition
    {
        static void Main(string[] args)
        {
            double n = double.Parse(Console.ReadLine());
            double sumOdd = 0.0;
            double sumEven = 0.0;
            double minOdd = double.MaxValue;
            double maxOdd = double.MinValue;
            double minEven = double.MaxValue;
            double maxEven = double.MinValue;

            for (int i = 1; i < n+1; i++)
            {
                double currentNum = double.Parse(Console.ReadLine());
                bool isOdd = i % 2 != 0;
                bool isEven = i % 2 == 0;
                if (isOdd)
                {
                    if (currentNum > maxOdd)
                    {
                        maxOdd = currentNum;
                    }
                    if (currentNum < minOdd)
                    {
                        minOdd = currentNum;
                    }
                    sumOdd += currentNum;
                }
                else if (isEven)
                {
                    if (currentNum > maxEven)
                    {
                        maxEven = currentNum;
                    }
                    if (currentNum < minEven)
                    {
                        minEven = currentNum;
                    }
                    sumEven += currentNum;
                }




            }
            Console.WriteLine("OddSum={0},", sumOdd);

            if (minOdd == double.MaxValue)
            {
                Console.WriteLine("oddmin No,");
            }
            else
            {
                Console.WriteLine("OddMin={0},", minOdd);
            }
            if (maxOdd == double.MinValue)
            {
                Console.WriteLine("oddmax No,");
            }
            else
            {
                Console.WriteLine("OddMax={0},", maxOdd);
            }

            Console.WriteLine("EvenSum={0},", sumEven);

            if (minEven == double.MaxValue)
            {
                Console.WriteLine("evenmin No,");
            }
            else
            {
                Console.WriteLine("EvenMin={0},", minEven);
            }
            if (maxEven == double.MinValue)
            {
                Console.WriteLine("evenmax No");
            }
            else
            {
                Console.WriteLine("EvenMax={0}", maxEven);
            }


        }
    }
}
