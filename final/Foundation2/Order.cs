// Order
// This company is based in the USA. If the customer lives in the USA, then the shipping cost is $5. If the customer does not live in the USA, then the shipping cost is $35.
using System;
using System.Collections.Generic;

// Can calculate the total cost of the order, and can return a string for the packing label, and can return a string for the shipping label.
// Contains a list of products and a customer. 
class Order
{
    List<Product> products = new List<Product>();
    Customer customer = new Customer();
    public int TotalOrderCost()
    {
// The total price is calculated as the sum of the prices of each product plus a one-time shipping cost.
        
    }

    public string PackingLabel(){
// A packing label should list the name and product id of each product in the order.
    foreach(Product product in products) {
        Console.WriteLine($"Product Name:{product.name} Product Id:{product.id}")
    }
    }

    public string ShippingLabel(){
// A shipping label should list the name and address of the customer
        Console.WriteLine($"Customer Name:{customer._name} {customer._address.DisplayAddress()}")
    }
}