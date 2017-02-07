using System;

class Program
{
    static void Main()
    {
        int input = int.Parse(Console.ReadLine());
        for (int DAVIDIM = 2; DAVIDIM <= input; DAVIDIM++)
{

            bool TowaLIE = true;

            for (int delio = 2; delio <= Math.Sqrt(DAVIDIM); delio++)

{

                if (DAVIDIM % delio == 0)

                {

                    TowaLIE = false;

                    break;

                }

            }

            Console.WriteLine($"{DAVIDIM} -> {TowaLIE}");

        }

    }
}
