namespace _05.BombNumber
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class BombNumber
    {
        public static void Main(string[] args)
        {
            List<int> seuqnce = Console.ReadLine().Split().Select(int.Parse).ToList();

            string[] intput = Console.ReadLine().Split();

            int number = int.Parse(intput[0]);
            int power = int.Parse(intput[1]);

            for (int i = 0; i < seuqnce.Count; i++)
            {
                if (seuqnce[i] == number)
                {
                    int left = Math.Max(i - power, 0);

                    int right = Math.Min(i + power, seuqnce.Count - 1);

                    int lenght = right - left + 1;
                    seuqnce.RemoveRange(left, lenght);
                    i = 0;
                }
            }
            Console.WriteLine(seuqnce.Sum());
        }
    }
}
