using System;

class Program
{
    static void Main(string[] args)
    {
      
        Random randonGenerator = new Random();
        int magicNumberInt = randonGenerator.Next(1, 101);

        int guessInt = -1;
        while (guessInt != magicNumberInt)
        {
            Console.Write("What is your guess?");
            guessInt = int.Parse(Console.ReadLine());

            if (magicNumberInt > guessInt)
            {
                Console.WriteLine("Higher");
            }
            else if (magicNumberInt < guessInt)
            {
                Console.WriteLine("Lower");
            }
            else if (magicNumberInt == guessInt)
            {
                Console.WriteLine("You guessed it!");
            }
        }
        

    }
}