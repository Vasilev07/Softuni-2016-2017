using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.SplitByWordCasing
{
    public class SplitByWordCasing
    {
        public static void Main()
        {
            var separator = new char[] { ',', ';', ':', '.', '!', '(', ')', '\\', '\'', '\\', '/', '[', ']', ' ' };
            var text = Console.ReadLine()
                .Split(separator, StringSplitOptions.RemoveEmptyEntries)
                .ToList();

            var lowerCase = new List<string>();
            var mixedCase = new List<string>();
            var upperCase = new List<string>();
            foreach (var item in text)
            {
                
                    var currentWord = item;
                    if (currentWord.All(l => char.IsUpper(l)))
                    {
                        upperCase.Add(currentWord);
                    }
                    else if (currentWord.All(l => char.IsLower(l)))
                    {
                        lowerCase.Add(currentWord);
                    }
                    else
                    {
                        mixedCase.Add(currentWord);
                    }
                
            }
            


            Console.WriteLine("Lower-case: {0}", string.Join(", ", lowerCase));
            Console.WriteLine("Mixed-case: {0}", string.Join(", ", mixedCase));
            Console.WriteLine("Upper-case: {0}", string.Join(", ", upperCase));
        }
    }
}
