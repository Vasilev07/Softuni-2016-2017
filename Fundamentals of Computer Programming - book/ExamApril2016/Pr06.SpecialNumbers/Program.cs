using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pr06.SpecialNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
          
            for (int i = 1111; i <= 9999; i++)
            {
                var firstNumber = i / 1000;
                var secondNumber = (i / 100) % 10;
                var thirdNumber = (i / 10) % 10;
                var fourthNumber = i % 10;
                if (firstNumber != 0 && secondNumber!=0 && thirdNumber!=0 && fourthNumber != 0)
                {
                    if (n % firstNumber == 0 && n % secondNumber == 0 && n % thirdNumber == 0 && n % fourthNumber == 0)
                    {
                        Console.Write("{0}{1}{2}{3} ", firstNumber, secondNumber, thirdNumber, fourthNumber);
                    }
                }
                else
                {

                }
                
            }
            Console.WriteLine();
        }
    }
}
