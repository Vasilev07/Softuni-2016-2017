using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07.CountNumbers
{
    public class CountNumbers
    {

        public static void Main()
        {
            var numbers = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();
            numbers.Sort();
            
            var first = numbers[0];
            var count = 1;
            
            for (int i = 1; i < numbers.Count; i++)
            {
                var current = numbers[i];

                if (first == current)
                {
                    count++;
                    
                }
                else
                {
                    Console.WriteLine($"{first} -> {count}");
                    count = 1;

                }
                
                first = current;
            }
            Console.WriteLine($"{first} -> {count}");

        }
    }
}
