// Derived class for simple goals
class SimpleGoal : Activity {
// Constructor
public SimpleGoal(string name, int points) : base(name, points) {
    // Implementation of RecordEvent method
}
public override void RecordEvent() {
    SetPoints(GetPoints() + base.GetPoints());
}
}