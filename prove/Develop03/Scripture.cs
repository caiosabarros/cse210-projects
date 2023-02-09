using System;

class Scripture 

{
  private string _reference;
  private string _singleVerse;
  

  public Scripture(string singleVerse, string reference)
  {
    _singleVerse = singleVerse;
    _reference = reference;
  }

  public Scripture()
  {
  _reference = "1 Nephi 3:7";
  _singleVerse = "1 Nephi 3:7 And it came to pass that I, Nephi, said unto my father: I will go and do the things which the Lord hath commanded, for I know that the Lord giveth no commandments unto the children of men, save he shall cprepare a way for them that they may accomplish the thing which he commandeth them.";
  }

  public void  DisplayScripture()
  {
    Console.WriteLine($"{_reference} {_singleVerse}");
  }
  static void Main(string[] args)
  {
    Scripture myObj = new Scripture();
    Console.WriteLine();
  }
}

