using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07.ExplicitAndImplicitTypeConversion
{
    class ExplicitAndImplicitTypeConversion
    {
        static void Main(string[] args)
        {
            //implicit conversion
            int myInt = 5;
            Console.WriteLine(myInt);
            long myLong = 5;
            Console.WriteLine(myLong);
            Console.WriteLine(myInt + myLong);

            //explicit conversion
            double myDouble = 5.1D;
            Console.WriteLine(myDouble);//5.1

            long hisLong = (long)myDouble;
            Console.WriteLine(hisLong);//5

            myDouble = 5e9d;//5*10 9
            Console.WriteLine(myDouble);//5000000000

            int xInt = (int)myDouble;
            Console.WriteLine(xInt);
            Console.WriteLine(int.MinValue);

            //data loss during type conversion
            long someLong = long.MaxValue;
            int someInt = (int)someLong;

            Console.WriteLine(someLong);
            Console.WriteLine(someInt);

            //some other examples
            float heightInMeters = 1.74F;//explicit
            double maxHeight = heightInMeters;//implicit
            double minHeight = (double)heightInMeters;
            float actualHeight = (float)maxHeight;

            //float maxHeightFloat = maxHeight;
            //compile time error

            //forcing overflow exeption during casting
            //double d = 5e9d;
            //Console.WriteLine(d);
            //int i = checked((int)d);
            //Console.WriteLine(i);

            //conversion to String
            int a = 5;
            int b = 7;
            string sum = "Sum= " + (a + b);
            Console.WriteLine(sum);

            String incorrect = "Sum= " + a + b;
            Console.WriteLine(incorrect);

            Console.WriteLine("Perimeter =" + 2 * (a + b) + ". Area =" + (a * b) + ".");
        }
    }
}
