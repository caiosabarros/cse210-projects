using System;

class Product
{
// Contains the name, product id, price, and quantity of each product.
    private string _productName = "";
    private int _productId = 0;
    private int _price = 0;
    private int _quantity = 0;
// The price of this product is computed by multiplying the price and the quantity.
    public int GetPrice()
    {
        _price = _price * quantity;
        return price;
    }
}