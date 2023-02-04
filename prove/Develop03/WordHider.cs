using System;

namespace ScriptureHider
{
    class WordHider
    {
        private static readonly Random rand = new Random();

        public static void HideWords(Scripture scripture)
        {
            string[] words = scripture.GetText().Split(' ');
            for (int i = 0; i < words.Length; i++)
            {
                if (rand.Next(2) == 0)
                {
                    words[i] = "____";
                }
            }
            scripture.SetText(string.Join(" ", words));
        }

        public static bool AllWordsHidden(Scripture scripture)
        {
            return !scripture.GetText().Contains(" ");
        }
    }
}
