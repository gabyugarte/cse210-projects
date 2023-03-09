// Derived class for eternal goals
class EternalGoal : Activity {
private int timesCompleted;
// Constructor
public EternalGoal(string name, int points) : base(name, points) {
    timesCompleted = 0;
}

// Implementation of RecordEvent method
public override void RecordEvent() {
    SetPoints(GetPoints() + base.GetPoints());
    timesCompleted++;
}

// Override of GetStatus method
public override string GetStatus() {
    return $"[ ] {GetName()} ({GetPoints()} points) (Completed {timesCompleted} times)";
}
}