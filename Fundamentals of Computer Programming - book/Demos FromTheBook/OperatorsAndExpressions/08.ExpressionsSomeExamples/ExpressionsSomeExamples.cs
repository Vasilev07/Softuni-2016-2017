using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08.ExpressionsSomeExamples
{
    class ExpressionsSomeExamples
    {
        static void Main(string[] args)
        {
            int r = (150 - 20) / 2 + 5;
            double surface = Math.PI * r * r;
            //surface of circle
            double perimeter = 2 * Math.PI * r;
            //perimeter of circle
            Console.WriteLine(r);
            Console.WriteLine(surface);
            Console.WriteLine(perimeter);

            //side effects of expressions 
            int a = 5;
            int b = ++a;
            Console.WriteLine(a);//6
            Console.WriteLine(b);//6

            //expressions, Data Types and Operator Priorities
            double d = 1 / 2;
            Console.WriteLine(d);//0

            double half = (double)1 / 2;
            Console.WriteLine(half);//0.5

            //division by ZERO
            int num = 1;
            double deNum = 0;
            int zeroInt = (int)deNum;
            Console.WriteLine(num / deNum);//infinity
            Console.WriteLine(deNum / deNum);//NaN
            Console.WriteLine(zeroInt / zeroInt);//DivideByZeroException

            double notCorrect = (double)((1 + 2) / 4);
            Console.WriteLine(notCorrect);//0

            double correct = ((double)(1 + 2)) / 4;
            Console.WriteLine(correct);

            Console.WriteLine("2 + 3 = " + 2 + 3);//23
            Console.WriteLine("2 + 3 = " + (2 + 3));//5

        }
    }
}
