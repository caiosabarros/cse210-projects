using System;

class Program 
{
    static void Main(string[] args)
    {
        Menu menu = new Menu();
        int selected = menu.DisplayMenu();
        menu.DisplayStartingMessage(selected);
        string seconds = Console.ReadLine();
        int intSeconds = Convert.ToInt32(seconds);
        menu.setSeconds(intSeconds);
        Console.Clear();
        menu.DisplayAnimation();
        menu.DisplayEntrance();
        System.Threading.Thread.Sleep(1000);
    }
}
