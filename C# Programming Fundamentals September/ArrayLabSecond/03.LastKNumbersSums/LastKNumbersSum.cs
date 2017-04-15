using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.LastKNumbersSums
{
    public class LastKNumbersSum
    {
        public static void Main()
        {
            var n = int.Parse(Console.ReadLine());
            var k = int.Parse(Console.ReadLine());

            var numbers = new long[n];
            numbers[0] = 1;
            long sum = 1;
            for (int i = 1; i < numbers.Length; i++)
            {
                for (int prevNum = i-k; prevNum < i-1; prevNum++)
                {
                    if (prevNum >= 0)
                    {
                        sum += numbers[prevNum];
                    }
                }
                numbers[i] = sum;
            }

            Console.WriteLine(string.Join(" ", numbers));
        }
    }
}
