using System;

class Program
{
static void Main(string[] args)
{
// create an Address instance
Address address = new Address("123 Main St", "Anytown", "CA", "12345");
    // create an instance of each event type
    Lecture lecture = new Lecture("Introduction to C#", "Learn the basics of C#", new DateTime(2023, 4, 1), new TimeSpan(14, 0, 0), address, "John Smith", 50);
    Reception reception = new Reception("Networking Event", "Meet other professionals in your industry", new DateTime(2023, 4, 2), new TimeSpan(18, 0, 0), address, "rsvp@example.com");
    OutdoorGathering gathering = new OutdoorGathering("Picnic in the Park", "Enjoy food and games with friends", new DateTime(2023, 4, 3), new TimeSpan(12, 0, 0), address, "Sunny with a high of 70 degrees");

    // output the marketing messages for each event
    Console.WriteLine("---Lecture---");
    Console.WriteLine(lecture.GetStandardDetails());
    Console.WriteLine(lecture.GetFullDetails());
    Console.WriteLine(lecture.GetShortDescription());

    Console.WriteLine("---Reception---");
    Console.WriteLine(reception.GetStandardDetails());
    Console.WriteLine(reception.GetFullDetails());
    Console.WriteLine(reception.GetShortDescription());

    Console.WriteLine("---Outdoor Gathering---");
    Console.WriteLine(gathering.GetStandardDetails());
    Console.WriteLine(gathering.GetFullDetails());
    Console.WriteLine(gathering.GetShortDescription());

    // wait for user input to close the console window
    Console.ReadLine();
}
}