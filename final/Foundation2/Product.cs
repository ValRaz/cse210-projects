using System;
using System.Collections.Generic;

class Product {
    private string _name;
    private string _productID;
    private decimal _price;
    private int _quantity;

    //Constructor for a Product
    public Product(string name, string productID, decimal price, int quantity) {
        _name = name;
        _productID = productID;
        _price = price;
        _quantity = quantity;
    }

    //Gets total price for a product
    public decimal GetPrice() {
        return _price * _quantity;
    }
    
    //Gets product name
    public string GetProductName() {
        return _name;
    }

    //Gets the product ID
    public string GetProductID() {
        return _productID;
    }

    //Gets the quantity of the product
    public int GetQuantity() {
        return _quantity;
    }
}

