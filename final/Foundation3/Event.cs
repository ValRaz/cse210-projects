using System;

class Event {
    private string _name;
    private string _date;
    private string _type;
    private Address _address;

    //Constructor for an Event
    public Event(string name, string date, string type, Address address) {
        _name = name;
        _date = date;
        _type = type;
        _address = address;
    }

    //Virtual method to generate a standard marketing message
    public virtual void GenerateMarketingMessage() {
        Console.WriteLine("Standard details:");
        Console.WriteLine($"Title: {_name}");
        Console.WriteLine($"Date: {_date}");
        Console.WriteLine($"Address: {_address.GetStreet()}, {_address.GetCity()}, {_address.GetState()}, {_address.GetCountry()}");
    }
}