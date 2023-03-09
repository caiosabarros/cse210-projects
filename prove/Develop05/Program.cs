using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
    List<string> goals = new List<string>();
    do
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
            Simple simple = new Simple();
            Console.WriteLine("What's the name of your goal?");
            string goalName = Console.ReadLine();
            string name = simple.SetGoalName(goalName);
            Console.WriteLine("What's a short description of it?");      
            string goalDescription = Console.ReadLine();
            string description = simple.SetGoalDescription(goalDescription);
            goals.Add($"[ ] {name}({description})");
            Console.WriteLine("What's the amount of points you want associated with this goal");
            int pnts = Convert.ToInt32(Console.ReadLine());
            Points pontos = new Points();
            int pnt = pontos.SetPointsRelatedToGoal(pnts);
            //put the following line at the  bottom of each conditional
            Console.WriteLine("");
          } else if (selectedGoalType == 2) {
            Eternal eternal = new Eternal();
            Console.WriteLine("What's the name of your goal?");
            string goalName = Console.ReadLine();
            string name = eternal.SetGoalName(goalName);
            Console.WriteLine("What's a short description of it?");      
            string goalDescription = Console.ReadLine();
            string description = eternal.SetGoalDescription(goalDescription);
            goals.Add($"[ ] {name}({description})");
            Console.WriteLine("What's the amount of points you want associated with this goal");
            int pnts = Convert.ToInt32(Console.ReadLine());
            Points pontos = new Points();
            int pnt = pontos.SetPointsRelatedToGoal(pnts);
          } else if (selectedGoalType == 3) {
            Checklist check = new Checklist();
            Console.WriteLine("What's the name of your goal?");
            string goalName = Console.ReadLine();
            string name = check.SetGoalName(goalName);
            Console.WriteLine("What's a short description of it?");      
            string goalDescription = Console.ReadLine();
            string description = check.SetGoalDescription(goalDescription);
            Console.WriteLine("What's the amount of points you want associated with this goal");
            int pnts = Convert.ToInt32(Console.ReadLine());
            Points pontos = new Points();
            int pnt = pontos.SetPointsRelatedToGoal(pnts);
            Console.WriteLine("How many times does this goal need to be accomplished for a bonus?");
            int quantity = Convert.ToInt32(Console.ReadLine());
            int times = pontos.SetTimesQuantityToGetBonus(quantity);
            Console.WriteLine("What's the bonus for accomplishing it that many times?");
            int bonnus = Convert.ToInt32(Console.ReadLine()); 
            int bonus = pontos.SetBonusRelatedToGoal(bonnus);
            int completed = check.GetCompleted();
            goals.Add($"[ ] {name}({description}) -- Currently completed {completed/times}");
            
            
            
          }
        }
        else if (selected == 2) {
          Console.WriteLine("");
          Console.WriteLine("The goals are:");
          Console.WriteLine("");
          for(int i = 0; i< goals.Count; i++)
          {
            Console.WriteLine($"{i+1}.{goals[i]}");
          }
          Console.WriteLine("");
        } else if (selected == 3) {
          Console.WriteLine("3");
        } else if (selected == 4) {
          Console.WriteLine("4");
        } else if (selected == 5) {
          Console.WriteLine("5");
        } else if (selected == 6) {
          System.Environment.Exit(0);
        } 
      
  } while(true);
  }
}