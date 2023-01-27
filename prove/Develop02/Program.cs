using System;
using System.Collections.Generic;
using System.IO;

class Menu
{
    static string[] prompts = new string[]
    {
        "Who was the most interesting person you interacted with today?",
        "What was the best part of your day?",
        "How did you see the hand of the Lord in your life today?",
        "What was the strongest emotion you felt today?",
        "If you had one thing you could do over today, what would it be?"
    };

    static void Main(string[] args)
    {
        var journal = new Journal();
        var running = true;
        while (running)
        {
            Console.WriteLine("1. Write a new entry");
            Console.WriteLine("2. Display journal");
            Console.WriteLine("3. Save journal to file");
            Console.WriteLine("4. Load journal from file");
            Console.WriteLine("5. Exit");
                  var choice = Console.ReadLine();
            switch (choice){
                case "1":
                    var random = new Random();
                    var prompt = prompts[random.Next(prompts.Length)];
                    Console.WriteLine("Prompt: " + prompt);
                    var response = Console.ReadLine();
                    var date = DateTime.Now.ToString();
                    journal.AddEntry(prompt, response, date);
                    Console.WriteLine("Journal entry added!");
                    break;
                case "2":
                    journal.Display();
                    break;
                case "3":
                    Console.WriteLine("Enter a filename:");
                    var saveFilename = Console.ReadLine();
                    journal.Save(saveFilename);
                    Console.WriteLine("Journal saved to " + saveFilename);
                    break;
                case "4":
                    Console.WriteLine("Enter a filename:");
                    var loadFilename = Console.ReadLine();
                    journal.Load(loadFilename);
                    Console.WriteLine("Journal loaded from " + loadFilename);
                    break;
                case "5":
                    running = false;
                    break;
                default:
                    Console.WriteLine("Invalid choice. Please try again.");
                    break;
            }
        }
    }
}