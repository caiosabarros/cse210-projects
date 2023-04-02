using System;

class Swimming:Activity
{    
    public Swimming(int length, string date, int laps): base(length, date, laps) {}
    public override float GetDistance(int laps){
        return (laps * 50) / 1000;
    }

    public override float GetSpeed(int length, int laps){
        return ( ( ((laps * 50) / 1000f) / length ) * 60) ;
    }

    public override float GetPace(int length, int laps){
        return 60 / this.GetSpeed(length, laps);
    }
}
