using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10.HalfSumElement
{
    class HalfSumElement
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int maxNumber = int.MinValue;
            int sum = 0;
            for (int i = 0; i < n; i++)
            {
                int numberInput = int.Parse(Console.ReadLine());
                sum += numberInput;
                if (maxNumber < numberInput)
                {
                    maxNumber = numberInput;
                }
            }
            if ((sum - maxNumber) == maxNumber)
            {
                Console.WriteLine("Yes Sum " + (sum - maxNumber));
            }
            else
            {
                Console.WriteLine("No Diff " + Math.Abs((sum - maxNumber)-maxNumber) );
            }
        }
    }
}
