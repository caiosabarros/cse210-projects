using System;

class Menu
{
    private int _selected = 0; 
    int goalType = 0;
    public int SelectedFromMenu(){
    Console.WriteLine("Select a choice from the menu:");
    _selected = Convert.ToInt32(Console.ReadLine());
    return _selected;
    }

    public void DisplayMenu()
    {
    Console.WriteLine("Menu Options:");
    Console.WriteLine("1. Create New Goal");
    Console.WriteLine("2. List Goals");
    Console.WriteLine("3. Save Goals");
    Console.WriteLine("4. Load Goals");
    Console.WriteLine("5. Record Event");
    Console.WriteLine("6. Quit");
    }

    public int DisplayGoalsTypesMenu(){
    Console.WriteLine("The types of Goals are:");
    Console.WriteLine("1. Simple Goal");
    Console.WriteLine("2. Eternal Goal");
    Console.WriteLine("3. Checklist Goal");
    Console.WriteLine("");
    Console.WriteLine("Which type of goal would you like to create?");
    goalType = Convert.ToInt32(Console.ReadLine());
    return goalType;
    }
}