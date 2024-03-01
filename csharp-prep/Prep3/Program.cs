using System;

class Program
{
    static void Main(string[] args)
    {
       Random random = new Random();
        bool playAgain = true;

        while (playAgain)
        {
            int magicNumber = random.Next(1, 101); // Generate a random magic number
            int attempt = 0;
            bool guessed = false;

            while (!guessed)
            {
                Console.WriteLine($"What is the magic number? {magicNumber}");
                Console.Write("What is your guess? ");
                int guess = Convert.ToInt32(Console.ReadLine());
                attempt++;

                if (magicNumber > guess)
                {
                    Console.WriteLine("Higher");
                }
                else if (magicNumber < guess)
                {
                    Console.WriteLine("Lower");
                }
                else
                {
                    Console.WriteLine("You guessed it!");
                    guessed = true;
                }
            }

            Console.WriteLine($"It took you {attempt} attempt.");

            Console.Write("Do you want to play again? (yes/no): ");
            string response = Console.ReadLine().ToLower();
            if (response != "yes")
            {
                playAgain = false;
            }
        }

        Console.WriteLine("Thanks for playing!");
        
    }
}
    
