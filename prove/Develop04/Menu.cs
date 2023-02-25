using System;
using System.Threading;

class Menu 
{
    private string userInput = "";
    private int intTemp = 0;
    private int _seconds;
    public Menu()
    {
      _seconds = 0;
    }
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
        Console.WriteLine("");
        Console.WriteLine("How long, in seconds, would you like for this activity?");
        } else if(intTemp == 2)
        {
        Console.WriteLine("Welcome to the Reflecting Activity");
        Console.WriteLine("");
        Console.WriteLine(" This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.");
        Console.WriteLine("");
        Console.WriteLine("How long, in seconds, would you like for this activity?");
        } else if(intTemp== 3)
        {
        Console.WriteLine("Welcome to the Listing Activity");
        Console.WriteLine("");
        Console.WriteLine("This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.");
          Console.WriteLine("");
        Console.WriteLine("How long, in seconds, would you like for this activity?");
        } else if(intTemp == 4){
            Console.WriteLine("quitted");
        }
    }

    public void DisplayEndingMessage()
    {
        Console.WriteLine();
    }

    public void setSeconds(int seconds)
    {
      _seconds = seconds;
    }

  
    public void DisplayAnimation()
    {
        var spinner = new[] { '|', '/', '-', '\\' };
        var index = 0;
        var count = 30;
        while (count >= 1) {
            Console.Write(spinner[index]);
            index = (index + 1) % spinner.Length;
            Console.SetCursorPosition(Console.CursorLeft - 1,
              Console.CursorTop);
            System.Threading.Thread.Sleep(100);
            count--;
        }
    }
    public void DisplayEntrance()
    {
      Console.WriteLine("Get ready...");
      Console.WriteLine("");
      Console.WriteLine("Breath in...");
      for (int i=5; i>=1; i--)
      {
      Console.Write(i);
      Thread.Sleep(100);
      Console.Write("⧵b ⧵b");  
      }
      //other loop
      Console.WriteLine("Breath out..."); 
    }
}