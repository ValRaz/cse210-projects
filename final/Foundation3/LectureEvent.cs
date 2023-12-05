using System;

class Lecture : Event {
    private string _topic;
    private string _speakerName;

    //Constructor for a Lecture event
    public Lecture(string name, string date, string type, Address address, string topic, string speakerName) : base(name, date, type, address) {
        _topic = topic;
        _speakerName = speakerName;
    }

    //Override method to generate lecture marketing details
    public override void GenerateMarketingMessage()
    {
        base.GenerateMarketingMessage();
        Console.WriteLine($"Lecture details:");
        Console.WriteLine($"Topic: {_topic}");
        Console.WriteLine($"Speaker: {_speakerName}");
    }
}