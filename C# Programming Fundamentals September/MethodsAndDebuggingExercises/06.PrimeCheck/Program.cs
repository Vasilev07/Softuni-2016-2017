using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.PrimeCheck
{
    class Program
    {
        static void Main()
        {

            if (PrimeChecker() == true)
            {
                Console.WriteLine("True");
            }
            else
            {
                Console.WriteLine("False");
            }
        }

        public static bool PrimeChecker()
        {

            var num1 = long.Parse(Console.ReadLine());
           
            if (num1 == 0 || num1 == 1)
            {
                return false;
            }
            else
            {
                for (long a = 2; a <= Math.Sqrt(num1); a++)
                {
                    if (num1 % a == 0)
                    {
                        return false;
                    }
                }
                return true;
            }
        }
    }
}

