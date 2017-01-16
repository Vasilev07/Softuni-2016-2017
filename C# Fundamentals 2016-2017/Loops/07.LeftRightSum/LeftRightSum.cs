using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07.LeftRightSum
{
    class LeftRightSum
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int leftSum = 0;
            int rightSum = 0;

            for (int i = 0; i < n; i++)
            {
                int num = int.Parse(Console.ReadLine());
                leftSum += num;
            }
            for (int i = 0; i < n; i++)
            {
                int num = int.Parse(Console.ReadLine());
                rightSum += num;
            }

            if (rightSum == leftSum)
            {
                
                Console.WriteLine($"Yes, sum = {leftSum}");
            }
            else
            {
                int sum = Math.Abs(leftSum - rightSum);
                Console.WriteLine($"No, diff =  {sum}");
            }
        }
    }
}
