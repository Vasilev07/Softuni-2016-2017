namespace _01.LargestCommonEnd
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class LargestCommonEnd
    {
        public static void Main(string[] args)
        {
            var firstArr = Console.ReadLine()
                .Split(' ')
                .ToArray();
            var secondArr = Console.ReadLine()
                .Split(' ')
                .ToArray();
            
           
            if (ScanFromRight(firstArr,secondArr) != 0)
            {
                Console.WriteLine(ScanFromRight(firstArr, secondArr));
            }
            else
            {
                Console.WriteLine(ScanFromLeft(firstArr, secondArr));
            }
           
        }
        public static int ScanFromLeft(string[] firstArr, string[] secondArr)
        {
            var maxCounter = 0;
            firstArr.Reverse();
            secondArr.Reverse();
            var counter = 0;
          
            if (firstArr.Length >= secondArr.Length)
            {
                for (int i = 0; i < secondArr.Length; i++)
                {
                    if (firstArr[i] == secondArr[i])
                    {
                        counter++;

                        if (maxCounter < counter)
                        {
                            maxCounter = counter;
                        }
                    }
                }
            }
            else
            {
                for (int i = 0; i < firstArr.Length; i++)
                {
                    if (firstArr[i] == secondArr[i])
                    {
                        counter++;

                        if (maxCounter < counter)
                        {
                            maxCounter = counter;
                        }
                    }
                }
            }
            return maxCounter;
        }

        public static int ScanFromRight(string[] firstArr, string[] secondArr)
        {
            var counter = 0;
            var maxCounter = 0;
            if (firstArr.Length >= secondArr.Length)
            {
                for (int i = 0; i < secondArr.Length; i++)
                {
                    if (firstArr[i] == secondArr[i])
                    {
                        counter++;

                        if (maxCounter < counter)
                        {
                            maxCounter = counter;
                        }
                    }
                }
            }
            else
            {
                for (int i = 0; i < firstArr.Length; i++)
                {
                    if (firstArr[i] == secondArr[i])
                    {
                        counter++;

                        if (maxCounter < counter)
                        {
                            maxCounter = counter;
                        }
                    }
                }
            }
            return maxCounter;

        }
    }
}