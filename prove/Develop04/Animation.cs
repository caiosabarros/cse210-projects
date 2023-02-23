using System;
using System.Collections.Generic;

class Animation
{
    static void Master(string[] args)
    {

  
      List<string> animation = new List<string>();
    
      animation.Add("|");
      animation.Add("/");
      animation.Add("-");
      animation.Add("\\");
      animation.Add("|");
      animation.Add("/");
      animation.Add("-");
      animation.Add("\\");
    }
    
    public void DisplayAnimation()
    { 
      for (int i=5;i>0;i--)
      {
      	Console.Write(".");
      	System.Threading.Thread.Sleep(1000);
      	Console.Write("\b \b");
      }
    }
      
}
