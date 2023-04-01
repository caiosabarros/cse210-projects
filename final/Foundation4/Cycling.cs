using System;

class Cycling:Activity
{
    // int length, string date, int distance=0, int laps=0
    public Cycling(int length, string date, int distance): base(length, date, distance)
    {
        // string summary = GetSummary(date,length);
    }

    public override float GetDistance(int distance){
        return distance;
    }

    public override float GetSpeed(int distance, int length){
        return ( distance / length ) * 60 ;
    }

    public override float GetPace(int length, int distance){
        return ( length / distance);
    }

    // public override string GetSummary(string date, int length) {
    // // Form: Date activityType (length): Distance (distance),
    // // Speed: (kph), Pace: length per km
    // string activityType = "Cycling";
    // return $"{date} {activityType} ({length}) min: Distance ({GetDistance()}), Speed: {GetSpeed()} (kph), Pace: ({GetPace()}) {length} per km";
    // }
}