using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Largest3Numbers
{
    public class Largest3Numbers
    {
        public static void Main()
        {
            var numbers = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();

            var ordering = numbers.OrderByDescending(x=>x).Take(3);
            Console.WriteLine(string.Join(" ", ordering));
        }
    }
}
