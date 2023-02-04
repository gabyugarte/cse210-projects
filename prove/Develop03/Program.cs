using System;

namespace ScriptureHider
{
    class Program
    {
        static void Main(string[] args)
        {
            Scripture scripture = new Scripture("John 3:16", "For God so loved the world that he gave his one and only Son, that whoever believes in him shall not perish but have eternal life.");
            string input;

            do
            {
                Screen.ClearScreen();
                Screen.DisplayScripture(scripture);
                Console.WriteLine("Press Enter to hide more words, or type 'quit' to exit:");
                input = Console.ReadLine();
                if (input != "quit")
                {
                    WordHider.HideWords(scripture);
                }
            } while (input != "quit" && !WordHider.AllWordsHidden(scripture));
        }
    }
}