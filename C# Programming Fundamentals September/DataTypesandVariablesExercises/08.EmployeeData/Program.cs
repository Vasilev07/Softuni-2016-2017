using System;



class Program
{
    static void Main(string[] args)
    {
        string firstName = Console.ReadLine();
        string lastName = Console.ReadLine();
        var age = int.Parse(Console.ReadLine());
        var gender = char.Parse(Console.ReadLine());
        var personalId = long.Parse(Console.ReadLine());
        var employeeNumber = long.Parse(Console.ReadLine());

        Console.WriteLine($"First name: {firstName}");
        Console.WriteLine($"Last name: {lastName}");
        Console.WriteLine($"Age: {age}");
        Console.WriteLine($"Gender: {gender}");
        Console.WriteLine($"Personal ID: {personalId}");
        Console.WriteLine($"Unique Employee number: {employeeNumber}");





    }
}

