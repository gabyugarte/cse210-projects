// File: Activity.cs
using System;

// Base class for all activities
abstract class Activity {
private string name;
private int points;
// Constructor
public Activity(string name, int points) {
    this.name = name;
    this.points = points;
}

// Getters and setters
public string GetName() {
    return name;
}

public int GetPoints() {
    return points;
}

public void SetPoints(int points) {
    this.points = points;
}

// Abstract method to be implemented by derived classes
public abstract void RecordEvent();

// Method to display the activity's status
public virtual string GetStatus() {
    return $"[ ] {name} ({points} points)";
}
}