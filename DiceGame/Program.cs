using System;

internal class Program
{
    private static void Main(string[] args)
    {
        int playerRandomNumber;
        int computerRandomNumber;

        int playerScore = 0;
        int computerScore = 0;

        Random random = new Random();

        Console.WriteLine("===============================================");
        Console.WriteLine("           Welcome to the Dice Game!");
        Console.WriteLine("===============================================\n");

        for (int i = 1; i <= 10; i++)
        {
            Console.WriteLine($"Round {i}: Press any key to roll the dice!");
            Console.ReadKey(intercept: true);

            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.Write("Rolling your dice");
            SimulateDiceRoll();

            playerRandomNumber = random.Next(1, 7);
            Console.WriteLine($"\nYou rolled a {playerRandomNumber}\n");

            Console.ResetColor();

            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write("Rolling enemy AI dice");
            SimulateDiceRoll();

            computerRandomNumber = random.Next(1, 7);
            Console.WriteLine($"\nEnemy AI rolled a {computerRandomNumber}\n");

            Console.ResetColor();

            Console.WriteLine("-----------------------------------------------");

            if (playerRandomNumber > computerRandomNumber)
            {
                playerScore++;
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("You won this round!");
            }
            else if (computerRandomNumber > playerRandomNumber)
            {
                computerScore++;
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("Enemy AI won this round!");
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Gray;
                Console.WriteLine("It's a draw!");
            }

            Console.ResetColor();
            Console.WriteLine("-----------------------------------------------\n");
        }

        Console.WriteLine("===============================================");
        if (playerScore > computerScore)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"Congratulations! You win the game! ({playerScore} - {computerScore})");
        }
        else if (playerScore < computerScore)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine($"Sorry, you lost the game. ({playerScore} - {computerScore})");
        }
        else
        {
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.WriteLine($"It's a tie! ({playerScore} - {computerScore})");
        }

        Console.ResetColor();
        Console.WriteLine("===============================================");

        Console.WriteLine("\nPress any key to exit...");
        Console.ReadKey(intercept: true);
    }

    private static void SimulateDiceRoll()
    {
        for (int j = 0; j < 3; j++)
        {
            Console.Write(".");
            System.Threading.Thread.Sleep(500);
        }
    }
}
