﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.ExcellentResult
{
    class ExcellentResult
    {
        static void Main(string[] args)
        {
            double mark = double.Parse(Console.ReadLine());
            if (mark >= 5.50)
            {
                Console.WriteLine("Excellent!");
            }
            
        }
    }
}
