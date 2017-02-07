using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace _14.FactorialWithTradingZeroes
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            Console.WriteLine(FactiorialToDigts(number));
            
        }
        public static BigInteger Factorial(BigInteger number)
        {
            BigInteger factorial = 1;
            for (int i = 1; i <= number; i++)
            {
                factorial *= i;
            }
            return factorial;
        }
        public static int FactiorialToDigts(int number)
        {
            var charArray = number.ToString().ToCharArray();
            var counter = 0;
            for (int i = 0; i < charArray.Length; i++)
            {
               counter = charArray[i];
            }
            return counter;
        }
    }
}
