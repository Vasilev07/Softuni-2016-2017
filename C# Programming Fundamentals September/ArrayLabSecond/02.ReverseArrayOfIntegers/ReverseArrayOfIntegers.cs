using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.ReverseArrayOfIntegers
{
    public class ReverseArrayOfIntegers
    {
        public static void Main()
        {
            var numberOfElements = int.Parse(Console.ReadLine());
            var arrayOfElemets = new int[numberOfElements];
            for (int i = 0; i < numberOfElements; i++)
            {
                var currentElement = int.Parse(Console.ReadLine());
                arrayOfElemets[i] = currentElement;
            }
            
            Console.WriteLine(string.Join(" ", arrayOfElemets.Reverse()));
        }
    }
}
