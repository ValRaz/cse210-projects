using System;

class Reception : Event {
    private string _organizer;
    private string _startTime;
    private string _rsvpEmail;

    //Constructor for a reception event
    public Reception(string name, string date, string type, Address address, string organizer, string startTime, string rsvpEmail): base(name, date, type, address) {
        _organizer = organizer;
        _startTime = startTime;
        _rsvpEmail = rsvpEmail;
    }

    //Override method to generate reception event marketing message
    public override void GenerateMarketingMessage()
    {
        base.GenerateMarketingMessage();
        Console.WriteLine("Reception Details:");
        Console.WriteLine($"Organizer: {_organizer}");
        Console.WriteLine($"Start Time: {_startTime}");
        Console.WriteLine($"RSVP Email: {_rsvpEmail}");
    }
}