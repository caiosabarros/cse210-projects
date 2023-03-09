using System;

class Points
{
    private int _points = 0;
    private int _bonus = 0;
    private int _times = 0;

    public void DisplayPoints()
    {
        Console.WriteLine($"You have {_points} points.");
    }

    public int SetPointsRelatedToGoal(int points){
      _points = points;
      return _points;
    }

    public int SetBonusRelatedToGoal(int bonus){
      _bonus = bonus;
      return _bonus;
    }

    public int SetTimesQuantityToGetBonus(int times){
      _times = times;
      return _times;
    }
  
}