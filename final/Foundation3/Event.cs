using System;

// Regardless of the type, all events need to have an Event Title, Description, Date, Time, and Address.
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
    return $"{_title} {_description} {_date} {_time} {_address.DisplayAddress()}";
  }

  // Full details - Lists all of the above, plus type of event and information specific to that event type.
  public string FullDetails(int eventType) {
    // type of event leave as it is for the child classes
    //bc this way we won't need to override the base's fulldetails method.
    string _eventType = GetEventType(eventType);
    //ONLY DO AS https://github.com/byui-cse/cse210-student-sample-solutions/blob/main/prepare/Learning04/WritingAssignment.cs -> Inicializa o constructor da base class setando as novas variáveis e dá um display em tudo...chama fulldetails da base e adiciona coisas da child. 
    return $"{_title} {_description} {_date} {_time} {_address.DisplayAddress()} {_eventType}";
  }

  // Short description - Lists the type of event, title, and the date.
  public string ShortDescription(int eventType) {
    //type of event
    string _eventType = GetEventType(eventType);
    return $"{_eventType} {_title} {_date}";
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

  public string GetDate() {
    return $"{_date}";
  }

  public string GetTime() {
    return $"{_time}";
  }

  public string GetAddress() {
    return $"{_address}";
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
  
  // public static void Main (string[] args) {
  //   Console.WriteLine ("Hello World");
  // }
}