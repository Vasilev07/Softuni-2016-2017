using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P03HotelRoom
{
    class Program
    {
        static void Main(string[] args)
        {
            string month = Console.ReadLine();
            int nights = int.Parse(Console.ReadLine());



            if (month == "May" || month == "October")
            {
                if (nights < 7)
                {

                }
                else if (nights >= 7 && nights < 14)
                {

                }
                else if (nights > 14)
                {

                }
            }
            else if (month == "June" || month == "September")
            {
                if (nights < 14)
                {

                }
                else
                {

                }
            }
            else if (month == "July" || month == "August")
            {

            }


            //apartament

            if (month == "May" || month == "October")
            {
                if (nights < 14)
                {

                }
                else
                {

                }
            }
            else if (month == "June" || month == "September")
            {
                if (nights < 14)
                {

                }
                else
                {

                }
            }
            else if (month == "July" || month == "August")
            {
                if (nights < 14)
                {

                }
                else
                {

                }
            }
        }


    }
}
}
