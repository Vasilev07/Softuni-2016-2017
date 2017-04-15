using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.FoldАndSum
{
    public class FoldAndSum
    {
        private static int index;

        public static void Main()
        {
            var numbers = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();

            var k = numbers.Count / 4;
            var firstleftRow = numbers
               .Take(k)
               .Reverse()
               .ToList();

            numbers.Reverse();
            var firstRightROw = numbers.Take(k).ToList();
            numbers.Reverse();

            var secondRow = numbers
                .Skip(k)
                .Take(2 * k);

            var firstRow = firstleftRow.Concat(firstRightROw).ToList();
            var sum = firstRow.Zip(secondRow, (a, b) => (a + b));
            Console.WriteLine(string.Join(" ", sum));
        }
    }
}
