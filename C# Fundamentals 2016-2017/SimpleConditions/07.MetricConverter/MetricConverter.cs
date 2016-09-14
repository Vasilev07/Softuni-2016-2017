using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07.MetricConverter
{
    class MetricConverter
    {
        static void Main(string[] args)
        {
            double lenght = double.Parse(Console.ReadLine());
            string inputLenght = Console.ReadLine();
            string outputLenght = Console.ReadLine();

            double lenghtInMeters = lenght;
            if (inputLenght == "mm")
            {
                lenghtInMeters = lenght / 1000;
            }
            else if (inputLenght == "cm")
            {
                lenghtInMeters = lenght / 100;
            }
            else if (inputLenght == "m")
            {
                lenghtInMeters = lenght / 1;
            }
            else if (inputLenght == "mi")
            {
                lenghtInMeters = lenght / 0.000621371192;
            }
            else if (inputLenght == "in")
            {
                lenghtInMeters = lenght / 39.3700787;
            }
            else if (inputLenght == "km")
            {
                lenghtInMeters = lenght / 0.001;
            }
            else if (inputLenght == "ft")
            {
                lenghtInMeters = lenght / 3.2808399;
            }
            else if (inputLenght == "yd")
            {
                lenghtInMeters = lenght / 1.0936133;
            }

           double output = 0.0;
           if (outputLenght == "mm")
           {
               output = lenghtInMeters * 1000;
           }
           else if (outputLenght == "cm")
           {
               output = lenghtInMeters * 100;
           }
           else if (outputLenght == "m")
           {
               output = lenghtInMeters * 1;
           }
           else if (outputLenght == "mi")
           {
               output = lenghtInMeters * 0.000621371192;
           }
           else if (outputLenght == "in")
           {
               output = lenghtInMeters * 39.3700787;
           }
           else if (outputLenght == "km")
           {
               output = lenghtInMeters * 0.001;
           }
           else if (outputLenght == "ft")
           {
               output = lenghtInMeters * 3.2808399;
           }
           else if (outputLenght == "yd")
           {
               output = lenghtInMeters * 1.0936133;
           }
           

            Console.WriteLine("{0} {1}", output, outputLenght);
        }

    }
}

