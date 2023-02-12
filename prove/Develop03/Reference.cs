using System;

class Reference 

{
  private string _reference;
  

  public Reference(string reference)
  {
    _reference = reference;
  }

  public Reference()
  {
  _reference = "1 Nephi 3:7";
  }

  public string DisplayReference()
  {
    Console.WriteLine($"{_reference}");
    return _reference;
  }
  static void Main2(string[] args)
  {
  }
}



