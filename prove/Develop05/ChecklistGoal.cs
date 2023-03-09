// Derived class for checklist goals
class ChecklistGoal : Activity {
private int timesCompleted;
private int requiredTimes;
// Constructor
public ChecklistGoal(string name, int points, int requiredTimes) : base(name, points) {
    timesCompleted = 0;
    this.requiredTimes = requiredTimes;
}

// Implementation of RecordEvent method
public override void RecordEvent() {
    SetPoints(GetPoints() + base.GetPoints());
    timesCompleted++;
    if (timesCompleted == requiredTimes) {
        SetPoints(GetPoints() + 500);
    }
}

// Override of GetStatus method
public override string GetStatus() {
    return $"[{(timesCompleted == requiredTimes ? "X" : " ")}] {GetName()} ({GetPoints()} points) (Completed {timesCompleted}/{requiredTimes} times)";
}
}
