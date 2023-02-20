using System;
using System.Collections.Generic;

namespace MindfulnessApp
{
    public class ListingActivity : Activity
    {
        public List<string> Prompts { get; set; }
        public List<string> UserInputs { get; set; }

        public ListingActivity(int duration, string startMessage, string endMessage, List<string> prompts, List<string> userInputs)
            : base(duration, startMessage, endMessage)
        {
            Prompts = prompts;
            UserInputs = userInputs;
        }

        public void DoListingActivity()
        {
            foreach (string prompt in Prompts)
            {
                Console.WriteLine(prompt);
                string input = Console.ReadLine();
                UserInputs.Add(input);
            }

            DoActivity();
        }
    }
}
