namespace _03.LastKNumbersSumsSequence
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class LastKNumbers
    {
        public static void Main()
        {
            int lenghtOfSequence = int.Parse(Console.ReadLine());
            int formingPreviousElements = int.Parse(Console.ReadLine());
            var sequenceHolder = new long[lenghtOfSequence];
            sequenceHolder[0] = 1;
            //var holder = new int[lenghtOfSequence];
            long sum = 1;
            for (int i = 1; i < sequenceHolder.Length; i++)
            {
                for (int j = i- formingPreviousElements; j < i-1; j++)
                {
                    if (j >= 0)
                    {
                        sum += sequenceHolder[j];
                    }
                    sequenceHolder[i] = sum;
                }
            }

            Console.WriteLine(string.Join(" ", sequenceHolder));


            
        }
    }
}
