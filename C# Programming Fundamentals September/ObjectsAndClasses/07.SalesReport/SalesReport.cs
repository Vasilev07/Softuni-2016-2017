namespace _07.SalesReport
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class SalesReport
    {
        public static void Main()
        {
            var n = int.Parse(Console.ReadLine());
            var holder = new SortedDictionary<string, decimal>();

            for (int i = 0; i < n; i++)
            {
                var input = Console.ReadLine()
                    .Split(' ')
                    .ToList();

                var currentSale = new Sale
                {
                    Town = input[0],
                    Product = input[1],
                    Price = decimal.Parse(input[2]),
                    Quantity = decimal.Parse(input[3])
                };
                if (!holder.ContainsKey(currentSale.Town))
                {
                    holder[currentSale.Town] = currentSale.TotalPrice;
                }
                else
                {
                    holder[currentSale.Town] += currentSale.TotalPrice;
                }
            }

            foreach (var item in holder)
            {
                Console.WriteLine($"{item.Key} -> {item.Value:f2}");
            }
        }
    }
    public class Sale
    {
        public string Town { get; set; }

        public string Product { get; set; }

        public decimal Price { get; set; }

        public decimal Quantity { get; set; }

        public decimal TotalPrice => Price * Quantity;
    }

}
