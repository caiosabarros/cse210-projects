using System;

class Program
{
    // DONE Write a program that has a base Activity class and then has a derived class for each of the three activities.
    //  The base class should contain any attributes that are shared among all activities. Then, each derived class can define any additional attributes.
  
    // Finally, you should provide a GetSummary method to produce a string with all the summary information.

    // Remember that the summary method can make use of the other methods to produce its result. This method should be available for all classes, so it should be defined in the base class

    static void Main(string[] args)
    {
    List<Activity> activities = new List<Activity>();
    
    // Once you have the classes in place, write a program that creates at least one activity of each type.
    Running run = new Running(5, 25, "03 Nov 2022"); //5km in 25minutes
    Cycling cycling = new Cycling(10 ,"03 Nov 2022", 30);
    Swimming swim = new Swimming(30 ,"03 Nov 2022", 20); //25min, 5 laps
    //  Then iterate through this list and call the GetSummary method on each item and display the results.

    // Put each of these activities in the same list.
    activities.Add(run);
    activities.Add(cycling);
    activities.Add(swim);
    foreach (Activity activity in activities)
    {
        Console.WriteLine(activity.GetSummary());
    }

    }
}