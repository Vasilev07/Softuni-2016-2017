using System;


namespace PrintDeck
{
    class Program
    {
        static void Main()
        {
            string card = Console.ReadLine();
            int lenght = 0;
            switch (card)
            {
                case "J":
                    lenght = 11;
                    break;
                case "Q":
                    lenght = 12;
                    break;
                case "K":
                    lenght = 13;
                    break;
                case "A":
                    lenght = 14;
                    break;
            }

        }
    }
}
