using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11.CharacterLiterals
{
    class CharacterLiterals
    {
        static void Main(string[] args)
        {
            char ordinaryChar = 'a';
            Console.WriteLine(ordinaryChar);
            char hexChar = '\u003A';
            Console.WriteLine(hexChar);
            char singleQuoteEscape = '\'';
            Console.WriteLine(singleQuoteEscape);
            char backslashEscape = '\\';
            Console.WriteLine(backslashEscape);


        }
    }
}
