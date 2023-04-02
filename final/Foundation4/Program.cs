using System;

class Program
{
    static void Main(string[] args)
    {
    List<Activity> activities = new List<Activity>();
    
    // Once you have the classes in place, write a program that creates at least one activity of each type.
    Running run = new Running(5, 25, "03 Nov 2022"); //5km in 25minutes
    Cycling cycling = new Cycling(10 ,"03 Nov 2022", 30);
    Swimming swim = new Swimming(100 ,"03 Nov 2022", 50); //100min, 5 laps

    // Put each of these activities in the same list.
    activities.Add(run);
    activities.Add(cycling);
    activities.Add(swim);
    //  Then iterate through this list and call the GetSummary method on each item and display the results.
    foreach (Activity activity in activities)
    {
        Console.WriteLine(activity.GetSummary());
    }

    }
}