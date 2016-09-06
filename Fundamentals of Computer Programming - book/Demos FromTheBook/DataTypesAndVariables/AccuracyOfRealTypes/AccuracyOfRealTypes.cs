using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.AccuracyOfRealTypes
{
    class AccuracyOfRealTypes
    {
        static void Main(string[] args)
        {
            //Declare some variables
            float floatPi = 3.14159265358979328F;
            double doublePi = 3.14159265358979328F;

            Console.WriteLine("Float Pi is " + floatPi);
            Console.WriteLine("Double Pi is " + doublePi);

            decimal decimalPi = 3.14159265358979328M;
            Console.WriteLine(decimalPi);
        }
    }
}
