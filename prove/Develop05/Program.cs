using System;
using System.Collections.Generic;
using System.IO;

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
            //string goalType;
            if (selected == 1)
            {
                int selectedGoalType = menu.DisplayGoalsTypesMenu();
                if (selectedGoalType == 1)
                {
                    Simple simple = new Simple();
                    Console.WriteLine("What's the name of your goal?");
                    string goalName = Console.ReadLine();
                    string name = simple.SetGoalName(goalName);
                    Console.WriteLine("What's a short description of it?");
                    string goalDescription = Console.ReadLine();
                    string description = simple.SetGoalDescription(goalDescription);
                    Console.WriteLine("What's the amount of points you want associated with this goal");
                    int pnts = Convert.ToInt32(Console.ReadLine());
                    Points pontos = new Points();
                    int pnt = pontos.SetPointsRelatedToGoal(pnts);
                    goals.Add($"Simple: [ ] {name}({description}):{pnt.ToString()}");
                    //put the following line at the  bottom of each conditional
                    Console.WriteLine("");
                }
                else if (selectedGoalType == 2)
                {
                    Eternal eternal = new Eternal();
                    Console.WriteLine("What's the name of your goal?");
                    string goalName = Console.ReadLine();
                    string name = eternal.SetGoalName(goalName);
                    Console.WriteLine("Eternal: What's a short description of it?");
                    string goalDescription = Console.ReadLine();
                    string description = eternal.SetGoalDescription(goalDescription);
                    goals.Add($"[ ] {name}({description})");
                    Console.WriteLine("What's the amount of points you want associated with this goal");
                    int pnts = Convert.ToInt32(Console.ReadLine());
                    Points pontos = new Points();
                    int pnt = pontos.SetPointsRelatedToGoal(pnts);
                }
                else if (selectedGoalType == 3)
                {
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
                    goals.Add($"Checklist: [ ] {name}({description}) -- Currently completed {completed}/{times}:{points.ToString()}:{bonus.ToString()}");
                }
            }
            else if (selected == 2)
            {
                Console.WriteLine("");
                Console.WriteLine("The goals are:");
                Console.WriteLine("");
                foreach (var line in goals)
                {
                    string[] parts = line.Split(":");
                    string goalType = parts[0];
                    string goalItself = parts[1];
                    Console.WriteLine($"{goalItself}");
                }
                Console.WriteLine("");
            }
            else if (selected == 3)
            {
                Console.WriteLine("What is the filename for the goal file?");
                string filename = Console.ReadLine();
                using (StreamWriter outputFile = new StreamWriter(filename))
                {
                    foreach (var str in goals)
                    {
                        outputFile.WriteLine($"{str}");
                    }
                }
                goals.Clear();
            }
            else if (selected == 4)
            {
                Console.WriteLine("What is the filename for the goal file?");
                string filename = Console.ReadLine();
                string[] lines = System.IO.File.ReadAllLines(filename);
                foreach (string line in lines)
                {
                    goals.Add($"{line}");
                }
            }
            else if (selected == 5)
            {
              string goalType = "";
              Console.WriteLine("The goals are:");
              for(int i=0; i<goals.Count; i++)
              {
                string[] goal = goals[i].Split(":");
                goalType = goal[0];
                string goalItself = goal[1];
                Console.WriteLine($"{i+1}.{goalItself}");
              }
                Console.WriteLine("Which goal did you accomplish?");
              int accomplished = Convert.ToInt32(Console.ReadLine());
              string accomplishedGoal = goals[accomplished-1];
              string[] parts = accomplishedGoal.Split(":");
              foreach(var line in parts)
              {
                Console.WriteLine($"{line}");
              }
              if(parts[0] == "Simple")
              {
                Console.WriteLine($"{parts[2]} points");
              } else if (parts[0] == "Checklist")
              {
                
              } 
            }
            else if (selected == 6)
            {
                System.Environment.Exit(0);
            }

        } while (true);
    }
}