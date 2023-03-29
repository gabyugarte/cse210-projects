using System;

public abstract class Activity {
    private DateTime date;
    private int duration;

    public Activity(DateTime date, int duration) {
        this.date = date;
        this.duration = duration;
    }

    public DateTime Date {
        get { return date; }
    }

    public int Duration {
        get { return duration; }
    }

    public abstract double GetDistance();
    public abstract double GetSpeed();
    public abstract double GetPace();

    public virtual string GetSummary() {
        return string.Format("{0} ({1} min) - Distance: {2:F2} km, Speed: {3:F2} kph, Pace: {4:F1} min/km", date.ToString("dd MMM yyyy"), duration, GetDistance(), GetSpeed(), GetPace());
    }
}
