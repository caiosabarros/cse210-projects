using System;

public class Fraction
{
    private int _top;
    private int _bottom;
    int number;
//Constructor that has no parameters that initializes the number to 1/1.
    public Fraction()
    {
        number = 1 / 1;
    }
//Constructor that has one parameter for the top and that initializes the denominator to 1. So that if you pass in the number 5, the fraction would be initialized to 5/1.
    public Fraction(string numerator)
    {
        _top = numerator;
        number = numerator / 1;


    }

//Constructor that has two parameters, one for the top and one for the bottom.
    public Fraction(string numerator, string denominator)
    {
        number = numerator / denominator;
    }
}


//Create the Constructors
//Create the following constructors:
//In your Program.cs file, verify that you can create fractions using all three of these constructors. For example, create an instance for 1/1 (using the first constructor), for 6/1 (using the second constructor), for 6/7 (using the third constructor).
//Create the Getters and Setters
//Create getters and setters for both the top and the bottom values.
//In your Program.cs file, verify that you can call all of these methods and get the correct values, using setters to change the values and then getters to retrieve these new values and then display them to the console.
//Create methods to return the representations
//Create a method called GetFractionString that returns the fraction in the form 3/4.
//Create a method called GetDecimalValue that returns a double that is the result of dividing the top number by the bottom number, such as 0.75.
//Verify that you can call each constructor and that you can retrieve and display the different representations for a few different fractions. For example, you could try:
//1
//5
//3/4
//1/3
