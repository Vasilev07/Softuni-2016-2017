using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09.IndexOfLetters
{
    public class IndexOfLetters
    {
        public static void Main()
        {
            var text = Console.ReadLine();
            for (int i = 0; i < text.Length; i++)
            {
                var current = text[i];
                Console.WriteLine($"{current}" + " " + "->" + " " + $"{current-97}");
            }
                
                
        }
    }
}
