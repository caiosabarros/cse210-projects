using System;

class Program
{
    static void Main(string[] args)
    {
        string letter = "";
        Console.WriteLine("What's your grade percentage?");
        string userInput = Console.ReadLine();
        int number = int.Parse(userInput);
    
//A >= 90
//B >= 80
//C >= 70
//D >= 60
//F < 60

    if (number >= 90 ) {
        letter = "A";
        Console.WriteLine("your grade percentage is B");
    } else if (number >= 80) 
    {
        letter = "C";
        Console.WriteLine("your grade percentage is C");
    } else if (number >= 70) {
        letter = "D";
        Console.WriteLine("your grade percentage is D");
    } else if (number >= 60) {
        letter = "E";
        Console.WriteLine("your grade percentage is E");
    } else if (number < 60) {
        letter = "F";
        Console.WriteLine("your grade percentage is F");
    } 

    if(number < 70){
        Console.WriteLine("Failed :(. Try next time");
    } else {
        Console.WriteLine("Congrats! You passed!");
    }

    }
}