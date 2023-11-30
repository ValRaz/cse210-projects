using System;
using System.Collections.Generic;

class Address {
    private string _street;
    private string _city;
    private string _state;
    private string _country;
    private Boolean _isInUSA;


    //Constructor for an Address
    public Address(string street, string city, string state, string country) {
        _street = street;
        _city = city;
        _state = state;
        _country = country;
        _isInUSA = DetermineIfInUSA(_country);
    }

    //Determines if the address is in the USA
    private bool DetermineIfInUSA(string country) {
        return country.ToUpper() =="USA";
    }

    public bool IsinUSA() {
        return _isInUSA;
    }

    //Gets address details as a string
    public string GetAddress() {
        return $"{_street}\n{_city}, {_state}\n{_country}";
    }
}