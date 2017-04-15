using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Palindromes
{
    public class Palindromes
    {
        public static void Main()
        {
            var text = Console.ReadLine()
                .Trim()
                .Split(new char[] { ',', '?', '!', ' ', '.' }, StringSplitOptions.RemoveEmptyEntries)
                .ToList();

            var palindrome = new List<string>();
            for (int i = 0; i < text.Count; i++)
            {
                string first = text[i].Substring(0, text[i].Length / 2);
                char[] arr = text[i].ToCharArray();
                Array.Reverse(arr);
                string temp = new string(arr);
                string second = temp.Substring(0, temp.Length / 2);

                if (first.Equals(second))
                {
                    palindrome.Add(text[i]);
                }
            }

            palindrome.Sort();
            var unique = palindrome.Distinct().OrderBy(x => x).ToList();
            Console.WriteLine(string.Join(", ", unique));
        }
    }
}


