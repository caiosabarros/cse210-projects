using System;

class Program
{
    static void Main(string[] args)
    {
        int guess;
        Random randomnumber = new Random(); 
        int magicNumber = randomnumber.Next(1,11);
        do
        {
        //Console.WriteLine(" What is the magic number? ");
        //string userInput = Console.ReadLine();
        //magicNumber = int.Parse(userInput);

        Console.WriteLine(" What is your guess?");
        string userGuess = Console.ReadLine();
        guess = int.Parse(userGuess);

        if(guess < magicNumber){
            Console.WriteLine("Higher");
        } else if (guess > magicNumber) {
            Console.WriteLine("Lower");
        } else if( guess == magicNumber){
            Console.WriteLine("You guessed it!");
        }
        } while (guess != magicNumber);
    }
}