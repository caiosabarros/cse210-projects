using System;

class Swimming:Activity
{    
    // int length, string date, int distance=0, int laps=0
    public Swimming(int length, string date, int laps):base(length, date) {
        int distance = GetDistance(laps);


    }
    public override int GetDistance(int laps){
        return laps * 50 / 1000;
    }

    public override int GetSpeed(int length, int laps){
        return ( GetDistance(laps) / length ) * 60 ;
    }

    public override int GetPace(int length, int distance){
        return 60 / GetSpeed(length);
    }
}
