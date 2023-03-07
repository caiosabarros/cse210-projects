using System;

public abstract class Goal
{
  private string _name = "";
  private string _description = "";
  private int bonus = 0;

  public string SetGoalName(string _goalName){
    _name = _goalName;
    return _name;
  }
  public string SetGoalDescription(string goalDescription){
    _description = goalDescription;
    return _description;
  }

  public void ListGoals(){
    
  }

  public void SaveGoal(string filename){
    
  }

  public void LoadGoal(string filename){
    
  }

  public abstract void RecordEvent();
  public abstract void CreateGoal();
  
  public bool IsComplete()  {
    return true;
  }
}