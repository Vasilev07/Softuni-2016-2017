using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.UnicodeCharacters
{
    public class UnicodeCharacters
    {
        public static void Main()
        {
            var text = Console.ReadLine();

            for (int i = 0; i < text.Length; i++)
            {
                var currentCharacter = "\\u" + (((int)text[i]).ToString("X4"));

                Console.Write(currentCharacter.ToLower());
            }
            Console.WriteLine();
        }
    }
}
