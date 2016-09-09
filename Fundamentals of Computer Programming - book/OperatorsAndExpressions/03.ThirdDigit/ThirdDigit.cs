using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.ThirdDigit
{
    class ThirdDigit
    {
        static void Main(string[] args)
        {
            
            int someInt = int.Parse(Console.ReadLine());
            int check = (someInt / 100) % 10;
            if (check == 7)
            {
                Console.WriteLine("Third Digit = 7");
            }
            else
            {
                Console.WriteLine("Third Digit != 7");
            }
        }
    }
}
