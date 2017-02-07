using System;

namespace _04.NumbersInReversedOrder
{
    class Program
    {
        static void Main()
        {
            var inputFromUser = Console.ReadLine();
            Console.WriteLine(ReversedNumber(inputFromUser)); 

        }

        static string ReversedNumber(string inputNumber)
        {
            char[] charArray = inputNumber.ToCharArray();
            Array.Reverse(charArray);
            return new string(charArray);
        }
    }
}
