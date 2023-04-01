using System;

// For lectures, this includes the speaker name and capacity.
class Lecture: EventInfo {
  private string _speakerName = "";
  private int _capacity = 0;

  // Title, Description, Date, Time, and Address
  public Lecture(string speakerName, int capacity):
  base("ETHDenver","Event For Ethereum lovers","03/20/2023","10am-5pm", new Address())
  {
    _speakerName = speakerName;
    _capacity = capacity;
  }

  public string GetLectureSpeakerName() {
    return $"{_speakerName}";
  }

  public string SetLectureSpeakerName(string speakerName) {
    _speakerName = speakerName;
    return $"{_speakerName}";
  }

  public int GetLectureCapacity() {
    return _capacity;
  }

  public string SetLectureCapacity(int capacity) {
    _capacity = capacity;
    return $"{capacity}";
  }

}