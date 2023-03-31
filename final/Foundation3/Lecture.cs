using System;

// For lectures, this includes the speaker name and capacity.
class Lecture: EventInfo {
  private string _speakerName = "";
  private int _capacity = 0;

  // Title, Description, Date, Time, and Address
  public Lecture( string speakerName, int capacity):
  base("ETHDenver","Event For Ethereum lovers","03/20/2023","10am-5pm", new Address())
  {
    _speakerName = speakerName;
    _capacity = capacity;
  }

  //find a way to use the base's function without overriding.
  public string LectureFullDetails() {
    // type of event
    // string _eventType = GetEventType(1);
    string fullfromBase = FullDetails(1);
    return $"{fullfromBase} {_speakerName} {_capacity}";
  }

  // Short description - Lists the type of event, title, and the date.
  public string ShortDescription() {
    //type of event
    string _eventType = GetEventType(1);
    return $"{_eventType} {GetLectureTitle()} {GetLectureDate()}";
  }

  public string GetLectureTitle() {
    return $"{_title}";
  }

  public string SetLectureTitle(string title) {
    _title = title;
    return $"{title}";
  }

  public string GetLectureDescription() {
    return $"{_description}";
  }

  public string GetLectureDate() {
    return $"{_date}";
  }

  public string GetLectureTime() {
    return $"{_time}";
  }

  public string GetLectureAddress() {
    return $"{_address}";
  }
}