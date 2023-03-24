using System;

// The address contains a string for the street address, the city, state/province, and country.
class Address
{
    private string _street = "";
    private string _city = "";
    private string _state = "";
    private string _country = "";

// The address should have a method that can return whether it is in the USA or not.
    public bool IsAddressInTheUS()
    {
        return _country == "USA";
    }

// The address should have a method to return a string all of its fields together in one string (with newline characters where appropriate)
    public string DisplayAddress() {
        return $"Street:{_street} City:{_city} State:{_state} Country:{_country}";
    }
}