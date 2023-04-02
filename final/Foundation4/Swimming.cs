using System;

class Swimming:Activity
{    
    // int length, string date, int distance=0, int laps=0
    public Swimming(int length, string date, int laps): base(length, date, laps) {
        // int distance = GetDistance(laps);
        // string summary = GetSummary(date, length);

    }
    public override float GetDistance(int laps){
        Console.WriteLine($"{laps}, laps");
        Console.WriteLine($"{laps * 50}, laps * 50");
        Console.WriteLine($"{((laps * 50) / 1000)}, return");
        return (laps * 50) / 1000;
    }

    public override float GetSpeed(int length, int laps){
        return ( (laps * 50 / 1000) / length ) * 60 ;
    }

    public override float GetPace(int length, int laps){
        return 60 / this.GetSpeed(length, laps);
    }

    // public override string GetSummary(string date, int length) {
    // // Form: Date activityType (length): Distance (distance),
    // // Speed: (kph), Pace: length per km
    // string activityType = "Swimming";
    // return $"{date} {activityType} ({length}) min: Distance ({GetDistance()}), Speed: {GetSpeed()} (kph), Pace: ({GetPace()}) {length} per km";
    // }
}
