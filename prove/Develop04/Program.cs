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
          breath.DisplayAnimation(true);
          breath.InAndOut(duration);
          breath.DisplayAnimation(false);
          breath.DisplayEndingMessage(duration, "Breathing");
          breath.DisplayAnimation(false);
        } else if(selected == 2){
          //Reflecting
          Reflecting reflect = new Reflecting();
          reflect.DisplayReflectingInitialMessage();
          int length = reflect.AskForTime();
          reflect.DisplayAnimation(true);
          reflect.DisplayInitialRandomPrompt();
          reflect.DisplayQuestionsToReflect();
          reflect.DisplayAnimation(false);
          reflect.DisplayEndingMessage(length, "Reflecting");
          reflect.DisplayAnimation(false);
          } else if(selected == 3){
          //Listing
          Listing list = new Listing();
          list.DisplayListingInitialMessage();
          int period = list.AskForTime();
          list.DisplayAnimation(true);
          list.DisplayListingInitialQuestion();
          list.GetInputsFromUser(period);
          list.DisplayAnimation(false);
          //list.DisplayEntrance();
        } else {
          System.Environment.Exit(0);
        }
        System.Threading.Thread.Sleep(2000);
        }        
    }
}
