using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10.EqualWords
{
    class EqualWords
    {
        static void Main(string[] args)
        {
            string word = Console.ReadLine();
            string secondWord = Console.ReadLine();
            word = word.ToLower();
            secondWord = secondWord.ToLower();
            if (word == secondWord)
            {
                Console.WriteLine("yes");
            }
            else
            {
                Console.WriteLine("no");
            }


        }
    }
}
