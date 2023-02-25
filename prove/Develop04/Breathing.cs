using System;
using System.Threading;

class Breathing : Activity
{
  public void DisplayBreathingInitialMessage(){
    Console.WriteLine("Welcome to the Breathing Activity");
    Console.WriteLine("");
    Console.WriteLine("This activity will help you relax by walking your through breathing in and out slowly. Clear your mind and focus on your breathing");
  }

  public void InAndOut(int length)
  {
    for (int i=length; i>= 1; i=i-20){
      Console.WriteLine("Get ready...");
      Console.WriteLine("");
      Console.Write("Breath in...");
      for (int x=5; x>=1; x--)
      {
      Console.Write(x);
      Thread.Sleep(1000);
      Console.SetCursorPosition(Console.CursorLeft-1,Console.CursorTop);  
      }
      Console.WriteLine("");
      Console.Write("Now breath out..."); 
      for (int t=5; t>=1; t--)
      {
      Console.Write(t);
      Thread.Sleep(1000);
      Console.SetCursorPosition(Console.CursorLeft-1,Console.CursorTop);  
      }
      
      Console.WriteLine("");
      Console.Write("Breath in...");
      for (int s=5; s>=1; s--)
      {
      Console.Write(s);
      Thread.Sleep(1000);
      Console.SetCursorPosition(Console.CursorLeft-1,Console.CursorTop);  
      }
      Console.WriteLine("");
      Console.Write("Now breath out..."); 
      for (int m=5; m>=1; m--)
      {
      Console.Write(m);
      Thread.Sleep(1000);
      Console.SetCursorPosition(Console.CursorLeft-1,Console.CursorTop);  
      }
    }
}
}