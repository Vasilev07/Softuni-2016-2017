using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace _02.ConvertFromBaseNToBase10
{
    public class ConvertFromDiffBase
    {
        public static void Main()
        {
            var numbers = Console.ReadLine()
                  .Trim()
                  .Split(' ')
                  .ToList();

            var number = numbers[1].ToList();
            var basse = BigInteger.Parse(numbers[0]);
            BigInteger sum = 0;
            number.Reverse();
            for (int i = 0; i < number.Count; i++)
            {
                var currentNumber = (BigInteger)char.GetNumericValue(number[i]);
                var pow = BigInteger.Pow(basse, i);
                sum += pow * currentNumber;
            }
            Console.WriteLine(sum);
        }
    }
}
