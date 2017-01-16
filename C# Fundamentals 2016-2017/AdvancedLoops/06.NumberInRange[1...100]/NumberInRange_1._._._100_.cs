using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.NumberInRange_1._._._100_
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = 0;

            do
            {
                Console.WriteLine("Enter valid number in range[1...100]:");
                n = int.Parse(Console.ReadLine());
                if (n>= 1 && n<=100)
                {

                    Console.WriteLine("The number is {0}", n);
                    break;

                }


                Console.WriteLine("Invalid number");
               
            } while (true);
        }
    }
}
