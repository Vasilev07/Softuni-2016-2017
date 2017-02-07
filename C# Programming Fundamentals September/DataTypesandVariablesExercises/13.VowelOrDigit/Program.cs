using System;

class Program
{
    static void Main(string[] args)
    {
        var input = Console.ReadLine();
       if (input == "0" || input == "1" || input == "2" || input == "3" || input == "4" || input == "5" || input == "6" || input == "7" || input == "8" || input == "9")
       {
           Console.WriteLine("digit");
       }
       else
       {
           if (input == "a" || input == "e" || input == "i" || input == "o" || input == "u" || input == "y")
           {
               Console.WriteLine("vowel");
           }
           else
           {
               Console.WriteLine("other");
           }
       }

        //switch (input)
        //{
        //    case "0":
        //    case "2":
        //    case "3":
        //    case "4":
        //    case "5":
        //    case "6":
        //    case "7":
        //    case "8":
        //    case "9": Console.WriteLine("digit");
        //        break;
        //    case "a":
        //    case "e":
        //    case "i":
        //    case "o":
        //    case "u":
        //    case "y":
        //        Console.WriteLine("vowel");
        //        break;
        //    default:
        //        Console.WriteLine("other");
        //        break;
        }
    }
}

