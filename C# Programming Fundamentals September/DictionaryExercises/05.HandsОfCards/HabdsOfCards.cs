namespace _05.HandsОfCards
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class HabdsOfCards
    {
        public static void Main()
        {
            var dict = new Dictionary<string, string>();
            var holder = new Dictionary<string, int>();

            while (true)
            {
                var CardsAndPlayer = Console.ReadLine()
                    .Split(':');

                if (CardsAndPlayer[0] == "JOKER")
                {
                    break;
                }
                foreach (var item in CardsAndPlayer)
                {
                    if (!dict.ContainsKey(item))
                    {
                        dict[item] = CardsAndPlayer[1];
                    }
                    else
                    {
                        dict[item] += CardsAndPlayer[1];
                    }
                }
            }

            foreach (var item in dict)
            {
                var cards = new List<string>();
                cards = item.Value.Split(new[] { ' ', ',' }, StringSplitOptions.RemoveEmptyEntries).Distinct().ToList();
                var sum = 0;
                foreach (var card in cards)
                {
                    sum += CardsValue(card);
                }
                if (!holder.ContainsKey(item.Key))
                {
                    holder[item.Key] = sum;
                }
                else
                {
                    holder[item.Key] += sum;
                }
            }

            foreach (var item in holder)
            {
                Console.WriteLine($"{item.Key}: {item.Value}");
            }
        }

        public static int CardsValue(string input)
        {
            var power = input[0].ToString();
            var type = input[input.Length-1].ToString();
            if (power == "1")
            {
                power = "10";
            }

            var powerAsNumber = 0;
            var typeAsNumber = 0;
            bool realPower = int.TryParse(power, out powerAsNumber);
            
            if (realPower == false)
            {
                switch (power)
                {
                    case "J": powerAsNumber = 11;
                        break;
                    case "Q":
                        powerAsNumber = 12;
                        break;
                    case "K":
                        powerAsNumber = 13;
                        break;
                    case "A":
                        powerAsNumber = 14;
                        break;
                    default:
                        break;
                }
            }
            switch (type)
            {
                case "S": typeAsNumber = 4;
                        break;
                case "H":
                    typeAsNumber = 3;
                    break;
                case "D":
                    typeAsNumber = 2;
                    break;
                case "C":
                    typeAsNumber = 1;
                    break;
                default:
                    break;
            }
            var result = typeAsNumber * powerAsNumber;
            return result;
        }
    }
}
