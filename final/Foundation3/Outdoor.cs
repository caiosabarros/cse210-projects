using System;

class Outdoor: EventInfo {
  // For outdoor gatherings, this includes a statement of the weather.
  private string _weatherStatement = "";
  public static void Main (string[] args) {
    Console.WriteLine ("Hello World");
  }

  public string LectureFullDetails() {
    // type of event
    string _eventType = GetEventType(1);
    string fullfromBase = FullDetails();
    return $"{fullfromBase} {_weatherStatement}";
  }

  
  public string GetOutdoorTitle() {
    return $"{_title}";
  }

  public string GetOutdoorDescription() {
    return $"{_description}";
  }

  public string GetOutdoorDate() {
    return $"{_date}";
  }

  public string GetOutdoorTime() {
    return $"{_time}";
  }

  public string GetOutdoorAddress() {
    return $"{_address}";
  }
}