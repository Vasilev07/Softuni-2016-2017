using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.BiggestOfThreeInt
{
    class BiggestOfThreeInt
    {
        static void Main(string[] args)
        {
            double firstNum = double.Parse(Console.ReadLine());
            double secondNum = double.Parse(Console.ReadLine());
            double thirdNum = double.Parse(Console.ReadLine());

            if (firstNum > secondNum && firstNum > thirdNum)
            {
                Console.WriteLine(firstNum);
            }
            else if (secondNum > firstNum && secondNum > thirdNum)
            {
                Console.WriteLine(secondNum);
            }
            else
            {
                Console.WriteLine(thirdNum);
            }
        }
    }
}
