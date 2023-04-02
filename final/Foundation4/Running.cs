using System;

class Running:Activity
{
    public Running(int length, int distance, string date): base(length, date, distance) {}

    public override float GetDistance(int distance){
        return distance;
    }

    public override float GetSpeed(int distance, int length){
        return ( distance / length ) * 60 ;
    }

    public override float GetPace(int length, int distance){
        return ( length / distance);
    }
}