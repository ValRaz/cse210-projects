using System;
using System.Collections.Generic;

class Order {
    private List<Product> _products;
    private Customer _customer;

    //Constructor for an Order
    public Order(Customer customer, List<Product> products) {
        _customer = customer;
        _products = products;
    }

    //Calculates the total price of an order
    public decimal CalculateTotalPrice() {
        decimal totalPrice = 0;
        foreach (Product product in _products) {
            totalPrice += product.GetPrice();
        }

        //Adds shipping cost based on customer country
        decimal totalPriceWithShipping = totalPrice + (_customer.GetInUSA() ? 5 : 35);

        //Formats the total price to display cents
        return totalPriceWithShipping;
    }

    //Gets packing label for the order
    public string GetPackingLabel() {
        string label = "";
        foreach (Product product in _products) {
            label += $"Name {product.GetProductName()}, ID: {product.GetProductID()}\n";
        }
        return label;
    }

    //Gets shipping label for the order
    public string GetShippingLabel() {
        return $"Name: {_customer.GetCustName()}\n{_customer.GetFullAddress()}";
    }
}