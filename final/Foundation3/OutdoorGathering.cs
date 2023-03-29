public class OutdoorGathering : Event
{
private string weatherStatement;
public OutdoorGathering(string title, string description, DateTime date, TimeSpan time, Address address, string weatherStatement) : base(title, description, date, time, address)
{
    this.weatherStatement = weatherStatement;
}

public override string GetFullDetails()
{
    return $"Title: {base.title}\nDescription: {base.description}\nDate: {base.date.ToShortDateString()}\nTime: {base.time}\nAddress: {base.address.GetAddress()}\nType: Outdoor Gathering\nWeather Statement: {weatherStatement}";
}

public override string GetShortDescription()
{
return $"Type: Outdoor Gathering\nTitle: {base.title}\nDate: {base.date.ToShortDateString()}";
}
}
