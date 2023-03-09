// File: Program.cs
using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

class Program {
// List to store all the activities
private static List<Activity> activities = new List<Activity>();
// Method to display the menu options
private static void DisplayMenu() {
    Console.WriteLine("1. Create new activity");
    Console.WriteLine("2. Record event");
    Console.WriteLine("3. Display all activities");
    Console.WriteLine("4. Save activities");
    Console.WriteLine("5. Load activities");
    Console.WriteLine("6. Exit");
}

// Method to create a new activity
private static void CreateActivity() {
    Console.WriteLine("Enter activity type (1 = simple goal, 2 = eternal goal, 3 = checklist goal):");
    int type = int.Parse(Console.ReadLine());
    Console.WriteLine("Enter activity name:");
    string name = Console.ReadLine();
    Console.WriteLine("Enter activity points:");
    int points = int.Parse(Console.ReadLine());
    switch (type) {
        case 1:
            activities.Add(new SimpleGoal(name, points));
            break;
        case 2:
            activities.Add(new EternalGoal(name, points));
            break;
        case 3:
            Console.WriteLine("Enter required number of completions:");
            int requiredTimes = int.Parse(Console.ReadLine());
            activities.Add(new ChecklistGoal(name, points, requiredTimes));
            break;
        default:
            Console.WriteLine("Invalid activity type");
            break;
    }
}

// Method to record an event
private static void RecordEvent() {
    Console.WriteLine("Enter activity name:");
    string name = Console.ReadLine();
    foreach (Activity activity in activities) {
        if (activity.GetName() == name) {
            activity.RecordEvent();
            Console.WriteLine($"Event recorded for {name}. New score: {activity.GetPoints()} points");
            return;
        }
    }
    Console.WriteLine($"Activity not found: {name}");
}

// Method to display all activities and their status
private static void DisplayAllActivities() {
    Console.WriteLine("All activities:");
    foreach (Activity activity in activities) {
        Console.WriteLine(activity.GetStatus());
    }
}

// Method to save activities to a file
private static void SaveActivities() {
    Console.WriteLine("Enter file name:");
    string fileName = Console.ReadLine();
    BinaryFormatter formatter = new BinaryFormatter();
    FileStream stream = new FileStream(fileName, FileMode.Create);
    // formatter.Serialize(stream, activities);
    stream.Close();
    Console.WriteLine($"Activities saved to file: {fileName}");
}

// Method to load activities from a file
private static void LoadActivities() {
    Console.WriteLine("Enter file name:");
    string fileName = Console.ReadLine();
    BinaryFormatter formatter = new BinaryFormatter();
    FileStream stream = new FileStream(fileName, FileMode.Open);
    // activities = (List<Activity>)formatter.Deserialize(stream);
    stream.Close();
    Console.WriteLine($"Activities loaded from file: {fileName}");
}

// Main method
static void Main(string[] args) {
    // Load activities from file if it exists
    if (File.Exists("activities.dat")) {
        BinaryFormatter formatter = new BinaryFormatter();
        FileStream stream = new FileStream("activities.dat", FileMode.Open);
        // activities = (List<Activity>)formatter.Deserialize(stream);
        stream.Close();
    }

       while (true) {
        DisplayMenu();
        Console.WriteLine("Enter choice:");
        int choice = int.Parse(Console.ReadLine());
        switch (choice) {
            case 1:
                CreateActivity();
                break;
            case 2:
                RecordEvent();
                break;
            case 3:
                DisplayAllActivities();
                break;
            case 4:
                SaveActivities();
                break;
            case 5:
                LoadActivities();
                break;
            case 6:
                // Save activities to file before exiting
                BinaryFormatter formatter = new BinaryFormatter();
                FileStream stream = new FileStream("activities.dat", FileMode.Create);
                // formatter.Serialize(stream, activities);
                stream.Close();
                Console.WriteLine("Goodbye!");
                return;
            default:
                Console.WriteLine("Invalid choice");
                break;
        }
        Console.WriteLine();
    }
}
}
