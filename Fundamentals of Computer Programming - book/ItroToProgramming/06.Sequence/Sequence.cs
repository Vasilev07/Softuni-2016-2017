﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.Sequence
{
    class Sequence
    {
        static void Main(string[] args)
        {
            //print first 100 members of the sequence 2, -3 ,4 ,-5 , 6 , -7, 8, -9
            for (int i = 2; i <= 100; i++)
            {
                if(i % 2 != 0)
                {
                    Console.WriteLine(-i);
                }
                else
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}
