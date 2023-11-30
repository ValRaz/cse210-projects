using System;
using System.Collections.Generic;

class Customer {
    private string _name;
    private Address _address;

    //Constructor for a Customer
    public Customer(string name, Address address) {
        _name = name;
        _address = address;
    }

    //Checks if the the customer is in the USA
    public bool GetInUSA() {
        return _address.IsinUSA();
    }

    //Gets customer's name
    public string GetCustName() {
        return _name;
    }


    //Gets full address of the Customer
    public string GetFullAddress() {
        return _address.GetAddress();
    }
}