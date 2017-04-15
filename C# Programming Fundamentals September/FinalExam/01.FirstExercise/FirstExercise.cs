using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.FirstExercise
{
    public class FirstExercise
    {
        public static void Main(string[] args)
        {
            var wingFlaps = int.Parse(Console.ReadLine());
            var distanceInMeters = decimal.Parse(Console.ReadLine());
            var enduranceOfHornet = int.Parse(Console.ReadLine());//rest of the hornet 
            var distance = (wingFlaps / 1000) * distanceInMeters;
            decimal flapsForSecond = wingFlaps / 100;
            var rest = (wingFlaps/enduranceOfHornet) * 5;
         
            Console.WriteLine($"{distance:F2} m.");
            Console.WriteLine($"{(rest+flapsForSecond)} s.");
        }
    }
}
