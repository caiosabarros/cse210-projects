// Order
// This company is based in the USA. If the customer lives in the USA, then the shipping cost is $5. If the customer does not live in the USA, then the shipping cost is $35.
using System;
using System.Collections.Generic;

// Can calculate the total cost of the order, and can return a string for the packing label, and can return a string for the shipping label.
// Contains a list of products and a customer. 
class Order
{
    private List<Product> products = new List<Product>();
    private Customer customer = new Customer("Caio");

    public Order(){
        customer = new Customer("Caio");
        string customerName = customer.GetCustomerName();
    }

    public int TotalOrderCost()
    {
    int totalPrice = 0;
// The total price is calculated as the sum of the prices of each product plus a one-time shipping cost.
    foreach(Product product in products){
        totalPrice += product.GetTotalPrice();
    }
    if( customer.DoesCustomerLiveInTheUS() ) {
        totalPrice = totalPrice + 5;
    } else {
        totalPrice = totalPrice + 35;
    }
      return totalPrice;
    }

    public void AddProduct(string name, int price, int id, int amount){
        products.Add(new Product(name, price, id, amount));
    }

    public void GetProductsFromOrder(){ 
        foreach(Product product in products){
            Console.WriteLine($"Name: {product.GetProductName()}");
            Console.WriteLine($"ID: {product.GetProductID()}");
            Console.WriteLine($"Quantity: {product.GetQuantity()}");
            Console.WriteLine($"Price: {product.GetProductPrice()}");
            Console.WriteLine($"Total Price: {product.GetTotalPrice()}");
        }
    }

    public void PackingLabel(){
// A packing label should list the name and product id of each product in the order.
    foreach(Product product in products) {
        Console.WriteLine($"Product Name:{product.GetProductName()}--Product Id:{product.GetProductID()}");
    }
    }

    public void ShippingLabel(){
// A shipping label should list the name and address of the customer
        Console.WriteLine($"Customer Name:{customer.GetCustomerName()}--Address:{customer.GetCustomerAddress()}");
    }
}