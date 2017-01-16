using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pr03.Transport
{
    class Program
    {
        static void Main(string[] args)
        {
            int oldPeople = int.Parse(Console.ReadLine());
            int students = int.Parse(Console.ReadLine());
            int nights = int.Parse(Console.ReadLine());
            string transport = Console.ReadLine();
           
            
            double transportOld = 0.0;
            double transportStud = 0.0;
            double totalTransport=0.0;
            if(transport == "train")
            {
                if (oldPeople > 0)
                {
                    transportOld = (oldPeople * 24.99);
                }
                if (students > 0)
                {
                    transportStud = (students * 14.99) ;
                }
                if ((students + oldPeople) >= 50)
                {
                    totalTransport= (transportStud + transportOld)/2;
                }
                else
                {
                    totalTransport = transportOld + transportStud;
                }
               
            }
            else if (transport == "bus")
            {
                if (oldPeople > 0)
                {
                    transportOld = (oldPeople * 32.5);
                }
                if (students > 0)
                {
                    transportStud = (students * 28.5);
                }
                totalTransport = transportOld + transportStud;
            }
            else if (transport == "boat")
            {
                if (oldPeople > 0)
                {
                    transportOld = (oldPeople * 42.99);
                }
                if (students > 0)
                {
                    transportStud = (students * 39.99);
                }
                totalTransport = transportOld + transportStud;
            }
            else if (transport == "airplane")
            {
                if (oldPeople > 0)
                {
                    transportOld = (oldPeople * 70.00);
                }
                if (students > 0)
                {
                    transportStud = (students * 50.00);
                }
                totalTransport = transportOld + transportStud;
            }
            double priceHotel = nights * 82.99;
            double commision = ((totalTransport*2) + priceHotel) * 0.1;
            double totalSum = ((totalTransport*2) + commision + priceHotel);
           
            Console.WriteLine("{0:F2}", totalSum);

        }
    }
}
