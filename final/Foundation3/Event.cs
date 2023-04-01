using System;

// Regardless of the type, all events need to have an Event Title, Description, Date, Time, and Address.

//changed the name from Event to EventInfo because I was getting errors related to event being a keyword in C# :/
class EventInfo {
  protected string _title="";
  protected string _description="";
  protected string _date="";
  protected string _time="";
  protected Address _address = new Address("Brazil");

  // They would like the ability to generate three different messages:
  public EventInfo( string title, string description , string date , string time, Address address){
   _title= title ;
   _description= description;
   _date= date;
   _time= time;
   _address = new Address();
  }
  
  // Standard details - Lists the title, description, date, time, and address.
  public string StandardDetails () {
    return $"Title: {_title} \r\n Description: {_description} \r\n Date: {_date} \r\n Time: {_time} \r\n Address: {_address.DisplayAddress()}";
  }

  // Full details - Lists all of the above, plus type of event and information specific to that event type.
  public string FullDetails(int eventType) {
    // type of event leave as it is for the child classes
    //bc this way we won't need to override the base's fulldetails method.
    string _eventType = GetEventType(eventType);
    if(_eventType == "Lecture") {
      Lecture lecture = new Lecture("Caio", 1000);
      return $"Title: {_title} \r\n Description: {_description} \r\n Date: {_date} \r\n Time: {_time} \r\n Address: {_address.DisplayAddress()} \r\n Event Type: {_eventType} \r\n Speaker Name: {lecture.GetLectureSpeakerName()} \r\n Capacity: {lecture.GetLectureCapacity()}";
    } else if(_eventType == "Outdoor") {
      Outdoor outdoor = new Outdoor("sweating all over");
      return $"Title: {_title} \r\n Description: {_description} \r\n Date: {_date} \r\n Time: {_time} \r\n Address: {_address.DisplayAddress()} \r\n Event Type: {_eventType} \r\n Weather Statement: {outdoor.GetWeatherStatement()}";
    } else if( _eventType == "Reception") {
      Reception reception = new Reception("barackobama@yahoo.com");
      return $"Title: {_title} \r\n Description: {_description} \r\n Date: {_date} \r\n Time: {_time} \r\n Address: {_address.DisplayAddress()} \r\n Event Type: {_eventType} \r\n Email for RSVP: {reception.GetReceptionEmail()}";
    } else {
      return $"Title: {_title} \r\n Description: {_description} \r\n Date: {_date} \r\n Time: {_time} \r\n Address: {_address.DisplayAddress()} \r\n Event Type: {_eventType}";
    }
    //ONLY DO AS https://github.com/byui-cse/cse210-student-sample-solutions/blob/main/prepare/Learning04/WritingAssignment.cs -> Inicializa o constructor da base class setando as novas variáveis e dá um display em tudo...chama fulldetails da base e adiciona coisas da child. 
  }

  // Short description - Lists the type of event, title, and the date.
  public string ShortDescription(int eventType) {
    //type of event
    string _eventType = GetEventType(eventType);
    return $"\r\n Event Type: {_eventType} \r\n Title: {_title} \r\n Date:{_date}";
  }

  
  //create getters for those who'll inherit
  public string GetTitle() {
    return $"{_title}";
  }

  public string SetTitle(string title) {
    _title = title;
    return $"{_title}";
  }

  public string GetDescription() {
    return $"{_description}";
  }

  public string SetDescription(string description) {
    _description = description;
    return $"{_description}";
  }

  public string GetDate() {
    return $"{_date}";
  }

  public string SetDate(string date) {
    _date = date;
    return $"{_date}";
  }

  public string GetTime() {
    return $"{_time}";
  }

  public string SetTime(string time) {
    _time = time;
    return $"{_time}";
  }

  public string GetAddress() {
    return $"{_address.DisplayAddress()}";
  }

  public string SetAddress() {
    Address _address = new Address();
    return _address.DisplayAddress();
  }

  //this function will be inherited and given the eventType corresponding to the event. For example: For Lecture, it'll be as follows:
  // string eventType = GetEventType(1);
  //and then the event Type is displayed.
  public string GetEventType(int eventType) {
    if(eventType == 1) {
      return "Lecture";
    } else if (eventType == 2) {
      return "Outdoor";
    } else if (eventType == 3) {
      return "Reception";
    } else {
      return "-1";
    }
  }

}