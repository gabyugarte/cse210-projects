public class Lecture : Event
{
private string speakerName;
private int capacity;

public Lecture(string title, string description, DateTime date, TimeSpan time, Address address, string speakerName, int capacity) : base(title, description, date, time, address)
{
    this.speakerName = speakerName;
    this.capacity = capacity;
}

public override string GetFullDetails()
{
    return $"Title: {base.title}\nDescription: {base.description}\nDate: {base.date.ToShortDateString()}\nTime: {base.time}\nAddress: {base.address.GetAddress()}\nType: Lecture\nSpeaker Name: {speakerName}\nCapacity: {capacity}";
}

public override string GetShortDescription()
{
    return $"Type: Lecture\nTitle: {base.title}\nDate: {base.date.ToShortDateString()}";
}
}