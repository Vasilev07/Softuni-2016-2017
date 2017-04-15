using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _03.NetherRealms
{
    public class NetherRealms
    {
        public static void Main()
        {
            var demons = Console.ReadLine()
                .Split(new[] { ' ', ',' }, StringSplitOptions.RemoveEmptyEntries)
                .ToList();

            var demonNameAndHealth = new SortedDictionary<string, List<int>>();
            var demonNameAndDamage = new Dictionary<string, List<decimal>>();
         
            for (int i = 0; i < demons.Count; i++)
            {
                var currentDemon = demons[i];
                var healthRegex = @"[^0-9+\-*\/\.]";
                var healthChars = Regex.Matches(currentDemon, healthRegex);

                if (!demonNameAndHealth.ContainsKey(currentDemon))
                {
                    demonNameAndHealth[currentDemon] = new List<int>();
                }

                foreach (Match match in healthChars)
                {
                    demonNameAndHealth[currentDemon].Add((char.Parse(match.Value)));
                }

                var demonDamagePattern = @"[+-]?\d+(?:\.\d+)?";
                var damageChars = Regex.Matches(currentDemon, demonDamagePattern);

                if (!demonNameAndDamage.ContainsKey(currentDemon))
                {
                    demonNameAndDamage[currentDemon] = new List<decimal>();
                }
                foreach (Match match in damageChars)
                {
                    demonNameAndDamage[currentDemon].Add(decimal.Parse(match.Value));
                }
                
            }
            foreach (var item in demonNameAndHealth)
            {
                var demon = item.Key;
                var modifiers = demon
                      .Where(a => a == '*' || a == '/')
                      .ToArray();
                foreach (var s in demonNameAndDamage)
                {
                    var up = s.Value.Sum();
                    foreach (var modifier in modifiers)
                    {
                        switch (modifier)
                        {
                            case '*':
                                up *= 2;
                                break;
                            case '/':
                                up /= 2;
                                break;
                        }
                    }

                    if (demon == s.Key)
                    { 
                        Console.WriteLine($"{demon} - {item.Value.Sum()} health, {up:F2} damage");
                    }
                }
            }
        }
    }
}