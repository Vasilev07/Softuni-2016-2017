namespace _02.RandomizeWords
{
    using System;
    using System.Linq;

    public class RandomizeWords
    {
        public static void Main()
        {
            var text = Console.ReadLine()
                .Split(' ');

            for (int i = 0; i < text.Length; i++)
            {
                var random = new Random();
                var randomText = (text.Next(i,text.Length));
            }
        }
    }
}
