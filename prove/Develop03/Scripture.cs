using System;

namespace ScriptureHider
{
    class Scripture
    {
        private string reference;
        private string text;
//constructor
        public Scripture(string reference, string text)
        {
            this.reference = reference;
            this.text = text;
        }

        public string GetReference()
        {
            return reference;
        }

        public void SetReference(string reference)
        {
            this.reference = reference;
        }

        public string GetText()
        {
            return text;
        }

        public void SetText(string text)
        {
            this.text = text;
        }
    }
}
