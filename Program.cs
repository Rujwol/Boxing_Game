namespace Boxing_Game
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Initialize variables
            int emptyBoxIndex = 1;
            int playerScore = 0;
            int computerScore = 0;
            Random random = new Random();

            // Game loop
            while (playerScore < 10 && computerScore < 10)
            {
                // Display the current state of the game
                Console.WriteLine("Current Score: Player {0} - {1} Computer", playerScore, computerScore);
                Console.WriteLine("+-+-+");
                Console.WriteLine("|{0}|", emptyBoxIndex == 1 ? " " : "X");
                Console.WriteLine("+-+-+");
                Console.WriteLine("|{0}|", emptyBoxIndex == 2 ? " " : "X");
                Console.WriteLine("+-+-+");
                Console.WriteLine("|{0}|",  emptyBoxIndex == 3 ? " " : "X");

                // Ask the user to choose a box to hit
                Console.Write("Choose a box (1-3): ");
                int userInput = int.Parse(Console.ReadLine());

                //computer doudge the hit
                emptyBoxIndex = random.Next(1, 4);

                // Determine if the user hit the empty box
                if (userInput == emptyBoxIndex)
                {
                    Console.WriteLine("You hit the empty box!");
                    playerScore++;
                }
                else
                {
                    Console.WriteLine("You missed!");
                }

                // Determine if the computer hit the empty box
                int computerInput = random.Next(1, 4);
                if (computerInput == emptyBoxIndex)
                {
                    Console.WriteLine("The computer hit the empty box!");
                    computerScore++;
                }
                else
                {
                    Console.WriteLine("The computer missed!");
                }

                // Randomly choose a new empty box
                emptyBoxIndex = random.Next(1,4);
            }

            // Determine the winner
            if (playerScore > computerScore)
            {
                Console.WriteLine("You win!");
            }
            else
            {
                Console.WriteLine("You lose!");
            }

            Console.WriteLine("Final Score: Player {0} - {1} Computer", playerScore, computerScore);
        }
    }
}