﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Operators
{
    class Operators
    {
        static void Main(string[] args)
        {
            int someAdding = 7 + 9;
            Console.WriteLine(someAdding);

            string firstName = "John";
            string lastName = "Doe";
            string fullName = firstName + " " + lastName;
            Console.WriteLine(fullName);

            int squarePerimeter = 17;
            double squareSide = squarePerimeter / 4.0;
            double squareArea = squareSide * squareSide;
            Console.WriteLine(squareSide);
            Console.WriteLine(squareArea);

            int a = 5;
            int b = 4;
            Console.WriteLine(a + b);
            Console.WriteLine(a + (b++));
            Console.WriteLine(a + b);
            Console.WriteLine(a + (++b));
            Console.WriteLine(a + b);
            Console.WriteLine(14 / a);
            Console.WriteLine(14 % a);

            int one = 1;
            int zero = 0;
            //Console.WriteLine(one / zero);

            double dMinusOne = -1.0;
            double dZero = 0.0;
            Console.WriteLine(dMinusOne / zero);
            Console.WriteLine(one / dZero);



        }
    }
}