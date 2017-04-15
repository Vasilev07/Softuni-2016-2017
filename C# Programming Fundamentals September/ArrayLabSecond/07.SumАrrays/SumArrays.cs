using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07.SumАrrays
{
    public class SumArrays
    {
        public static void Main()
        {
            var firstArray = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();

            var secondArray = Console.ReadLine()
               .Split()
               .Select(int.Parse)
               .ToArray();

            var summedArray = new int[Math.Max(firstArray.Length, secondArray.Length)];

            if (firstArray.Length == secondArray.Length)
            {
                for (int i = 0; i < firstArray.Length; i++)
                {
                    summedArray[i] = firstArray[i] + secondArray[i]; 
                }
            }
            else if (firstArray.Length > secondArray.Length)
            {
                
                for (int i = 0; i < firstArray.Length; i++)
                {
                    summedArray[i] = secondArray[i % secondArray.Length] + firstArray[i];
                }
            }
            else
            {
                for (int i = 0; i < secondArray.Length; i++)
                {
                    summedArray[i] = firstArray[i % firstArray.Length] + secondArray[i];
                }
            }

            Console.WriteLine(string.Join(" ", summedArray));
        }
    }
}
