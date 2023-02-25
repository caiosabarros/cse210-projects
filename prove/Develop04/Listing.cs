using System;
using System.Threading;
using System.Collections.Generic;

class Listing : Activity
{
  public void DisplayListingInitialMessage(){
    Console.WriteLine("Welcome to the Listing Activity");
    Console.WriteLine("");
    Console.WriteLine("This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.");
    Console.WriteLine("");
  }

  public void DisplayListingInitialQuestion(){
  List<string> listingQuestions = new List<string>{  
    "Who are people that you appreciate?",
    "What are personal strengths of yours?",
    "Who are people that you have helped this week?",
    "When have you felt the Holy Ghost this month?",
    "Who are some of your personal heroes?"
  };
  Random rand = new Random();
  int index = rand.Next(listingQuestions.Count);
  string element  = listingQuestions[index];
  Console.WriteLine("");
  Console.WriteLine($"{element}");
}
  public void GetInputsFromUser(int seconds){
  List<string> listingAnswers = new List<string>();
  int counter = seconds;
  Console.WriteLine("You may begin in:");
  for (int x = 5; x >= 1; x--)
  {
  Console.Write(x);
  Thread.Sleep(1000);
  Console.SetCursorPosition(Console.CursorLeft - 1, Console.CursorTop);
  }
  while(counter >=1){
    counter = counter - 1;
    Console.Write(">"); 
    string userInput = Console.ReadLine();
    listingAnswers.Add($"{userInput}");
    }
  Console.WriteLine($"You listed {listingAnswers.Count} items!");

  Console.WriteLine("Well Done!");
  Console.WriteLine("");
  }
}

