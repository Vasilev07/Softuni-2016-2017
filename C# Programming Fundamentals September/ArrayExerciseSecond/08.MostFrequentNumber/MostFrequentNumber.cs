using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08.MostFrequentNumber
{
    public class MostFrequentNumber
    {
        public static void Main()
        {
            var numbers = Console.ReadLine()
                   .Split()
                   .Select(int.Parse)
                   .ToArray();

            var mostFrequent = 0;
            var repetition = 0;
           
            for (int i = 0; i < numbers.Length; i++)
            {
                var current = numbers[i];
                var counter = 0;
                for (int j = 1; j < numbers.Length; j++)
                {
                    if(current == numbers[j])
                    {
                        counter++;
                    }
                }

                if (counter > repetition)
                {
                    mostFrequent = current;
                    repetition = counter;
                }
            }
            Console.WriteLine($"{mostFrequent}");

        }
    }
}
