using System;
using System.Threading;

class Menu : Animation
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
  }






