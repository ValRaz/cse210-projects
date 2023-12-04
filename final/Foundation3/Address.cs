using System;

class Address {
    private string _street;
    private string _city;
    private string _state;
    private string _country;

    //Constructor for an Address
    public Address(string street, string city, string state, string country) {
        _street = street;
        _city = city;
        _state = state;
        _country = country;
    }

    //Getters for address properties
    public string GetStreet() {
        return _street;
    }
    public string GetCity() {
        return _city;
    }
    public string GetState() {
        return _state;
    }
    public string GetCountry() {
        return _country;
    }
}