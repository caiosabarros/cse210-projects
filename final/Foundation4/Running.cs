using System;

class Running:Activity
{
    // int length, string date, int distance=0, int laps=0
    public Running(int length, int distance, string date): base(length, distance, date){
        int distance = GetDistance(distance);
        int speed = GetSpeed(distance, length);
        int pace = GetPace(length, distance);
    }

    public override int GetDistance(int distance){
        return distance;
    }

    public override int GetSpeed(int distance, int length){
        return ( distance / length ) * 60 ;
    }

    public override int GetPace(int length, int distance){
        return ( length / distance);
    }
//         int _distance
// Data _date
// int _length = minutes
// Methods:
// Running(int, int, Date)
// GetDistance(): int => laps * 50 / 1000 (km)
 
}