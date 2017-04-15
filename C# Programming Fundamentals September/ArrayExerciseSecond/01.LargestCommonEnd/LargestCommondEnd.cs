using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.LargestCommonEnd
{
    public class LargestCommondEnd
    {
        public static void Main()
        {
            var firstArray = Console.ReadLine()
                .Split()
                .ToArray();

            var secondArray = Console.ReadLine()
                .Split()
                .ToArray();

            if (ScanFromLeft(firstArray, secondArray) >= ScanFromRight(firstArray, secondArray))
            {
                Console.WriteLine(ScanFromLeft(firstArray, secondArray));
            }
            else
            {
                Console.WriteLine(ScanFromRight(firstArray, secondArray));
            }

        }

        public static int ScanFromLeft(string[] firstArray, string[] secondArray)
        {
            var shorterArray = Math.Min(firstArray.Length, secondArray.Length);
            var count = 0;
            var maxCount = 0;
            for (int i = 0; i < shorterArray-1; i++)
            {
                if (firstArray[i] == secondArray[i])
                {
                    count++;
                    if (maxCount < count)
                    {
                        maxCount = count;
                    }
                }
            }
            return maxCount;
        }

        public static int ScanFromRight(string[] firstArray, string[] secondArray)
        {
            var shorterArray = Math.Min(firstArray.Length, secondArray.Length);
            var count = 0;
            var maxCount = 0;
            for (int i = 0; i < shorterArray-1; i++)
            {
                if (firstArray[firstArray.Length-i-1] == secondArray[secondArray.Length - i - 1])
                {
                    count++;
                    if (maxCount < count)
                    {
                        maxCount = count;
                    }
                }
            }
            return maxCount;
        }
    }
}
