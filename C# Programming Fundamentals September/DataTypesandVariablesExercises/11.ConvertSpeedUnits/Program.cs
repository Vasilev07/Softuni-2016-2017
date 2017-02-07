using System;

class Program
{
    static void Main(string[] args)
    {
        var distanceInMeters = int.Parse(Console.ReadLine());
        var hours = int.Parse(Console.ReadLine());
        var minutes = int.Parse(Console.ReadLine());
        var seconds = int.Parse(Console.ReadLine());

        //first line output - m/s
        //second line output - km/h
        //third line output -mph

        float timeInSec = (hours * 3600f) + (minutes * 60f) + seconds;
        float timeInHours = hours + (minutes / 60f) + (seconds / 3600f);

        //distance in KM
        float distanceInKilometers = distanceInMeters / 1000f;

        //distance in MP
        float distanceInMile = distanceInMeters / 1609f;

        //output

        // --m/s
        Console.WriteLine("{0}", distanceInMeters / timeInSec);

        // --km/h
        Console.WriteLine("{0}", distanceInKilometers / timeInHours);

        // --mph
        Console.WriteLine("{0}", distanceInMile / timeInHours);



    }
}

