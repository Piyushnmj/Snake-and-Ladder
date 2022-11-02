namespace SnakeAndLadder
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Snake and Ladder Game !!");

            int PlayerPosition = 0;

            Console.WriteLine("\nPress ENTER to Play the game");
            string play = Console.ReadLine();

            Console.WriteLine($"Player is at Start position {PlayerPosition}");
        }
    }
}