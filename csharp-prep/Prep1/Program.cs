using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("What's your first name?");
        string firstName = Console.ReadLine();
        Console.WriteLine("What's your last name?");
        string lastName = Console.ReadLine();
        Console.WriteLine($"{lastName},{firstName} {lastName}");
    }
}