using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.FourthExercise
{
    public class FourthExercise
    {
        public static void Main()
        {
            var n = int.Parse(Console.ReadLine());
            var legionNameAndSoldierCount = new Dictionary<string, int>();
            var lastActivityAndLegionName = new Dictionary<int, string>();

            for (int i = 1; i <= n + 1; i++)
            {
                if (i <= n)
                {
                    var input = Console.ReadLine()
                                   .Split(new[] { ' ', '=', '>', '-', ':', '\\' }, StringSplitOptions.RemoveEmptyEntries)
                                   .ToList();
                    var legionName = input[1];
                    var soldiersCount = int.Parse(input[3]);
                    var lastActivity = int.Parse(input[0]);
                    if (!legionNameAndSoldierCount.ContainsKey(legionName))
                    {
                        legionNameAndSoldierCount[legionName] = soldiersCount;
                    }
                }
                if (i == n + 1)
                {
                    var lastLine = Console.ReadLine()
                   .Split(new[] { '\\' }, StringSplitOptions.RemoveEmptyEntries)
                   .ToList();
                    
                }
               
            }
           
            foreach (var item in legionNameAndSoldierCount)
            {
                Console.WriteLine($"{item.Key} -> {item.Value}");
            }
        }
    }
}
