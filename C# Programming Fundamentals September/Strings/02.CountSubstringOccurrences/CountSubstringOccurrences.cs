namespace _02.CountSubstringOccurrences
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    public class CountSubstringOccurrences
    {
        public static void Main()
        {
            var text = Console.ReadLine().ToLower();
            var pattern = Console.ReadLine().ToLower();
            var index = 0;
            var counter = 0;

            while (true)
            {

                var found = text.IndexOf(pattern, index);
                
                if (found >= 0)
                {
                    index = found + 1;
                    counter++;
                }
                else
                {
                    break;
                }
            }
            Console.WriteLine(counter);
        }
    }
}
