using System;

class OutdoorGathering : Event {
    private string _activity;

    //Constructor for an outdoor gathering event
    public OutdoorGathering(string name, string date, string type, Address address, string activity) : base(name, date, type, address) {
        _activity = activity;
    }

    //Override method to generate an outdoor gathering marketing message
    public override void GenerateMarketingMessage()
    {
        base.GenerateMarketingMessage();
        Console.WriteLine($"Gathering details:");
        Console.WriteLine($"Activity: {_activity}");
    }
}