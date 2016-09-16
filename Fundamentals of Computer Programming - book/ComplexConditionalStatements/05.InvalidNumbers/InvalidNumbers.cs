using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.InvalidNumbers
{
    class InvalidNumbers
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            bool valid = (number >= 100 && number <=200) || number == 0;
            if (!valid)
            {
                Console.WriteLine("invalid");
            }
            else
            {
                Console.WriteLine("");
            }
            

        }
    }
}
