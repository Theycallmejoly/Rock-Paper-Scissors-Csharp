using System;

class Program
{
    enum Choice { Rock, Scissors, Paper }

    static void Main(string[] args)
    {
        Random random = new Random();
        int playerScore = 0;
        int enemyScore = 0;

        Console.WriteLine("Welcome to Rock, Paper, Scissors game!");

        while (playerScore < 3 && enemyScore < 3)
        {
            Console.WriteLine($"Player score: {playerScore} | Enemy score: {enemyScore}");
            Choice playerChoice;
            while (true)
            {
                Console.WriteLine("Enter 'r' for rock, 'p' for paper, or 's' for scissors:");
                string input = Console.ReadLine().ToLower();

                if (input == "r")
                {
                    playerChoice = Choice.Rock;
                    break;
                }
                else if (input == "s")
                {
                    playerChoice = Choice.Scissors;
                    break;
                }
                else if (input == "p") 
                {
                    playerChoice = Choice.Paper;
                    break;
                }
                else
                {
                    Console.WriteLine("Invalid input. Please try again."); 
                }
            }

            Choice enemyChoice = (Choice)random.Next(0, 3);
            Console.WriteLine($"Enemy chose {enemyChoice}");

            if (playerChoice == enemyChoice)
            {
                Console.WriteLine("It's a tie!");
            }
            else if ((playerChoice == Choice.Rock && enemyChoice == Choice.Scissors) ||
                     (playerChoice == Choice.Paper && enemyChoice == Choice.Rock) ||
                     (playerChoice == Choice.Scissors && enemyChoice == Choice.Paper))
            {
                Console.WriteLine("You win this round!");
                playerScore++;
            }
            else
            {
                Console.WriteLine("Enemy wins this round!");
                enemyScore++;
            }
        }

        if (playerScore == 3)
        {
            Console.WriteLine("Congratulations! You won the game!");
        }
        else
        {
            Console.WriteLine("Sorry, the enemy won the game.");
        }
    }
}
