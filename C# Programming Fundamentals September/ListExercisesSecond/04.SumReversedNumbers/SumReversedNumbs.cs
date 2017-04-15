using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.SumReversedNumbers
{
    public class SumReversedNumbs
    {
        public static void Main()
        {
            var numbers = Console.ReadLine()
                .Split()
                .ToList();
            var sum = 0;
            for (int i = 0; i < numbers.Count; i++)
            {
                var cArray = numbers[i];
                string reverse = String.Empty;
                for (int j = cArray.Length - 1; j > -1; j--)
                {
                    reverse += cArray[j];
                }
                sum += int.Parse(reverse);
            }



            Console.WriteLine(sum);
        }
    }
}