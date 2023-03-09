using System;

class Checklist: Goal
{
    private int _completed = 0;
    public override void CreateGoal(){
      
    }

    public override void RecordEvent(){
      
    }
    public int IncreaseCompleted()
    {
      _completed++;
      return _completed;
    }
    public int GetCompleted(){
      return _completed;
    }
}