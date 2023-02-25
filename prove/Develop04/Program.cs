using System;

class Program : Menu 
{
    static void Main(string[] args)
    {
        Program program = new Program();
        while(true){
        int selected = program.DisplayMenu();
        if(selected == 1){
          //Breathing
          Breathing breath = new Breathing();
          breath.DisplayBreathingInitialMessage();
          int duration = breath.AskForTime();
          breath.InAndOut(duration);
          breath.DisplayEndingMessage(duration, "Breathing");
        } else if(selected == 2){
          //Reflecting
          Reflecting reflect = new Reflecting();
          reflect.DisplayReflectingInitialMessage();
          int length = reflect.AskForTime();
          reflect.DisplayInitialRandomPrompt();
          reflect.DisplayQuestionsToReflect();
          reflect.DisplayEndingMessage(length, "Reflecting");
        } else if(selected == 3){
          //Listing
          Listing list = new Listing();
          list.DisplayListingInitialMessage();
          int period = list.AskForTime();
          list.DisplayListingInitialQuestion();
          list.GetInputsFromUser(period);
          //list.DisplayEntrance();
        } else {
          System.Environment.Exit(0);
        }
        System.Threading.Thread.Sleep(2000);
        }        
    }
}
