using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12.MasterNumbers
{
    class Program
    {
        static void Main()
        {
            var myString = Console.ReadLine();
            Console.WriteLine(IsPalindrome(myString)); 

        }
        private static bool IsPalindrome(string myString)
        {
            
            var charArray = myString.ToCharArray();
            

            for (int i = 0; i < myString.Length/2; i++)
            {
                if (myString[i] != myString[charArray.Length-i-1])
                {
                    return false;
                }
            }
            return true;
           
        }

        private static int SumOfDigits(int myString)
        {
            return 1;
        }
        private static int ContainsEvenDigit(int myString)
        {
            return 1;
        }


    }
}
