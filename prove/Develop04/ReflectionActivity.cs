using System;

namespace MindfulActivities
{
    public class ReflectionActivity : Activity
    {
        public List<string> ReflectionPrompts { get; set; }
        public List<string> ReflectionQuestions { get; set; }

        public ReflectionActivity(TimeSpan duration, string startingMessage, string endingMessage, List<string> reflectionPrompts, List<string> reflectionQuestions) : base(duration, startingMessage, endingMessage)
        {
            ReflectionPrompts = reflectionPrompts;
            ReflectionQuestions = reflectionQuestions;
        }

        public override void Start()
        {
            Console.WriteLine(base.StartingMessage);

            var prompt = GetRandomPrompt();
            Console.WriteLine(prompt);

            var answer = Console.ReadLine();
            Console.WriteLine($"You said: {answer}");

            var question = GetRandomQuestion();
            Console.WriteLine(question);
        }

        private string GetRandomPrompt()
        {
            var rand = new Random();
            var index = rand.Next(0, ReflectionPrompts.Count);
            return ReflectionPrompts[index];
        }

        private string GetRandomQuestion()
        {
            var rand = new Random();
            var index = rand.Next(0, ReflectionQuestions.Count);
            return ReflectionQuestions[index];
        }
    }
}
