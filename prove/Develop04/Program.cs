using System;

class Program : Menu 
{
    static void Main(string[] args)
    {
        Program program = new Program();
        int selected = program.DisplayMenu();
        if(selected == 1){
          //Breathing
          Breathing breath = new Breathing();
          breath.DisplayBreathingInitialMessage();
          int duration = breath.AskForTime();
          breath.InAndOut(duration);
        } else if(selected == 2){
          //Reflecting
          Reflecting reflect = new Reflecting();
          reflect.DisplayReflectingInitialMessage();
          int length = reflect.AskForTime();
          //reflect.DisplayEntrance();
        } else if(selected == 3){
          //Listing
          Listing list = new Listing();
          list.DisplayListingInitialMessage();
          int period = list.AskForTime();
          //list.DisplayEntrance();
        } else {
          System.Environment.Exit(0);
        }
        
        System.Threading.Thread.Sleep(1000);
    }
}
