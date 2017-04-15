﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.MaxSequenceOfEqualElements
{
    public class MaxSequenceOfEqualElements
    {
        public static void Main()
        {
            var numbers = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();

            var maxCount = 1;
            var count = 1;
            var position = 0;
            
            for (int i = 1; i < numbers.Length; i++)
            {
                if (numbers[i-1] == (numbers[i]))
                {
                    count++;
                    if (count > maxCount)
                    {
                        maxCount = count;
                        position = i - count + 1;
                    }
                }
                else
                {
                    count = 1;
                }
            }
            for (int i = position; i < position+maxCount; i++)
            {
                Console.Write(numbers[i] + " ");
            }
            Console.WriteLine();

           
        }
    }
}