using System;

namespace MindfulActivities
{
    public class BreathingActivity : Activity
    {
        public string BreathingMessage { get; set; }

        public BreathingActivity(TimeSpan duration, string startingMessage, string endingMessage, string breathingMessage) : base(duration, startingMessage, endingMessage)
        {
            BreathingMessage = breathingMessage;
        }

        public override void Start()
        {
            Console.WriteLine(base.StartingMessage);
            Console.WriteLine(BreathingMessage);
        }
    }
}
