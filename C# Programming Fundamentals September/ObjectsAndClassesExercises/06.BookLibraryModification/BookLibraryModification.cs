using System;
using System.Collections.Generic;
using System.Linq;
using System.Globalization;
using System.Text;
using System.Threading.Tasks;

namespace _06.BookLibraryModification
{
    public class BookLibraryModification
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
                    ReleaseDate = DateTime.ParseExact(currentBookInfo[3], "dd.MM.yyyy", CultureInfo.InvariantCulture),
                    ISBN = currentBookInfo[4],
                    Price = double.Parse(currentBookInfo[5])
                };

                books.Add(bookInfo);
            }

            var grouped = books.GroupBy(x => x.Title).ToList();
            var result = grouped.Select(x => new Library
            {
                Name = x.Key,
                Books = x.ToList()
            }).ToArray();

            var releaseDate = DateTime.ParseExact(Console.ReadLine(), "dd.MM.yyyy", CultureInfo.InvariantCulture);

            foreach (var item in result)
            {
                foreach (var time in item.Books.Select(x => x.ReleaseDate))
                {
                    if (time > releaseDate)
                    {
                        Console.WriteLine($"{item.Name} {time.ToString("dd-MM-yyyy")}");
                    }
                }
            }
            Console.WriteLine();
        }
    }
}
