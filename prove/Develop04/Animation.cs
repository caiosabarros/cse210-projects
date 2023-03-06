using System;
using System.Collections.Generic;

class Animation
{
    static void Main(string[] args) {

    }

     public void displayAnimation(){
        var spinner = new[] { '|', '/', '-', '\\' };
        var index = 0;
        while (true) {
            Console.Write(spinner[index]);
            index = (index + 1) % spinner.Length;
            Console.SetCursorPosition(Console.CursorLeft - 1, Console.CursorTop);
            System.Threading.Thread.Sleep(100); 
     }
  
  
    }
}
