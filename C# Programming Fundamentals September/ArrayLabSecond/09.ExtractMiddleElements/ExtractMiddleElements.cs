using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09.ExtractMiddleElements
{
    public class ExtractMiddleElements
    {
        public static void Main(string[] args)
        {
            var numbers = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();

            if (numbers.Length == 1)
            {
                numbers.Take(numbers[0]);
                Console.WriteLine(string.Join("", numbers));
            }
            else
            {
                if (numbers.Length % 2 == 0)
                {
                    Console.WriteLine(string.Join(" ", numbers.Skip(numbers.Length / 2 - 1).Take(2)));
                }
                else
                {
                    
                    Console.WriteLine(string.Join(" ", numbers.Skip(numbers.Length / 2 - 1).Take(3)));
                }
            }
        }
    }
}
