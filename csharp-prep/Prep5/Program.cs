using System;

class Program
{
    static void Main(string[] args)
    {
        DisplayWelcome();
        string userName = PromptUserName();
        int userNumber = PromptUserNumber();
        int squaredd = SquareNumber(userNumber);
        DisplayResult(userName, squaredd);
    }
//DisplayWelcome - Displays the message, "Welcome to the Program!"
    static void DisplayWelcome() {
        Console.WriteLine("Welcome to the Program!");
    }
//PromptUserName - Asks for and returns the user's name (as a string)
    static string PromptUserName(){
        Console.WriteLine("Please enter your name:");
        string username = Console.ReadLine();
        return username;
    } 
//PromptUserNumber - Asks for and returns the user's favorite number (as an integer)
    static int PromptUserNumber(){
        Console.WriteLine("Please enter your favorite number:");
        string favNumber = Console.ReadLine();
        int intfavNumber = int.Parse(favNumber);
        Console.WriteLine($"{intfavNumber}");
        return intfavNumber;
    }
//SquareNumber - Accepts an integer as a parameter and returns that number squared (as an integer)
    static int SquareNumber(int number){
        int squared = number * number;
        return squared;
    } 
//DisplayResult - Accepts the user's name and the squared number and displays them.
    static void DisplayResult(string username, int usernumber){
        Console.WriteLine($"number squared: {usernumber} of [{username}]");
    } 

}
