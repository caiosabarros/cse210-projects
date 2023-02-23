using System;

class Program
{
    static void Main(string[] args)
    {
        Menu menu = new Menu();
        int selected = menu.DisplayMenu();
        menu.DisplayStartingMessage(selected);

        Console.Write("+");

        System.Threading.Thread.Sleep(500);

        Console.Write("\b \b"); // Erase the + character
        Console.Write("-"); // Replace it with the - character
    }
}
