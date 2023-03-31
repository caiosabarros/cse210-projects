using System;

class Program {
  public static void Main (string[] args) {
    Event event = new Event("ethdenver", "a", "b", "c", new Address());
    Lecture lecture = new Lecture("Caio", 1000);
    string title = lecture.GetTitle();
  }
}