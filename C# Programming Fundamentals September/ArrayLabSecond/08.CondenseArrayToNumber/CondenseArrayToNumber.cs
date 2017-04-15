using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08.CondenseArrayToNumber
{
    public class CondenseArrayToNumber
    {
        public static void Main()
        {
            var numbers = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();
            var condensed = new int[numbers.Length - 1];
            if (numbers.Length == 1)
            {
                Console.WriteLine(string.Join("", numbers[0]));
                return;
            }
            for (int i = 0; i < numbers.Length; i++)
            {
                for (int j = 0; j < condensed.Length - i; j++)
                {
                    condensed[j] = numbers[j] + numbers[j + 1];
                }
                numbers = condensed;
                Console.WriteLine();
            }
            Console.WriteLine(string.Join("", condensed[0]));
        }
    }
}
