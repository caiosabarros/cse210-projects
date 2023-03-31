using System;

class Reception: EventInfo {
  // For receptions this includes an email for RSVP
  private string _email = "";
  
  public string ReceptionFullDetails(string email) {
    // type of event
    string _eventType = GetEventType(2);
    //may be search for how to display optional parameter only if passed.
    string fullfromBase = FullDetails();
    return $"{fullfromBase} {_email}";
  }

  
    public string GetReceptionTitle() {
    return $"{_title}";
  }

  public string GetReceptionDescription() {
    return $"{_description}";
  }

  public string GetReceptionDate() {
    return $"{_date}";
  }

  public string GetReceptionTime() {
    return $"{_time}";
  }

  public string GetReceptionAddress() {
    return $"{_address}";
  }
}