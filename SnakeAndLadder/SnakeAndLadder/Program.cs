namespace SnakeAndLadder
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Snake and Ladder Game !!");

            const int StartingPosition = 0;
            const int WinningPosition = 100;
            int PlayerPosition1 = 0;
            int PlayerPosition2 = 0;
            int diceRollCount = 0;
            int diceRoll;
            bool Player1 = true;
            bool Player2 = false;


            Console.WriteLine("\nPress ENTER to Play the game");
            string play = Console.ReadLine();
            Console.WriteLine($"Player is at position {PlayerPosition1}");

            Random random = new Random();
            while (PlayerPosition1 < WinningPosition && PlayerPosition2 < WinningPosition)
            {
                diceRoll = random.Next(1, 7); //dice
                if (Player1)
                {
                    Console.WriteLine($"\nPlayer 1 rolled number {diceRoll} on position {PlayerPosition1}");
                    diceRollCount++;
                    int option = random.Next(1, 3); //switch case
                    switch (option)
                    {
                        case 1:
                            Console.WriteLine("Player 1 landed on a Ladder");
                            PlayerPosition1 += diceRoll;
                            Console.WriteLine($"Player 1 moves to position {PlayerPosition1}");
                            if (PlayerPosition1 > WinningPosition)
                            {
                                PlayerPosition1 = PlayerPosition1 - diceRoll;
                                Console.WriteLine($"No Play, Player 1 remains in position {PlayerPosition1}");
                            }
                            break;
                        case 2:
                            Console.WriteLine("Player 1 landed on a Snake");
                            PlayerPosition1 -= diceRoll;
                            Console.WriteLine($"Player 1 moves to position {PlayerPosition1}");
                            if (PlayerPosition1 < StartingPosition)
                            {
                                Console.WriteLine("No Play, Try Again");
                                PlayerPosition1 = 0;
                            }
                            Player2 = true;
                            Player1 = false;
                            break;
                    }
                }
                else if (Player2)
                {
                    Console.WriteLine($"\nPlayer 2 rolled number {diceRoll} on position {PlayerPosition2}");
                    diceRollCount++;
                    int option1 = random.Next(1, 3);
                    switch (option1)
                    {
                        case 1:
                            Console.WriteLine("Player 2 landed on a Ladder");
                            PlayerPosition2 += diceRoll;
                            Console.WriteLine($"Player 2 moves to position {PlayerPosition2}");
                            if (PlayerPosition2 > WinningPosition)
                            {
                                PlayerPosition2 = PlayerPosition2 - diceRoll;
                                Console.WriteLine($"Player 2 remains in position {PlayerPosition2}");
                            }
                            break;
                        case 2:
                            Console.WriteLine("Player 2 landed on a Snake");
                            PlayerPosition2 -= diceRoll;
                            Console.WriteLine($"Player 2 moves to position {PlayerPosition2}");
                            if (PlayerPosition2 < 0)
                            {
                                Console.WriteLine("No Play, Try Again");
                                PlayerPosition2 = 0;
                            }
                            Player1 = true;
                            Player2 = false;
                            break;
                    }
                }
            }
            if (PlayerPosition1 == 100)
            {
                Console.WriteLine("\n==========Player1 Wins==========");
            }
            if (PlayerPosition2 == 100)
            {
                Console.WriteLine("\n==========Player2 Wins==========");
            }
            Console.WriteLine($"\nDice was played {diceRollCount} times to win the game");
            Console.ReadLine();
        }
    }
}