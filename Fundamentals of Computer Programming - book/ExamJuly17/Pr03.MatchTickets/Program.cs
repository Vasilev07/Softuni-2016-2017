using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pr03.MatchTickets
{
    class Program
    {
        static void Main(string[] args)
        {

            double budget = double.Parse(Console.ReadLine());
            string typeOfTicket = Console.ReadLine();
            int numberOfFans = int.Parse(Console.ReadLine());

            double ticketPrice = 0;
            double moneyForTransport = 0;

            if (typeOfTicket == "Normal")
            {
                ticketPrice = (249.99 * numberOfFans);

            }
            else if (typeOfTicket == "VIP")
            {
                ticketPrice = (499.99 * numberOfFans);
            }


            if (numberOfFans >= 1 && numberOfFans <= 4)
            {
                moneyForTransport = (budget * 75) / 100;
               

            }
            else if (numberOfFans >= 5 && numberOfFans <= 9)
            {moneyForTransport = (budget * 60) / 100;
               
            }
            else if (numberOfFans >= 10 && numberOfFans <= 24)
            {
                moneyForTransport = (budget * 50) / 100;
              
            }
            else if (numberOfFans >= 25 && numberOfFans <= 49)
            {
                moneyForTransport = (budget * 40) / 100;
               
            }
            else if (numberOfFans >= 50)
            {
                moneyForTransport = (budget * 25) / 100;
                
            }

            double total = moneyForTransport + ticketPrice;

            if (total <= budget)
            {
                Console.WriteLine("Yes! You have {0:F2} leva left.", budget-total);
            }
            else
            {
                Console.WriteLine("Not enough money! You need {0:F2} leva.",total-budget);
            }
         
            
            


        }
    }
}
