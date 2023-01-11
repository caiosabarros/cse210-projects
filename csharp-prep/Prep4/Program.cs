using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main(string[] args)
    {
        List<int> numbers = new List<int>();
        int numberInput;
        int total = 0;
        Console.WriteLine("Enter a list of numbers, type 0 when finished.");
        do
        {
        Console.WriteLine("Enter number:");
        string userInput = Console.ReadLine();
        numberInput = int.Parse(userInput);
        numbers.Add(numberInput);
        } while (numberInput != 0);
        foreach (int number in numbers){
            total += number;
        }
        numbers.Sort();
        Console.WriteLine($"the sum is {total}");
        Console.WriteLine($"the biggest is:{numbers.Last()}");
        Console.WriteLine($"The average is {total/numbers.Count()}");
    }
}