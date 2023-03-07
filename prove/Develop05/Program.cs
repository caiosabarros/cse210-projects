using System;

class Program
{
    static void Main(string[] args)
    {
        Points points = new Points();
        points.DisplayPoints();
        Console.WriteLine("");
        Menu menu = new Menu();
        menu.DisplayMenu();
        int selected = menu.SelectedFromMenu();

        if (selected == 1) {
          int selectedGoalType = menu.DisplayGoalsTypesMenu();
          if (selectedGoalType == 1) {
            Console.WriteLine("1.1");
          } else if (selectedGoalType == 2) {
            Console.WriteLine("1.2");
          } else if (selectedGoalType == 3) {
            Console.WriteLine("1.3");
          }
        }
        else if (selected == 2) {
          Console.WriteLine("2");
        } else if (selected == 3) {
          Console.WriteLine("3");
        } else if (selected == 4) {
          Console.WriteLine("4");
        } else if (selected == 5) {
          Console.WriteLine("5");
        } else if (selected == 6) {
          System.Environment.Exit(0);
        } 
      
    }  
}