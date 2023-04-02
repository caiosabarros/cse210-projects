using System;

public abstract class Activity
{
    private string _date = "";
    private int _distance;
    private int _laps;
    private int _length = 0; // minutes
    public Activity(int length, string date, int distance)
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

    public string GetSummary() {
        // Form: Date activityType (length): Distance (distance),
// Speed: (kph), Pace: length per km
        // string activityType = "";
        //make many if elses and instantiate each class and make the return inside each class.
        // Then each class defines its own GetSummary calling
        // the other methods within the class itself
        // A base class that only contains these abstract methods and nothing else has a special name, it is called an Interface
        // Use abstract classes bc interface only has abstract methods.
        // Override the method in each class.
        //call the methods using the keyword this.

        return $"{_date} {this} ({this.GetLength()}) min: Distance ({this.GetDistance(_distance)}), Speed: {this.GetSpeed(_distance, _length)} (kph), Pace: ({this.GetPace(_distance, _length)}) {_length} per km";
    }

  // In addition, the base class should contain virtual methods for getting the distance, speed, pace. These methods should be overridden in the derived classes.
    public abstract float GetDistance(int distance);

    public abstract float GetSpeed(int distance, int length);

    public abstract float GetPace(int distance, int length);

    

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