using System;

class Outdoor: EventInfo {
  // For outdoor gatherings, this includes a statement of the weather.
  private string _weatherStatement = "";

  public Outdoor(string weatherStatement):base("ETHDenver","Event For Ethereum lovers","03/20/2023","10am-5pm", new Address()) 
  {
    _weatherStatement = weatherStatement;
  }

  public string LectureFullDetails() {
    // type of event
    string _eventType = GetEventType(2);
    string fullfromBase = FullDetails(2);
    return $"{fullfromBase} {_weatherStatement}";
  }

  
  public string SetWeatherStatement(string weatherStatement ) {
    return $"{_weatherStatement}";
  }

  public string GetWeatherStatement() {
    return $"{_weatherStatement}";
  }

}