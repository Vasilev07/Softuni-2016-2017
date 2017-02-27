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
            var random = new Random();

            for (int i = 0; i < text.Length; i++)
            {
                var current = text[i];
                var randomIndex = random.Next(0, text.Length-1);
                var tempWord = text[randomIndex];
                text[i] = tempWord;
                text[randomIndex] = current;
            }

            foreach (var item in text)
            {
                Console.WriteLine(item);
            }
        }
    }
}
