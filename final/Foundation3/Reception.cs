public class Reception : Event
{
private string rsvpEmail;
public Reception(string title, string description, DateTime date, TimeSpan time, Address address, string rsvpEmail) : base(title, description, date, time, address)
{
    this.rsvpEmail = rsvpEmail;
}

public override string GetFullDetails()
{
    return $"Title: {base.title}\nDescription: {base.description}\nDate: {base.date.ToShortDateString()}\nTime: {base.time}\nAddress: {base.address.GetAddress()}\nType: Reception\nRSVP Email: {rsvpEmail}";
}

public override string GetShortDescription()
{
    return $"Type: Reception\nTitle: {base.title}\nDate: {base.date.ToShortDateString()}";
}
}

