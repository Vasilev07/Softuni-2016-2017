namespace _03.TextFilter
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    public class TextFilter
    {
        public static void Main()
        {
            var bannedWords = Console.ReadLine().Split(new char[] { ',', ' ' }, StringSplitOptions.RemoveEmptyEntries).ToArray();
            var text = Console.ReadLine();

            for (int i = 0; i < bannedWords.Length; i++)
            {
                text = text.Replace(bannedWords[i], new string('*', bannedWords[i].Length));
            }
            

            Console.WriteLine(text);
           
        }
    }
}
