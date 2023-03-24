using System;

// Make sure that all member variables are private and getters, setters, and constructors are created as needed.


class Program
{
    static void Main(string[] args)
    {
        //write a program that creates at least two orders
        Order firstOrder = new Order();
        Order secondOrder = new Order();
        Order thirdOrder = new Order();

        // with a 2-3 products each. (string name, int price, int id, int amount)
        firstOrder.AddProduct("Hotwells car", 5, 1264, 2);
        firstOrder.AddProduct("BasketBall", 20, 9845, 1);
        firstOrder.AddProduct("Soccer Ball", 25, 8761, 1);
        secondOrder.AddProduct("Barbie doll", 60, 9781, 1);
        secondOrder.AddProduct("Iphone XR", 700, 9498, 1);
        secondOrder.AddProduct("Samsung Television", 1000, 9812, 1);

        // Call the methods to get the packing label,
        Console.WriteLine("");
        Console.WriteLine("PACKING LABELS OF FIRST ORDER:");
        firstOrder.PackingLabel();
        Console.WriteLine("PACKING LABELS OF SECOND ORDER:");
        secondOrder.PackingLabel();
        //the shipping label, 
        Console.WriteLine("");
        Console.WriteLine("SHIPPING LABELS OF FIRST ORDER:");
        firstOrder.ShippingLabel();
        Console.WriteLine("SHIPPING LABELS OF SECOND ORDER:");
        secondOrder.ShippingLabel();
        //and the total price of the order, and display the results of these methods.
        int firstOrderTotalCost = firstOrder.TotalOrderCost();
        int secondOrderTotalCost = secondOrder.TotalOrderCost();
        Console.WriteLine("");
        Console.WriteLine($"The first order total cost is: {firstOrderTotalCost}");
        Console.WriteLine($"The second order total cost is: {secondOrderTotalCost}");
    }
}