namespace _06.SumBignumbers
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    public class SumBignumbers
    {
        public static void Main()
        {
            var firstInput = Console.ReadLine().TrimStart(new char[] { '0' });
            var secondInput = Console.ReadLine().TrimStart(new char[] { '0' });
            var sb = new StringBuilder();

            if (firstInput.Length > secondInput.Length)
            {
                secondInput = secondInput.PadLeft(firstInput.Length, '0');
            }
            else if (firstInput.Length < secondInput.Length)
            {
                firstInput = firstInput.PadLeft(secondInput.Length, '0');
            }

            var firstStringToChar = firstInput.ToCharArray();
            var secondStringToChar = secondInput.ToCharArray();

            var remainder = 0;
            var add = 0;

            for (int i = firstInput.Length - 1; i >= 0; i--)
            {
                var firstNum = int.Parse(firstInput[i].ToString());
                var secondNum = int.Parse(secondInput[i].ToString());

                firstNum += add;
                add = 0;

                if (firstNum + secondNum < 10)
                {
                    sb.Append(firstNum + secondNum);
                }
                else
                {
                    remainder = (int)(firstNum + secondNum) % 10;
                    sb.Append(remainder);
                    add = (int)(firstNum + secondNum) / 10;
                }
            }

            if (add != 0)
            {
                sb.Append(add);
            }


            char[] endResult = sb.ToString().ToCharArray();
            Array.Reverse(endResult);

            Console.WriteLine(string.Join("", endResult));
        }
    }
}
