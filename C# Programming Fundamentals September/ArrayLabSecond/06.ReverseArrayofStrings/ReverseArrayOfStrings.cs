using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.ReverseArrayofStrings
{
    public class ReverseArrayOfStrings
    {
        public static void Main()
        {
            var array = Console.ReadLine()
                .Split()
                .ToArray();

            
            Console.WriteLine(string.Join(" ", array.Reverse()));
                
        }
    }
}
