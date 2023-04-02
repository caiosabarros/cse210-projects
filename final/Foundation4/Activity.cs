using System;

public abstract class Activity
{
    private string _date = "";
    private int _distance;
    private int _laps;
    private int _length; // minutes
    public Activity(int length, string date, int distance)
    {
        _length = length;
        _date = date;
        _distance = distance;
        
    }

    public int GetLength() {
        return _length;
    }

    public int SetLength(int length) {
        _length = length;
        return length;
    }

    public string GetSummary() {
        return $"{_date} {this} ({this.GetLength()} min): Distance {this.GetDistance(_distance)} km, Speed: {this.GetSpeed(_distance, _length)} (kph), Pace: ({this.GetPace(_distance, _length)}) min per km";
    }

  // In addition, the base class should contain virtual methods for getting the distance, speed, pace. These methods should be overridden in the derived classes.
    public abstract float GetDistance(int distance);

    public abstract float GetSpeed(int distance, int length);

    public abstract float GetPace(int distance, int length);
}