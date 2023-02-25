using System;
using System.Threading;

class Activity
{
  private int intTemp = 0;
  private int _seconds;
  public int AskForTime(){
      Console.WriteLine("How long, in seconds, would you like for this activity?");
      int seconds = Convert.ToInt32(Console.ReadLine());
      _seconds = seconds;
      return _seconds;
  }
  public void setSeconds(int seconds)
  {
    _seconds = seconds;
  }
    
  public void DisplayAnimation()
  {
        var spinner = new[] { '|', '/', '-', '\\' };
        var index = 0;
        var count = 30;
        while (count >= 1) {
            Console.Write(spinner[index]);
            index = (index + 1) % spinner.Length;
            Console.SetCursorPosition(Console.CursorLeft - 1,
              Console.CursorTop);
            System.Threading.Thread.Sleep(100);
            count--;
        }
  }

}