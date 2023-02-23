using System;

class Menu
{
    private string userInput = "";
    private int intTemp = 0;
    public int DisplayMenu()
    {
        Console.WriteLine("Menu Options:");
        Console.WriteLine("1. Start Breathing Activity");
        Console.WriteLine("2. Start Reflecting Activity");
        Console.WriteLine("3. Start Listing Activity");
        Console.WriteLine("4.Quit");
        Console.WriteLine("Select a choice from the menu:");
        intTemp = Convert.ToInt32(Console.ReadLine());
        return intTemp;
    }

    public void DisplayStartingMessage(int intTemp)
    {
        if(intTemp == 1){
        Console.WriteLine("Welcome to the Breathing Activity");
        Console.WriteLine("");
        Console.WriteLine("This activity will help you relax by walking your through breathing in and out slowly. Clear your mind and focus on your breathing");
        } else if(intTemp == 2)
        {
        Console.WriteLine("Welcome to the Reflecting Activity");
        Console.WriteLine("");
        Console.WriteLine(" This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.");
        } else if(intTemp== 3)
        {
        Console.WriteLine("Welcome to the Listing Activity");
        Console.WriteLine("");
        Console.WriteLine("This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.");
        } else if(intTemp == 4){
            Console.WriteLine("quitted");
        }
    }

    public void DisplayEndingMessage()
    {
        Console.WriteLine();
    }
}
