using System;

namespace MindfulActivities
{
    public class Activity
    {
        public TimeSpan Duration { get; set; }
        public string StartingMessage { get; set; }
        public string EndingMessage { get; set; }

        public Activity(TimeSpan duration, string startingMessage, string endingMessage)
        {
            Duration = duration;
            StartingMessage = startingMessage;
            EndingMessage = endingMessage;
        }

        public virtual void Start()
        {
            Console.WriteLine(StartingMessage);
        }

        public virtual void End()
        {
            Console.WriteLine(EndingMessage);
        }
    }
}
