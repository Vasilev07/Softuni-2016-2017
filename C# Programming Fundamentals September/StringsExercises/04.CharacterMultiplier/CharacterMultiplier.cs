using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.CharacterMultiplier
{
    public class CharacterMultiplier
    {
        public static void Main()
        {
            var input = Console.ReadLine().Split(' ').ToList();

            var firstString = input[0];
            var secondString = input[1];
            Console.WriteLine(CharacterMulti(firstString,secondString));   
        }

        public static int CharacterMulti(string firstString, string secondString)
        {
            var shorterString = Math.Min(firstString.Length, secondString.Length);
            var longerString = Math.Max(firstString.Length, secondString.Length);

            var sum = 0;

            for (int i = 0; i < shorterString; i++)
            {
                sum += firstString[i] * secondString[i];
            }
            
            for (int i = shorterString; i < longerString; i++)
            {
                var currentSum = 0;
                if (firstString.Length < secondString.Length)
                {
                    currentSum += secondString[i];
                    sum += currentSum;
                }
                else
                {
                    currentSum += firstString[i];
                    sum += currentSum;
                }
            }
            return sum;
        }
    }
}
