using System;

class Cycling:Activity
{
    // int length, string date, int distance=0, int laps=0
    public Cycling(int length, string date, int length, int distance): base(length, date, distance)
    {
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
}