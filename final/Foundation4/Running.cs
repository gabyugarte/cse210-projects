using System;

public class Running : Activity {
    private double distance;

    public Running(DateTime date, int duration, double distance) : base(date, duration) {
        this.distance = distance;
    }

    public double Distance {
        get { return distance; }
    }

    public override double GetDistance() {
        return distance;
    }

    public override double GetSpeed() {
        return (distance / Duration) * 60;
    }

    public override double GetPace() {
        return Duration / distance;
    }

    public override string GetSummary() {
        return string.Format("{0} Running ({1} min) - Distance: {2:F2} miles, Speed: {3:F2} mph, Pace: {4:F1} min/mile", Date.ToString("dd MMM yyyy"), Duration, Distance, GetSpeed(), GetPace());
    }
}
