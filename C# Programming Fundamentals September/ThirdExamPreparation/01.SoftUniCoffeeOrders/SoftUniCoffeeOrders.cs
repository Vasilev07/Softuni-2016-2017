using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace _01.SoftUniCoffeeOrders
{
    public class SoftUniCoffeeOrders
    {
        public static void Main()
        {
            var orders = int.Parse(Console.ReadLine());
            var result = new List<decimal>();
            decimal totalResult = 0m;
            for (int i = 0; i < orders; i++)
            {
                var pricePerCapsule = decimal.Parse(Console.ReadLine());
                var orderDate = DateTime.ParseExact(Console.ReadLine(), "d/M/yyyy", CultureInfo.InvariantCulture);
                var capsulesCount = long.Parse(Console.ReadLine());
                var daysInMonth = DateTime.DaysInMonth(orderDate.Year, orderDate.Month);
                result.Add((daysInMonth * capsulesCount )* pricePerCapsule);
                totalResult += result[i];
            }
            foreach (var item in result)
            {
                Console.WriteLine($"The price for the coffee is: ${item:F2}");
            }
            
            Console.WriteLine($"Total: ${totalResult:F2}");
        }
    }
}
