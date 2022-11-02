namespace SnakeAndLadder
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Snake and Ladder Game !!");

            int PlayerPosition = 0;
            int diceRoll;

            Console.WriteLine("\nPress ENTER to Play the game");
            string play = Console.ReadLine();
            Console.WriteLine($"Player is at position {PlayerPosition}");

            Random random = new Random();
            diceRoll = random.Next(1, 7);
            Console.WriteLine($"\nPlayer rolled number {diceRoll}");
        }
    }
}