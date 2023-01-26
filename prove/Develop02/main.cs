using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;

static class Program
{

    public static IDictionary<string, string> journalNotes = new Dictionary<string, string>();

    static void Main(string[] args)
    {
        int userInput = 0;

        do
        {
            userInput = DisplayWelcoming();

            if (userInput == 1)
            {
                Write();
            }
            else if (userInput == 2)
            {
                Display();
            }
            else if (userInput == 3)
            {
                Load();
            }
            else if (userInput == 4)
            {
                Save();
            }
        } while (userInput != 5);

    }

    static int DisplayWelcoming()
    {
        Console.WriteLine("Welcome to the Journal Program!");
        Console.WriteLine("Please, select one of the following choices!");
        Console.WriteLine("1.Write");
        Console.WriteLine("2.Display");
        Console.WriteLine("3.Load");
        Console.WriteLine("4.Save");
        Console.WriteLine("5.Quit");

        string typedInput = Console.ReadLine();
        int parsedInput = int.Parse(typedInput);
        return parsedInput;

    }
    static void Write()
    {
        string[] questions = {
      "Who was the most interesting person I interacted with today?",
      "What was the best part of my day?",
      "How did I see the hand of the Lord in my life today?",
      "What was the strongest emotion I felt today?",
      "If I had one thing I could do over today, what would it be?"
    };

        Random rand = new Random();
        int index = rand.Next(questions.Length);
        var todayDate = DateTime.Now;
        string strToday = todayDate.ToString();
        Console.WriteLine($"{strToday}");

        string prompt = questions[index];

        Console.WriteLine($"{prompt}");
        string note = Console.ReadLine();

        string value = ($"{prompt} - {note}");

        Program.journalNotes.Add(strToday, value);
    }

    static void Display()
    {
        foreach (var month in journalNotes)
        {
            Console.WriteLine($"{month.Key}: {month.Value}");
        }
    }

    static void Save()
    {
        Console.WriteLine("What's the filename you'd like to give to your text?");
        string fileName = Console.ReadLine();

        using (StreamWriter outputFile = new StreamWriter(fileName))
        {
            // You can add text to the file with the WriteLine method
            //foreach(var kvp in Program.journalNotes)
            //outputFile.WriteLine($"Notes: {Program.journalNotes}");

            // You can use the $ and include variables just like with Console.WriteLine
            //string color = "Blue";
            foreach (var group in journalNotes)
                outputFile.WriteLine("Key: {0}, Value: {1}", group.Key, group.Value);
            //outputFile.WriteLine($"{journalNotes.Keys.ToString()}-{journalNotes.Values.ToString()}");
            //journalNotes.Values.OrderBy( x => x.Key ).Last()
        }
    }

    static void Load()
    {
      //Reading from file
      Console.WriteLine("What's the name of the file you'd like to load?");
      string filename = Console.ReadLine();
      string[] lines = System.IO.File.ReadAllLines(filename);
      
      foreach (string line in lines)
      {
          string[] parts = line.Split(',');
          
          string firstName = parts[0];
          string lastName = parts[1];
        Console.WriteLine($"{firstName},{lastName}");
      }

    }

}
