using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.ThreeNumsInDescendingOrder
{
    class ThreeNumsInDescendingOrder
    {
        static void Main(string[] args)
        {
            double firstNum = double.Parse(Console.ReadLine());
            double secondNum = double.Parse(Console.ReadLine());
            double thirdNum = double.Parse(Console.ReadLine());
            if (firstNum > secondNum && firstNum > thirdNum)
            {
                if (secondNum > thirdNum)
                {
                    Console.WriteLine($"{firstNum} {secondNum} {thirdNum}");
                }
                else
                {
                    Console.WriteLine($"{firstNum} {thirdNum} {secondNum}");
                }
            }
            else if (secondNum > firstNum && secondNum > thirdNum)
            {
                if (firstNum > secondNum)
                {
                    Console.WriteLine($"{secondNum} {firstNum} {thirdNum}");
                }
                else
                {
                    Console.WriteLine($"{secondNum} {thirdNum} {firstNum}");
                }
            }
            else
            {
                if (firstNum > secondNum)
                {
                    Console.WriteLine($"{thirdNum} {firstNum} {secondNum}");
                }
                else
                {
                    Console.WriteLine($"{thirdNum} {secondNum} {firstNum}");
                }
            }
        }
    }
}
