namespace _02.AdvertisementMessage
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    public class AdvertisementMessage
    {
        public static void Main()
        {
            var phrases = new string[] { "Excellent product.", "Such a great product.",
                "I always use that product.", "I always use that product.","Exceptional product.",
                "I can’t live without this product." };

            var events = new string[] { "Now I feel good.", "I have succeeded with this product.",
                "Makes miracles. I am happy of the results!", "I cannot believe but now I feel awesome.","Try it yourself, I am very satisfied.",
                "I feel great!" };

            var author = new string[] { "Diana", "Petya",
                "Stella", "Stella","Katya",
                "Iva", "Annie", "Eva" };

            var city = new string[] { "Burgas", "Burgas",
                "Plovdiv", "Varna","Ruse" };

            var random = new Random();
            var randomPhrase = phrases[random.Next(0, phrases.Length)];
            var randomEvent = events[random.Next(0, events.Length)];
            var randomAuthor = author[random.Next(0, author.Length)];
            var randomCity = city[random.Next(0, city.Length)];


            Console.WriteLine($"{randomPhrase} {randomEvent} {randomAuthor} - {randomCity}");

        }
    }
}
