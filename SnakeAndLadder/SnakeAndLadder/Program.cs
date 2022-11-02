namespace SnakeAndLadder
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Snake and Ladder Game !!");

            int PlayerPosition = 0;
            int diceRoll;
            Random random = new Random();

            Console.WriteLine("\nEnter w to Play the game");
            string play = Console.ReadLine();
            Console.WriteLine($"\nPlayer is at position {PlayerPosition}");

            diceRoll = random.Next(1, 6);
            Console.WriteLine($"\nPlayer rolled number {diceRoll}");
        }
    }
}