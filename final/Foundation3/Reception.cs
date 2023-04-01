using System;

class Reception: EventInfo {
  // For receptions this includes an email for RSVP
  private string _email = "";
  
  public Reception(string email): base("ETHDenver","Event For Ethereum lovers","03/20/2023","10am-5pm", new Address())  {
    _email = email;
  }

  public string GetReceptionEmail() {
    return $"{_email}";
  }

  public string SetReceptionEmail(string email) {
    _email = email;
    return $"{_email}";
  }
}