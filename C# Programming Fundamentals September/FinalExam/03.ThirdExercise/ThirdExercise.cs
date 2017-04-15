using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.ThirdExercise
{
    public class ThirdExercise
    {
        public static void Main()
        {
            var beeHives = Console.ReadLine()
                .Split()
                .Select(long.Parse)
                .ToList();

            var hornets = Console.ReadLine()
                .Split()
                .Select(long.Parse)
                .ToList();

           
            for (int i = 0; i < beeHives.Count; i++)
            {
                var hornetsPower = hornets.Sum();
                var currentBeeHive = beeHives[i];
               
                if (currentBeeHive >= hornetsPower)
                {
                     hornets.Remove(hornets.First());
                }
                else
                {
                    
                }
            }
            Console.WriteLine(string.Join(" ", hornets));
          
        }
    }
}
