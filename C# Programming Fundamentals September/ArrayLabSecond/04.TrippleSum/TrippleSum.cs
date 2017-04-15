using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.TrippleSum
{
    public class TrippleSum
    {
        public static void Main()
        {
            var array = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();

            var containSum = true;
            for (int a = 0; a < array.Length; a++)
            {
                var sum = 0;
                for (int b = a+1; b < array.Length; b++)
                {
                    sum = array[a] + array[b];
                    for (int i = 0; i < array.Length; i++)
                    {
                        if (array[i] == sum)
                        {
                            Console.WriteLine($"{array[a]} + {array[b]} == {sum}");
                            containSum = true;
                            break;
                        }
                    }
                }
            }
            if (!containSum)
            {
                Console.WriteLine("No");
            }
        }
    }
}
