using System;

class Program {
  public static void Main (string[] args) {
    EventInfo eventInfo = new EventInfo("ethdenver", "a", "b", "c", new Address());
    Lecture lecture = new Lecture("Caio", 1000);
    string title = lecture.GetTitle();
    string lectureTitle = lecture.GetLectureTitle();
    //Basically, it gets the title from the base since the child hasn't set it
    Console.WriteLine($"{title} and {lectureTitle}");
    // ETHDenver and ETHDenver
    //basically it sets the title globally from the base class
    string global = lecture.SetTitle("global");
    // basically it sets the title for the child class
    string local = lecture.SetLectureTitle("lecture");
    Console.WriteLine($"{global} local:{local}");
    // global local:lecture
    // it sets the local
    string secondLectureTitle = lecture.GetLectureTitle();
    // it sets the global
    //And here it'ss the interesting part: basically, when it sets the local, it also modifies the global. At line 15, we set up the global 
    // and the local. This means inheritance can be easily used:
    //JUST CREATE A GETTER/SETTER IN THE EVENTINFO CLASS and also classes will be able to modify state and get it.
    string thirdLectureTitle = lecture.GetTitle();
    Console.WriteLine($"{secondLectureTitle} GetTitle:{thirdLectureTitle}");
    // lecture GetTitle:lecture
  }
  // Outputs:
  // ETHDenver and ETHDenver
  // global local:lecture
  // lecture GetTitle:lecture
}