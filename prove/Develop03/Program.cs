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
        Reference reference = new Reference();
        do 
        {
        string scripture = "And it came to pass that I, Nephi, said unto my father: I will go and do the things which the Lord hath commanded, for I know that the Lord giveth no commandments unto the children of men, save he shall cprepare a way for them that they may accomplish the thing which he commandeth them.";
        string newString = string.Empty;

        Console.WriteLine("Press enter to continue or type 'quit' to finish");
        //Console.WriteLine($"{reference.DisplayReference()} {scripture}");
        userInput = Console.ReadLine();
        string[] result = Regex.Matches(scripture, @"\w+").Cast<Match>().Select(m => m.Value).ToArray();
        int random_number = new Random().Next(1, 10);
        foreach (string stw in result)
        {
            if(stw.Length % random_number != 0)
            {
                newString += $" {stw}";
            } else { 
                newString += stw.ToLower().Replace(stw, "____");
            }

        }
        Console.WriteLine("Press enter to continue or type 'quit' to finish");
        userInput = Console.ReadLine();
        Console.WriteLine($"{newString}");
        } 
        while (userInput != "quit");
    }
}

