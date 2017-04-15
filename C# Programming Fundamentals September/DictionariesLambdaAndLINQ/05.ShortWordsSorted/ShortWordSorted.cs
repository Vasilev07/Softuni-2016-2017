using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.ShortWordsSorted
{
    public class ShortWordSorted
    {
        public static void Main()
        {
            var text = Console.ReadLine()
                .Trim()
                .ToLower()
                .Split(new char[] { ' ', '.', ',', ':', ';', '(', ')', '[', ']', '"', '\'', '\\', '/', '!', '?' }, StringSplitOptions.RemoveEmptyEntries)
                .ToList();

            var result = text.Where(x => x.Length < 5).OrderBy(x => x).Distinct().ToList();

            Console.WriteLine(string.Join(", ",result));

        }
    }
}
