using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.MinMaxSumAverage
{
    public class MinMaxSumAverage
    {
        public static void Main()
        {
            var lines = int.Parse(Console.ReadLine());
            var holder = new List<int>();
            for (int i = 0; i < lines; i++)
            {
                var current = int.Parse(Console.ReadLine());
                holder.Add(current);
            }

            var sum = holder.Sum();
            var min = holder.Min();
            var max = holder.Max();
            var average = holder.Average();

            Console.WriteLine($"Sum = {sum}");
            Console.WriteLine($"Min = {min}");
            Console.WriteLine($"Max = {max}");
            Console.WriteLine($"Average = {average}");

        }
    }
}
