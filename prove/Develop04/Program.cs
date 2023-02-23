using System;

class Program
{
    static void Main(string[] args)
    {
        Menu menu = new Menu();
        int selected =menu.DisplayMenu();
        menu.DisplayStartingMessage(selected);
    }
}
