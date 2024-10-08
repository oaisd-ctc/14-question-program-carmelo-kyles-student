using System;

public class program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Hello there and welcome to my 14 question quick quiz. Please answer all of the questions below");

        Console.WriteLine("Enter your name: ");
        string fName = Console.ReadLine();


        Console.WriteLine("Enter your age: ");
        int age = int.Parse(Console.ReadLine());


        Console.WriteLine("Enter your eye color: ");
        string eyeColor = Console.ReadLine();


        Console.WriteLine("Enter your hair color: ");
        string hairColor = Console.ReadLine();


        Console.WriteLine("Enter your shoe size");
        int shoeSize = int.Parse(Console.ReadLine());


        Console.WriteLine("Enter your Favorite color");
        string favColor = Console.ReadLine();


        Console.WriteLine("Enter your Favorite tv show or movie");
        string favShow = Console.ReadLine();


        Console.WriteLine("Enter your Favorite Teacher");
        string favTeacher = Console.ReadLine();


        Console.WriteLine("Enter your Favorite class");
        string favClass = Console.ReadLine();


        Console.WriteLine("Enter your Favorite holiday");
        string favHoliday = Console.ReadLine();


        Console.WriteLine("Enter your Favorite season");
        string favSeason = Console.ReadLine();


        Console.WriteLine("Enter your Dream job");
        string dreamJob = Console.ReadLine();


        Console.WriteLine("How many siblings they have.");
        int siblingCount = int.Parse(Console.ReadLine());

        Console.WriteLine("Ready for the results? Here they are NAME " + fName + " AGE " + age + " Eye color " + eyeColor + " Hair color " + hairColor + " Shoe size " + shoeSize + " Favorite Color " + favColor + " Favorite show " + favShow + " favorite teacher " + favTeacher + " Favorite class " + favClass + " Favorite Holiday " + favHoliday + " Favorite season " + favSeason + " Dream job " + dreamJob + " Age in five years " + (age + 5) + " Sibling count " + siblingCount);



    }
}