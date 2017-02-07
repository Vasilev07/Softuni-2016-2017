using System;
using System.Collections.Generic;


namespace _07.PrimeCheckInRange
{
    class Program
    {
        public static void Main()
        {
            int start = int.Parse(Console.ReadLine());
            int end = int.Parse(Console.ReadLine());

            List<int> primes = findPrimes(start, end);

            Console.WriteLine(String.Join(", ", primes));
        }

        public static List<int> findPrimes(int start, int end)
        {
            List<int> nums = new List<int>();

            for (int curNum = start; curNum <= end; curNum++)
            {
                bool isPrime = true;

                if (curNum == 0 || curNum == 1)
                {
                    continue;
                }

                for (int devider = 2; devider <= Math.Sqrt(curNum); devider++)
                {
                    if (curNum % devider == 0)
                    {
                        isPrime = false;
                        break;
                    }
                }

                if (isPrime)
                {
                    nums.Add(curNum);
                }

            }
            return nums;

        }
    }
}
