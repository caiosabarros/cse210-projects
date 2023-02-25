using System;
using System.Threading;
using System.Collections.Generic;

class Reflecting : Activity
{

    public void DisplayReflectingInitialMessage()
    {
        Console.WriteLine("Welcome to the Reflecting Activity");
        Console.WriteLine("");
        Console.WriteLine(" This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.");
        Console.WriteLine("");
    }

    public void DisplayInitialRandomPrompt()
    {
        Console.WriteLine("Consider the following prompt:");
        Console.WriteLine("");
        List<string> prompts = new List<string>{
    "Think of a time when you stood up for someone else.",
    "Think of a time when you did something really difficult.",
    "Think of a time when you helped someone in need.",
    "Think of a time when you did something truly selfless."
    };
        Random rand = new Random();
        int index = rand.Next(prompts.Count);
        string randomElement = prompts[index];
        Console.WriteLine($"--{randomElement}--");
        Console.WriteLine("");
        Console.WriteLine("When you have something in mind, press enter to continue.");
        Console.ReadKey();
    }

    public void DisplayQuestionsToReflect()
    {
        Console.Write("Now ponder on each of the following questions as they related to this experience.");
        Console.WriteLine("");
        Console.WriteLine("You may begin in:");
        for (int x = 5; x >= 1; x--)
        {
            Console.Write(x);
            Thread.Sleep(1000);
            Console.SetCursorPosition(Console.CursorLeft - 1, Console.CursorTop);
        }
        Console.Clear();
        List<string> questions = new List<string>{
    "Why was this experience meaningful to you?",
    "Have you ever done anything like this before?",
    "How did you get started?",
    "How did you feel when it was complete?",
    "What made this time different than other times when you were not as successful?",
    "What is your favorite thing about this experience?",
    "What could you learn from this experience that applies to other situations?",
    "What did you learn about yourself through this experience?",
    "How can you keep this experience in mind in the future?"
        };
        for (int x=4; x>=1;x--)
        {
        Random rand = new Random();
        int index = rand.Next(questions.Count);
        string randomQuestion = questions[index];
        Console.WriteLine($"{randomQuestion}");
        Reflecting reflect = new Reflecting();
        reflect.DisplayAnimation(false);
        System.Threading.Thread.Sleep(3000);
        Console.WriteLine("");
      }
    }
}