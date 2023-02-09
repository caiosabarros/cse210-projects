using System;
using System.Text.RegularExpressions;
//using System.Text.RegularExpressions.MatchCollection;
using System.Linq;

class Program
{
    static void Main(string[] args)
    {
        string userInput;
        Scripture verse = new Scripture();
        verse.DisplayScripture();
        do 
        {
        Console.WriteLine("We did it above!");
        string scripture = "1 Nephi 3:7 And it came to pass that I, Nephi, said unto my father: I will go and do the things which the Lord hath commanded, for I know that the Lord giveth no commandments unto the children of men, save he shall cprepare a way for them that they may accomplish the thing which he commandeth them.";
        string newString = string.Empty;
        Console.WriteLine("Press enter to continue or type 'quit' to finish");
        Console.WriteLine($"{scripture}");
        string[] result = Regex.Matches(scripture, @"\w+").Cast<Match>().Select(m => m.Value).ToArray();

        foreach (string stw in result)
        {
            if(stw.Length > 3)
            {
                newString += $" {stw}";
            } else { 
                newString += "____";
            }
            //creates a new array with something in place of string swt if it's bigger than 3
            //Console.WriteLine($"{stw}");
        }
        Console.WriteLine("Press enter to continue or type 'quit' to finish");
        userInput = Console.ReadLine();
        Console.WriteLine($"{newString}");
        } 
        while (userInput != "quit");
    }
}
