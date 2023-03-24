using System;

class Product
{
// Contains the name, product id, price, and quantity of each product.
    private string _productName = "";
    private int _productId = 0;
    private int _price = 0;
    private int _quantity = 0;

    public Product(string name,int price, int id, int amount ){
        _productName = name;
        _productId = id;
        _price = price;
        _quantity = amount;
    }

    public Product(){
        _productId = 1354;
        _productName = "Spinner";
        _price = 30;
        _quantity = 2;
    }
// The price of this product is computed by multiplying the price and the quantity.
    public int GetTotalPrice()
    {
        int price = 0;
        price = _price * _quantity;
        return price;
    }

    public void SetProductName(string name){
        _productName = name;
    }

    public string GetProductName(){
        return _productName;
    }

    public void SetProductID(int id){
        _productId = id;
    }

    public int GetProductID(){
        return _productId;
    }

    public void SetProductPrice(int price){
        _price = price;
    }

    public int GetProductPrice(){
        return _price;
    }

    public void SetQuantity(int amount){
        _quantity = amount;
    }

    public int GetQuantity(){
        return _quantity;
    }

    
}