using System;

namespace ScriptureHider
{
    class Screen
    {
        public static void ClearScreen()
        {
            Console.Clear();
        }

        public static void DisplayScripture(Scripture scripture)
        {
            Console.WriteLine(scripture.GetReference());
            Console.WriteLine(scripture.GetText());
        }
    }
}
