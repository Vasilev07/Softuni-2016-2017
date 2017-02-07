using System;
using System.Numerics;

class Program
{
    static void Main(string[] args)
    {
        var input = BigInteger.Parse(Console.ReadLine());
        if (input > long.MaxValue || input < long.MinValue)
        {
            Console.WriteLine($"{input} can't fit in any type");
        }
        else
        {

        
            if (input < 0)
            {
                if (input >= sbyte.MinValue)
                {
                    Console.WriteLine($"{input} can fit in:");
                    Console.WriteLine("* sbyte");
                    Console.WriteLine("* short");
                    Console.WriteLine("* int");
                    Console.WriteLine("* long");

                }
                else if (input >= short.MinValue && input <= sbyte.MinValue)
                {
                    Console.WriteLine($"{input} can fit in:");
                    Console.WriteLine("* short");
                    Console.WriteLine("* int");
                    Console.WriteLine("* long");

                }
                else if (input >= int.MinValue)
                {
                    Console.WriteLine("* int");
                    Console.WriteLine("* long");

                }
                else if (input >= long.MinValue && input < 0)
                {
                    Console.WriteLine($"{input} can fit in:");
                    Console.WriteLine("* long");
                }

            }
            else if (input > 0)
            {
                if (input <= sbyte.MaxValue)
                {
                    Console.WriteLine($"{input} can fit in:");
                    Console.WriteLine("* sbyte");
                    Console.WriteLine("* byte");
                    Console.WriteLine("* short");
                    Console.WriteLine("* ushort");
                    Console.WriteLine("* int");
                    Console.WriteLine("* uint");
                    Console.WriteLine("* long");
                }
                else if (input > sbyte.MaxValue && input <= byte.MaxValue)
                {
                    Console.WriteLine($"{input} can fit in:");
                    Console.WriteLine("* byte");
                    Console.WriteLine("* short");
                    Console.WriteLine("* ushort");
                    Console.WriteLine("* int");
                    Console.WriteLine("* uint");
                    Console.WriteLine("* long");
                }
                else if (input > byte.MaxValue && input <= short.MaxValue)
                {
                    Console.WriteLine($"{input} can fit in:");
                    Console.WriteLine("* short");
                    Console.WriteLine("* ushort");
                    Console.WriteLine("* int");
                    Console.WriteLine("* uint");
                    Console.WriteLine("* long");
                }
                else if (input > short.MaxValue && input <= ushort.MaxValue)
                {
                    Console.WriteLine($"{input} can fit in:");
                    Console.WriteLine("* ushort");
                    Console.WriteLine("* int");
                    Console.WriteLine("* uint");
                    Console.WriteLine("* long");
                }
                else if (input > ushort.MaxValue && input <= int.MaxValue)
                {
                    Console.WriteLine($"{input} can fit in:");
                    Console.WriteLine("* int");
                    Console.WriteLine("* uint");
                    Console.WriteLine("* long");
                }
                else if (input > int.MaxValue && input <= uint.MaxValue)
                {
                    Console.WriteLine($"{input} can fit in:");
                    Console.WriteLine("* uint");
                    Console.WriteLine("* long");
                }
                else if (input > uint.MaxValue && input <= long.MaxValue)
                {
                    Console.WriteLine($"{input} can fit in:");
                    Console.WriteLine("* long");
                }
            }
            else if (input == 0)
            {
                Console.WriteLine($"{input} can fit in:");
                Console.WriteLine("* sbyte");
                Console.WriteLine("* byte");
                Console.WriteLine("* short");
                Console.WriteLine("* ushort");
                Console.WriteLine("* int");
                Console.WriteLine("* uint");
                Console.WriteLine("* long");
            }
            
        }
    }
}


