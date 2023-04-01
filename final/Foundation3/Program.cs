using System;

class Program {
  public static void Main (string[] args) {
    // Once you have the classes in place, write a program that creates at least one event of each type and sets all of their values. Then, for event event, call each of the methods to generate the marketing messages and output their results to the screen.

    //Creating event of type lecture
    Lecture lecture = new Lecture("Caio", 1000);
    
    // sets all of their values
    lecture.SetTitle("BYU Pathway Congress");
    lecture.SetDescription("Come to meet your teammates in person!");
    lecture.SetDate("04/04/2023");
    lecture.SetAddress();
    lecture.SetTime("8am-5pm");

    // call each of the methods to generate the marketing messages

    //Calling the StandardDetails
    string standardLecture = lecture.StandardDetails();
    //Calling the FullDetails
    string fullLecture = lecture.FullDetails(1);
    //Calling the ShortDescription
    string shortLecture = lecture.ShortDescription(1);
    
    // and output their results to the screen.
    Console.WriteLine("Lecture Event:");
    Console.WriteLine("");
    Console.WriteLine("Marketing StandardDetails Message:");
    Console.WriteLine("");
    Console.WriteLine($"{standardLecture}");
    Console.WriteLine("");
    Console.WriteLine("\r\n Marketing FullDetails Message:");
    Console.WriteLine("");
    Console.WriteLine($"{fullLecture}");
    Console.WriteLine("");
    Console.WriteLine("\r\n Marketing ShortDescription Message:");
    Console.WriteLine("");
    Console.WriteLine($"{shortLecture}");



    //Creating event of type outdoor
    Outdoor outdoor = new Outdoor("sweating all over");
    
    // sets all of their values
    outdoor.SetTitle("BYU Pathway Professor's Congress");
    outdoor.SetDescription("Come to meet your teachers in person!");
    outdoor.SetDate("20/05/2023");
    outdoor.SetAddress();
    outdoor.SetTime("8am-1pm");

    // call each of the methods to generate the marketing messages

    //Calling the StandardDetails
    string standardOutdoor = outdoor.StandardDetails();
    //Calling the FullDetails
    string fullOutdoor = outdoor.FullDetails(2);
    //Calling the ShortDescription
    string shortOutdoor = outdoor.ShortDescription(2);
    
    // and output their results to the screen.
    Console.WriteLine("");
    Console.WriteLine("");
    Console.WriteLine("Outdoor Event:");
    Console.WriteLine("");
    Console.WriteLine("Marketing StandardDetails Message:");
    Console.WriteLine("");
    Console.WriteLine($"{standardOutdoor}");
    Console.WriteLine("");
    Console.WriteLine("\r\n Marketing FullDetails Message:");
    Console.WriteLine("");
    Console.WriteLine($"{fullOutdoor}");
    Console.WriteLine("");
    Console.WriteLine("\r\n Marketing ShortDescription Message:");
    Console.WriteLine("");
    Console.WriteLine($"{shortOutdoor}");

    //Creating event of type reception
    Reception reception = new Reception("sweating all over");
    
    // sets all of their values
    reception.SetTitle("BYU Pathway Staff's Congress");
    reception.SetDescription("Come to meet BYU Pathway Staff in person!");
    reception.SetDate("20/05/2023");
    reception.SetAddress();
    reception.SetTime("8am-1pm");

    // call each of the methods to generate the marketing messages

    //Calling the StandardDetails
    string standardReception = reception.StandardDetails();
    //Calling the FullDetails
    string fullReception = reception.FullDetails(3);
    //Calling the ShortDescription
    string shortReception = reception.ShortDescription(3);
    
    // and output their results to the screen.
    Console.WriteLine("");
    Console.WriteLine("");
    Console.WriteLine("Reception Event:");
    Console.WriteLine("");
    Console.WriteLine("Marketing StandardDetails Message:");
    Console.WriteLine("");
    Console.WriteLine($"{standardReception}");
    Console.WriteLine("");
    Console.WriteLine("\r\n Marketing FullDetails Message:");
    Console.WriteLine("");
    Console.WriteLine($"{fullReception}");
    Console.WriteLine("");
    Console.WriteLine("\r\n Marketing ShortDescription Message:");
    Console.WriteLine("");
    Console.WriteLine($"{shortReception}");

    // In addition, your program must:

    // Use inheritance to avoid duplicating shared attributes and methods.
    // Use an address class for the addresses.
    // Follow the principles of encapsulation, making sure each member variable is private.
    // EventInfo eventInfo = new EventInfo("ethdenver", "a", "b", "c", new Address());
    // Lecture lecture = new Lecture("Caio", 1000);
    // string title = lecture.GetTitle();
    // string lectureTitle = lecture.GetLectureTitle();
    // //Basically, it gets the title from the base since the child hasn't set it
    // Console.WriteLine($"{title} and {lectureTitle}");
    // // ETHDenver and ETHDenver
    // //basically it sets the title globally from the base class
    // string global = lecture.SetTitle("global");
    // // basically it sets the title for the child class
    // string local = lecture.SetLectureTitle("lecture");
    // Console.WriteLine($"{global} local:{local}");
    // global local:lecture
    // it sets the local
    // string secondLectureTitle = lecture.GetLectureTitle();
    // // it sets the global
    // //And here it'ss the interesting part: basically, when it sets the local, it also modifies the global. At line 15, we set up the global 
    // // and the local. This means inheritance can be easily used:
    // //JUST CREATE A GETTER/SETTER IN THE EVENTINFO CLASS and also classes will be able to modify state and get it.
    // string thirdLectureTitle = lecture.GetTitle();
    // Console.WriteLine($"{secondLectureTitle} GetTitle:{thirdLectureTitle}");
    // lecture GetTitle:lecture
  }
  // Outputs:
  // ETHDenver and ETHDenver
  // global local:lecture
  // lecture GetTitle:lecture
}