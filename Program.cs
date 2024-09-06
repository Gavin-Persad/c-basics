using System;

class Program
{
    static void Main()
    {
        string[] choices = { "rock", "paper", "scissors" };
        Random random = new Random();

        while (true)
        {
            Console.WriteLine("Enter rock, paper, or scissors (or 'exit' to quit): ");
            string userChoice = Console.ReadLine().ToLower();

            if (userChoice == "exit")
            {
                break;
            }

            if (Array.IndexOf(choices, userChoice) == -1)
            {
                Console.WriteLine("Invalid choice. Please try again.");
                continue;
            }

            string computerChoice = choices[random.Next(choices.Length)];
            Console.WriteLine($"Computer chose: {computerChoice}");

            if (userChoice == computerChoice)
            {
                Console.WriteLine("It's a tie!");
            }
            else if ((userChoice == "rock" && computerChoice == "scissors") ||
                     (userChoice == "paper" && computerChoice == "rock") ||
                     (userChoice == "scissors" && computerChoice == "paper"))
            {
                Console.WriteLine("You win!");
            }
            else
            {
                Console.WriteLine("You lose!");
            }
        }
    }
}
