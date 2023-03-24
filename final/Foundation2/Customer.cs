// The customer contains a name and an address.
// The name is a string, but the Address is a class.
// The customer should have a method that can return whether they live in the USA or not. (Hint this should call a method on the address to find this.)
using System;

class Customer
{


    private string _name = "";
    private Address _address = new Address("Brazil");
    
    public Customer(string name){
        //set name
        _name = name;
        //default address
        _address = new Address();
    }
    public bool DoesCustomerLiveInTheUS()
    {
        Address address = new Address();
        return address.IsAddressInTheUS();
    }

    public string GetCustomerName(){
        return _name;
    }

    public string GetCustomerAddress(){
        return _address.DisplayAddress();
    }
}