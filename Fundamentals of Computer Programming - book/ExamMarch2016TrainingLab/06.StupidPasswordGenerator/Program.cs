using System;

class StupidPasswordGenerator
{
    static void Main()
    {
        var n = int.Parse(Console.ReadLine());
        var l = int.Parse(Console.ReadLine());
        for (var n1 = 1; n1 <= n; n1++)
        {
            for (var n2 = 1; n2 <= n; n2++)
            {
                for (var c1 = 'a'; c1 < 'a' + l; c1++)
                {
                    for (var c2 = 'a'; c2 < 'a' + l; c2++)
                    {
                        for (var n3 = Math.Max(n1,n2) +1; n3 <= n; n3++)
                        {
                            Console.Write("{0}{1}{2}{3}{4} ",
                                 n1, n2, c1, c2, n3);
                        }
                    }
                }
            }
        }
        Console.WriteLine();
    }
}