using System;

class Program
{
    static void Main(string[] args)
    {
        //Creates an address for events
        Address address1 = new Address("123 Main St", "Anytown", "Anystate", "USA");
        Address address2 = new Address("456 Side St", "Newtown", "Newstate", "Australia");
        Address address3 = new Address("789 Christmas Ave", "Sometown", "Anotherstate", "USA");
        Address address4 = new Address("147 East First ST", "Othertown", "Somestate", "Australia");
        Address address5 = new Address("258 Jettsons Way", "Futuretown", "Futurestate", "USA");
        Address address6 = new Address("369 Clampett Trail", "Oldtown", "Oldstate", "Australia");             

        //Creates reception events
        Reception receptionEvent1 = new Reception("USA Reception Event", "2024-3-26", "Reception", address1, "SomeCompany Inc", "18:00", "eventemail1@email.com");
        Reception receptionEvent2 =  new Reception("Australia Reception Event", "2024-05-5", "Reception", address2, "Othercompany Corporation", "15:30", "eventemail2@email.com");

        //Creates outdoor events
        OutdoorGathering outdoorEvent1 = new OutdoorGathering("USA Gathering", "2024-6-15", "Outdoor Gathering", address3, "Nature Walk");
        OutdoorGathering outdoorEvent2 = new OutdoorGathering("Australia Gathering", "2024-02-25", "Outdoor Gathering", address4, "Pot Luck Picnic");

        //Created Lecture events
        Lecture lectureEvent1 = new Lecture("USA Lecture Event", "2024-1-9", "Lecture", address5, "Electromagnetism", "James Clerk Maxwell");
        Lecture lectureEvent2 = new Lecture("USA Lecture Event", "2024-1-9", "Lecture", address6, "Silent Spring, the Writer's View", "Rachel Carson");

        //Generates marketing messages for Reception events
        Console.WriteLine("Reception Events:");
        receptionEvent1.GenerateMarketingMessage();
        Console.WriteLine();
        receptionEvent2.GenerateMarketingMessage();

        //Generates marketing messages for Outdoor Gathering events
        Console.WriteLine("\nOutdoor Gethering Events-");
        outdoorEvent1.GenerateMarketingMessage();
        Console.WriteLine();
        outdoorEvent2.GenerateMarketingMessage();

        //Generates marketing messages for Lecture events
        Console.WriteLine("\nLecture Events-");
        lectureEvent1.GenerateMarketingMessage();
        Console.WriteLine();
        lectureEvent2.GenerateMarketingMessage();
    }
}