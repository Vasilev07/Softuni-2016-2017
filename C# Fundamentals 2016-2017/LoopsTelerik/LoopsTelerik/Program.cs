using System;


namespace LoopsTelerik
{
    class Program
    {
        static void Main(string[] args)
        {
            var counter = 1;
            var input = int.Parse(Console.ReadLine());
            for (int i = counter; i <= input; i++)
            {
                Console.Write(i + " ");
                
            }
            Console.WriteLine();
        }
    }
}
