using System;

public abstract class Activity
{
    private string _date = "";
    private int _distance = 0;
    private int _laps = 0;
    private int _length = 0; // minutes
    public Activity(int length, string date, int distance=0)
    {
        _length = length;
        _date = date;
        _distance = distance;
    }

    //setter/getter for length
    public int GetLength() {
        return _length;
    }

    public int SetLength(int length) {
        _length = length;
        return length;
    }

    public abstract string GetSummary(string activity, string date, int length, int distance, int speed, int pace) {
        // Form: Date activityType (length): Distance (distance),
// Speed: (kph), Pace: length per km
        string activityType = "";
        if (activity == "1"){ activityType = "Running"}
        else if (activity == "2"){ activityType = "Cycling"} 
        else if (activity == "3") {activityType = "Swimming"}
        return $"{date} {activityType} ({length}) min: Distance ({distance}), Speed: {speed} (kph), Pace: ({pace}) {length} per km";
    }

  // In addition, the base class should contain virtual methods for getting the distance, speed, pace. These methods should be overridden in the derived classes.
    public abstract int GetDistance();

    public abstract int GetSpeed();

    public abstract int GetPace();

    

// Attributes
// List<string> activities
// Methods:
// GetDistance() virtual
// GetSpeed() virtual
// GetPace() virtual => minutes/distance
// GetSummary():string 
// Form: Date activityType (length): Distance (distance),
// Speed: (kph), Pace: length per km
    
}