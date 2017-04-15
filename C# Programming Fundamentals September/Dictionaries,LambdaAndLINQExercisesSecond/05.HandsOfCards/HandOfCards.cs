using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.HandsOfCards
{
    public class HandOfCards
    {
        public static void Main()
        {
            var resultDict = new Dictionary<string, int>();
            var infoHodler = new Dictionary<string, string>();
            while (true)
            {
                var currentLine = Console.ReadLine()
                    .Split(new char[] { ':' }, StringSplitOptions.RemoveEmptyEntries)
                    .ToList();

                var name = currentLine[0];
                if (name == "JOKER")
                {
                    break;
                }

                if (!infoHodler.ContainsKey(name))
                {
                    infoHodler[name] = currentLine[1];
                }
                else
                {
                    infoHodler[name] += currentLine[1];
                }
            }
            foreach (var card in infoHodler)
            {
                var sum = 0;
                var listOfCards = card.Value.Split(new char[] { ' ', ',' }, StringSplitOptions.RemoveEmptyEntries).Distinct().ToList();
                foreach (var item in listOfCards)
                {
                    sum += powerOfCards(item);
                }
                if (resultDict.ContainsKey(card.Key))
                {
                    resultDict[card.Key] += sum;
                }
                else
                {
                    resultDict.Add(card.Key, sum);
                }
            }

            foreach (var item in resultDict)
            {
                Console.WriteLine($"{item.Key}: {item.Value}");
            }
        }
        public static int powerOfCards(string card)
        {
            var power = 0;
            var playerCard = card.First().ToString();
            var type = card.Last().ToString();
            switch (playerCard)
            {
                case "2":
                    power = 2;
                    break;
                case "3":
                    power = 3;
                    break;
                case "4":
                    power = 4;
                    break;
                case "5":
                    power = 5;
                    break;
                case "6":
                    power = 6;
                    break;
                case "7":
                    power = 7;
                    break;
                case "8":
                    power = 8;
                    break;
                case "9":
                    power = 9;
                    break;
                case "10":
                    power = 10;
                    break;
                case "J":
                    power = 11;
                    break;
                case "Q":
                    power = 12;
                    break;
                case "K":
                    power = 13;
                    break;
                case "A":
                    power = 14;
                    break;
            }
            switch (type)
            {
                case "S":
                    power *= 4;
                    break;
                case "H":
                    power *= 3;
                    break;
                case "D":
                    power *= 2;
                    break;
                case "C":
                    power *= 1;
                    break;
            }
            return power;
        }
    }
}
