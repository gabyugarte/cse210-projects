using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What is your grade percentage? ");
        string grade = Console.ReadLine();
        int gradeInt = int.Parse(grade);
        string letter = "";
        if (gradeInt >= 90)
        {
            letter = "A";
        }
        else if (gradeInt >= 80)
        {
            letter = "B";
        }
        else if (gradeInt >= 70)
        {
            letter = "C";
            Console.WriteLine("Congratulations! You passed the course");
        
        }
        else if (gradeInt >= 60)
        {
            letter = "D";
        }
        else if (gradeInt < 60)
        {
            letter = "F";
        }
        Console.WriteLine ($"Your letter grade is: {letter}");
        
        if (gradeInt >= 70)
        {
            Console.WriteLine ("Congratulations! You passed the course");
        }
        else{
            Console.WriteLine ("Better luck next time!");
        }
    }
}