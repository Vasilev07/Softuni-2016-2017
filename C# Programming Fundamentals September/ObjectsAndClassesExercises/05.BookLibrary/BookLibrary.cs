namespace _05.BookLibrary
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class BookLibrary
    {
        public static void Main()
        {
            var n = int.Parse(Console.ReadLine());
            var books = new List<Books>();
            for (int i = 0; i < n; i++)
            {
                var currentBookInfo = Console.ReadLine()
                    .Split(' ')
                    .ToList();

                var bookInfo = new Books
                {
                    Title = currentBookInfo[0],
                    Author = currentBookInfo[1],
                    Publisher = currentBookInfo[2],
                    ReleaseDate = currentBookInfo[3],
                    ISBN = currentBookInfo[4],
                    Price = double.Parse(currentBookInfo[5])
                };

                books.Add(bookInfo);
            }

            var grouped = books.GroupBy(x => x.Author).ToList();
            var result = grouped.Select(x => new Library
            {
                Name = x.Key,
                Books = x.ToList()
            }).ToArray();

            foreach (var item in result)
            {
                Console.WriteLine($"{item.Name} -> {item.Books.Sum(x => x.Price):F2}");
            }
            Console.WriteLine();

        }
    }
}
