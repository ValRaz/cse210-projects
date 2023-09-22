using System;

class Program
{
    static void Main(string[] args)
    {
        bool playAgain = true;
        Random randomGenerator = new Random();

        while (playAgain)
        {
            Console.Write("What is the magic number?");
            int magicGuess = int.Parse(Console.ReadLine());

            int magicNumber = randomGenerator.Next(1, 101);
            int numberOfGuesses = 0;

            while (magicGuess != magicNumber)
            {
                Console.Write("What is your guess? ");
                magicGuess = int.Parse(Console.ReadLine());
                numberOfGuesses++;

                if (magicNumber > magicGuess)
                {
                    Console.WriteLine("Higher");
                }
                else if (magicNumber < magicGuess)
                {
                    Console.WriteLine("Lower");
                }
                else
                {
                    Console.WriteLine("You guessed it!");
                }
            }

            Console.WriteLine($"You guessed {numberOfGuesses} times.");
            Console.Write("Would you like to play again? (yes/no): ");
            string playAgainResponse = Console.ReadLine().ToLower();

            if (playAgainResponse != "yes")
            {
                playAgain = false;
            }
        }
    }
}