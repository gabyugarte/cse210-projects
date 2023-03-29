public abstract class Event
{
protected string title;
protected string description;
protected DateTime date;
protected TimeSpan time;
protected Address address;

public Event(string title, string description, DateTime date, TimeSpan time, Address address)
{
    this.title = title;
    this.description = description;
    this.date = date;
    this.time = time;
    this.address = address;
}

public string GetStandardDetails()
{
    return $"Title: {title}\nDescription: {description}\nDate: {date.ToShortDateString()}\nTime: {time}\nAddress: {address.GetAddress()}";
}

public abstract string GetFullDetails();

public abstract string GetShortDescription();
}