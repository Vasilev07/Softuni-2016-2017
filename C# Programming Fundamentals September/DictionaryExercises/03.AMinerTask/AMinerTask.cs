namespace _03.AMinerTask
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class AMinerTask
    {
        public static void Main()
        {
            var dict = new Dictionary<string, int>();
            var input = Console.ReadLine();
            var counter = 1;
            var quantity = 0;
            if (input == "stop")
            {
                return;
            }
            do
            {
                if (counter % 2 == 0)
                {
                    input = Console.ReadLine();
                }
                else
                {
                    quantity = int.Parse(Console.ReadLine());
                }

                if (!dict.ContainsKey(input))
                {
                    dict[input] = quantity;
                }
                else
                {
                    dict[input] += quantity;
                }
                counter++;
                quantity = 0;

            } while (input != "stop");

            foreach (var item in dict)
            {
                if (item.Key == "stop")
                {
                    break;
                }
                else
                {
                    Console.WriteLine($"{item.Key} -> {item.Value}");
                }
              
            }
        }

    }
}

