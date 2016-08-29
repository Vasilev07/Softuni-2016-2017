using System;


namespace TriangleOf55Stars
{
    class TriangleOf55Stars
    {
        static void Main()
        {
            //Console.WriteLine("*");
            //Console.WriteLine("**");
            // Console.WriteLine("***");
            // Console.WriteLine("****");
            // Console.WriteLine("*****");
            // Console.WriteLine("******");
            // Console.WriteLine("*******");
            // Console.WriteLine("********");
            // Console.WriteLine("*********");
            // Console.WriteLine("**********");

            //for (int i = 1; i <= 10; i++)
            //{
            //    for (int n = 1; n <= i; n++)
            //    {
            //        Console.Write("*");
            //    }
            //    Console.WriteLine();
            //}
            for (int i = 1; i <= 10; i++)
            {
               var line=  new String('*', i);
                Console.WriteLine(line);
            }
        }
    }
}
