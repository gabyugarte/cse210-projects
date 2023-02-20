using System;
using System.Collections.Generic;

namespace MindfulnessApp
{
    public class UserInterface
    {
        public static int ShowMainMenu()
        {
            Console.WriteLine("Welcome to Mindful Activities!");
            Console.WriteLine("Please select an activity:");
            Console.WriteLine("1. Breathing Exercise");
            Console.WriteLine("2. Reflection Exercise");
            Console.WriteLine("3. Listing Exercise");
            Console.WriteLine("4. Quit");

            int selection;
            while (true)
            {
                Console.Write("Enter the number of your selection: ");
                string input = Console.ReadLine();

                if (int.TryParse(input, out selection) && selection >= 1 && selection <= 4)
                {
                    break;
                }

                Console.WriteLine("Invalid selection. Please try again.");
            }

            return selection;
        }

        public static void ShowBreathingInstructions()
        {
            Console.WriteLine("Breathing Exercise");
            Console.WriteLine("Breathe in for 4 seconds");
            Console.WriteLine("Hold for 4 seconds");
            Console.WriteLine("Breathe out for 4 seconds");
        }

        public static void ShowReflectionPrompt(string prompt)
        {
            Console.WriteLine("Reflection Exercise");
            Console.WriteLine(prompt);
        }

        public static void ShowListingPrompt(string prompt)
        {
            Console.WriteLine("Listing Exercise");
            Console.WriteLine(prompt);
        }

        public static string GetReflectionAnswer()
        {
            Console.Write("Enter your response: ");
            return Console.ReadLine();
        }

        public static string GetListingAnswer()
        {
            Console.Write("Enter an item: ");
            return Console.ReadLine();
        }

        public static void ShowMessage(string message)
        {
            Console.WriteLine(message);
        }

        public static void ShowSpinner(int seconds)
        {
            Console.CursorVisible = false;

            int i = 0;
            string[] spinner = { "/", "-", "\\", "|" };

            while (i < seconds * 4)
            {
                Console.Write($"\r{spinner[i % 4]}");
                i++;
                System.Threading.Thread.Sleep(250);
            }

            Console.CursorVisible = true;
            Console.WriteLine();
        }
    }
}
